using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMenuLibrary
{
    public class SmartMenu
    {
        //List Object som indenholder vores menu
        List<string> menuLines = new List<string>();     
        
        //Metode der indlæser menu filen til vores list object
        public void LoadMenu(string path)
        {
            int counter = 0;
            string line;            
                
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"..\..\" + path);   

            while ((line = file.ReadLine()) != null)
            {
                menuLines.Add(line);
                counter++;
            }
            file.Close();
        }

        //Metode der køre vores menu
        public void Activate()
        {
            int choice = 0;            

            //Fjerner ;id fra alle liner i vores menu så den er klar til at blive vist til brugeren
            foreach (var item in menuLines)
            {
                int i = 0;
                string idCut = item.Split(';')[i];
                Console.WriteLine(idCut);
                i++;
            }

            //Do-while køre altid en gang, og forsætter til choice != 0 er opflydt. Så når brugeren skrive 0
            do
            {                
                //Brugeren laver et valg i consolen, catch fanger forkerte indtastninger. eks et bogstav.
                string userInput = Console.ReadLine();
                try
                {
                    choice = Int32.Parse(userInput);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }

                //Call(choice);

            } while (choice != 0);
        }


        /*
        internal static void Call(int userInput)
        {

            switch (userInput)
            {
                case 1:
                    Console.WriteLine(Functions.DoThis());
                    break;
                case 2:
                    Console.WriteLine(Functions.DoThat());
                    break;
                case 3:
                    Console.WriteLine("Skriv Noget" + "\n" + "Write Something");
                    Console.WriteLine(Functions.DoSomething(Console.ReadLine()));
                    break;
                case 4:
                    Console.WriteLine(Functions.GetTheAnswerToLifeTheUniverseAndEverything());
                    break;
                case 0:
                    Console.WriteLine("Exit");
                    break;
            }
            if (userInput > 4)
            {
                Console.WriteLine("Forkert Valg" + "\n" + "Unknown Selection");
            }
            
        }
        */
    }
}
