using System.Runtime.InteropServices;

namespace D16_ovn_1
{
    internal class Program
    {
        public class Planet
        {
            public string namn;
            public double solavstånd, massa;
            public int antalMånar, upptäcksår;

            public void Print()
            {
                Console.WriteLine($"Planet: {namn}  \n     Solavstånd (AE): {solavstånd} \n     Massa (jordmassor): {massa} \n     Antal kända månar: {antalMånar} Upptäcksår: {upptäcksår}");
               /* if (upptäcksår != int.MinValue)
                {
                    Console.WriteLine($"     Upptäcksår: {upptäcksår}");
                }*/

            }

            //Konstruktor som tar tre parametrar
            public Planet(string namn, double solavstånd, double massa, int antalMånar, int upptäcksår)
            {
                this.namn = namn;
                this.solavstånd = solavstånd;
                this.massa = massa;
                this.antalMånar = 0;
                if (this.upptäcksår == int.MinValue)
                {
                    this.upptäcksår = int.MinValue;
                }
                else
                {
                    this.upptäcksår = upptäcksår;
                }
            }

            //Konstruktor utan parametrar
            public Planet()
            {
                this.namn = "";
                this.solavstånd = 0;
                this.massa = 0;
                this.antalMånar = 0;
                this.upptäcksår = int.MinValue;
            }
        }

        static void Main(string[] args)
        {

            /*  Planet jorden = new Planet() {namn = "Jorden", solavstånd = 1.0, massa = 1.0, antalMånar = 1, upptäcksår = int.MinValue };
              Planet mars = new Planet() {namn = "Mars", solavstånd = 1.523, massa = 0.107, antalMånar = 2, upptäcksår = int.MinValue };           
              Planet Neptunus = new Planet() {namn = "Neptunus", solavstånd = 30.07, massa = 17.147, antalMånar = 14, upptäcksår = 1846 };
            */
            Planet jorden = new Planet("Jorden", 1.0, 1.0, 1, int.MinValue);
            Planet mars = new Planet("Mars", 1.523, 0.107, 2, int.MinValue);
            Planet neptunus = new Planet("Neptunus", 30.07, 17.147, 14, 1846);
            Planet venus = new Planet("Venus", 0.723, 0.815, 0, int.MinValue);

            jorden.Print();
            Console.WriteLine();
            mars.Print();
            Console.WriteLine();
            neptunus.Print();
            Console.WriteLine();
            venus.Print();
            Console.WriteLine("======================================");
            List<Planet> planeter = new List<Planet>(8);
            planeter.Add(new Planet());  // Merkurius
            planeter.Add(venus);          // Venus
            planeter.Add(jorden);         // Jorden
            planeter.Add(mars);           // Mars
            planeter.Add(new Planet());  // Jupiter
            planeter.Add(new Planet());  // Saturnus
            planeter.Add(new Planet());  // Uranus
            planeter.Add(neptunus);       // Neptunus

            planeter[0].namn = "Merkurius";
            planeter[4].namn = "Jupiter";
            planeter[5].namn = "Saturnus";
            planeter[6].namn = "Uranus";
            foreach (Planet planet in planeter)
            {
                planet.Print();
            }
            Console.WriteLine("======================================");

            List<Planet> planet2 = new List<Planet>()
            {
                new Planet() { namn = "Merkurius", solavstånd = 0.387, massa = 0.055, antalMånar = 0, upptäcksår = int.MinValue },
                new Planet() { namn = "Venus", solavstånd = 0.723, massa = 0.815, antalMånar = 0, upptäcksår = int.MinValue },
                new Planet() { namn = "Jorden", solavstånd = 1.0, massa = 1.0, antalMånar = 1, upptäcksår = 1 },
                new Planet() { namn = "Mars", solavstånd = 1.523, massa = 0.107, antalMånar = 2, upptäcksår = int.MinValue },
                new Planet() { namn = "Jupiter", solavstånd = 5.204, massa = 317.8, antalMånar = 80, upptäcksår = int.MinValue },
                new Planet() { namn = "Saturnus", solavstånd = 9.583, massa = 95.16, antalMånar = 83, upptäcksår = int.MinValue },
                new Planet() { namn = "Uranus", solavstånd = 19.191, massa = 14.536, antalMånar = 27, upptäcksår = 1781 },
                new Planet() { namn = "Neptunus", solavstånd = 30.07, massa = 17.147, antalMånar = 14, upptäcksår = 1846 }
            };
            foreach (Planet planet4 in planet2)
            {
                planet4.Print();
            }
            Console.ReadLine();


        }
    }
}