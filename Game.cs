using System;
using Genspil;
namespace Genspil
{
    public class GameType
    {        // Basisoplysninger
        public string Name { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
    }


    public class Game
    {
        private int id;
        public double price { get; private set; }
        public GameType type { get; private set; }
        public Game(int id, double price, GameType gametype)
        //private Condition condition
        {
            this.id = id;
            this.price = price;
            //this.condition = condition;
            this.type = gametype;

        }

        public string OpretSpil()
        {
            Console.Write("Indtast spil navn: ");
            string SpilNavn = Console.ReadLine();

            Console.WriteLine("Indtast spil id: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))  // Sørger for at spil id er et tal
            { Console.WriteLine("Forkert input, spil id skal være et tal"); }
            
            Console.WriteLine("Intast pris: ");
            string pris= Console.ReadLine();
            Console.WriteLine(pris);

            Console.WriteLine("Intast game type: ");
            string gametype = (Console.ReadLine());
            Console.WriteLine(gametype);

            Console.WriteLine(

            switch (choice)
            {


            }


            }




        }
        
        static void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("Velkommen til menuen, du har følgende valg muligheder:");
                Console.WriteLine("Tryk på 1 for at oprette et spil");
                Console.WriteLine("Tryk på 2 for at oprette en forespørgsel");
                Console.WriteLine("Tryk på 3 for at få vist oprettede spil");
                Console.WriteLine("Tryk på 4 for at få vist oprettede forespørgelser");
                Console.ReadLine();
            }
        }
    }
}

// public void Display() { }
//public void Checkout();
