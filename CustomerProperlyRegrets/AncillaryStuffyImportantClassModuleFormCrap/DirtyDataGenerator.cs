using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using CustomerProperlyRegrets.AncillaryStuffyImportantClassModuleFormCrap;

namespace CustomerProperlyRegrets.AncillaryStuffyImportantClassModuleFormCrap
{
    public class DirtyDataGenerator
    {
        private DirtyData GenerateDirtyData()
        {
            var bogus = new Faker();
            return new DirtyData
            {
                Name = GetRandomJunkString(),
                Type = bogus.System.Exception().Message,
                DateToDie = bogus.Date.Between(new DateTime(2000,01,01), new DateTime(2099,12,31) ),
                FakeValue = Decimal.Round(bogus.Random.Decimal(0.01M, 25.00M),2, MidpointRounding.AwayFromZero),
                HowBadIsIt = RandomMessages.BadTypes[bogus.Random.Int(0,RandomMessages.BadTypes.Count -1)],
                IdYouShouldNotSee = bogus.Random.Int(1),
                ItsDIRTY = true,
                ItsHORRIBLE = bogus.Random.Bool()
            };
        }

        private string GetRandomJunkString()
        {
            var junkStringBuilder = new StringBuilder();
            var bogus = new Faker();

            junkStringBuilder.Append(bogus.Hacker.Noun());
            junkStringBuilder.Append(bogus.Random.Int(80081355, 80081500));
            junkStringBuilder.Append("-");
            junkStringBuilder.Append(bogus.Date.Between(new DateTime(2000, 01, 01), new DateTime(2099, 12, 31)).Year);


            return junkStringBuilder.ToString();
        }

        public BindingList<DirtyData> GetDirtyDataList(int amountOfData)
        {
            var dirtyList = new BindingList<DirtyData>();

            for (int i = 0; i <= amountOfData; i++)
            {
                dirtyList.Add(GenerateDirtyData());
            }

            return dirtyList;
        }
    }
}
