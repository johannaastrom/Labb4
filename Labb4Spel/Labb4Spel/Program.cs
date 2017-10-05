using System;

namespace Labb4Spel
{
    class Program
    {
        static void Main(string[] args)
        {
            //4 klasser, en för dörrarna, en för rum och en för väggarn, alla ska ha en gemensam abstrakt subklass
            //använda enum för att beskriva olika sorters rutor
            //en 2d array ska representera/skapa kartan


            //nycklar börjar som false, blir true när man tar upp dem, blir false när man använder dem. Nycklar ska vara en klass
            //när man går på en dörr med rätt nyckel så försvinner dem automatiskt
            //något som håller koll på antaler rundor och ökar antalet rundor när man går på ett monster

            Karta karta = new Karta();
            karta.Map();



            Console.ReadKey();
            

        }
    }
}
