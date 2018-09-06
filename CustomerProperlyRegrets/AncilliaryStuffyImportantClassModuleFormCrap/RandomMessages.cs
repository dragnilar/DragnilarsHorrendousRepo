using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerProperlyRegrets.AncilliaryStuffyImportantClassModuleFormCrap
{
    public class RandomMessages
    {
        public List<string> Messages { get; set; }

        public RandomMessages()
        {
            GetRandomMessages();
        }

        private void GetRandomMessages()
        {
            Messages = new List<string>
            {
                "Do these shoes make me look mean?",
                "Downtown, I farted in the city.",
                "How many stoves do you want to buy?",
                "I poop in your coat.",
                "I will kill for useless paper.",
                "My mind is made up. I will wear brown.",
                "If you close this program, it may actually close.",
                "Sorry Michael",
                "This thing is proof that God hates you.",
                "If your parents hated you, they bought you this.",
                "This program is guaranteed to crash.",
                "Now with 100% more configuration files!",
                "This program is so ugly it is infatuating"
            };
        }
    }
}
