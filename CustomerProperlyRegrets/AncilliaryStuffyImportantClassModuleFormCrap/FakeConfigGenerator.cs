using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Bogus;

namespace CustomerProperlyRegrets.AncilliaryStuffyImportantClassModuleFormCrap
{
    public class FakeConfigGenerator
    {
        private FakeConfigurationData GetFakeConfigData()
        {
            var bogus = new Faker();
            return new FakeConfigurationData
            {
                Year = bogus.Date.Between(new DateTime(2000,01,01),new DateTime(2099,12,31)).Year,
                AnotherImportantConnectionString = GetBogusConnectionString(),
                NumberOfTimesIHateYou = bogus.Random.Int(1),
                SomeOtherConnectionString = GetBogusConnectionString(),
                TheLeastImportantConnectionString = GetBogusConnectionString(),
                TheMostImportantConnectionString = GetBogusConnectionString(),
                VeryImportantConnectionString = GetBogusConnectionString()
            };
        }

        private string GetBogusConnectionString()
        {
            var bogus = new Faker();
            var sqlConnectionStringBuilder = new SqlConnectionStringBuilder
            {
                DataSource = bogus.Database.Column(),
                InitialCatalog = bogus.Database.Engine(),
                IntegratedSecurity = true
            };
            return sqlConnectionStringBuilder.ToString();
        }


        public void CreateFakeConfigXmlFile()
        {
            var serializer = new XmlSerializer(typeof(FakeConfigurationData));
            var fileStream = System.IO.File.Create(GetBogusFilePath());
            serializer.Serialize(fileStream, GetFakeConfigData());
        }

        private string GetBogusFilePath()
        {
            var fileExists = true;
            var path = string.Empty;

            while (fileExists)
            {
                var bogus = new Faker();
                var bogusFileName = bogus.System.FileName();
                path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $"//{bogusFileName}.xml";

                fileExists = File.Exists(path);
            }

            return path;
        }
    }
}
