using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerProperlyRegrets.AncillaryStuffyImportantClassModuleFormCrap
{
    public static class RandomMessages
    {
        public static List<string> SplashScreenMessages { get; set; }
        public static List<string> BadTypes { get; set; }

        static RandomMessages()
        {
            GetRandomSplashScreenMessages();
            GetRandomBadTypes();
        }

        private static void GetRandomSplashScreenMessages()
        {
            SplashScreenMessages = new List<string>
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

        private static void GetRandomBadTypes()
        {
            BadTypes = new List<string>
            {
                "Really Bad",
                "Horrible",
                "No Good, Broken",
                "DIRTY",
                "Stinky",
                "Smells like #%*@",
                "Deplorable",
                "Irredeemable",
                "Crime Against The Universe",
                "Opposite of Good",
                "Terrible",
                "Extremely Bad",
                "Unspeakable",
                "Unfathomable",
                "You will go crazy thinking about it"
            };
        }
    }
}
