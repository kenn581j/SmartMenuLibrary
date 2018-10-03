using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMenuLibrary
{
    public class SmartMenuLibrary
    {
        public class SmartMenu

        {
            List<string> menuLines = new List<string>();
            public void LoadMenu(string path)
            {
                int counter = 0;
                string line;
                string menuSpecPath = @"..\..\MenuSpec.txt";
                bool menuPathSet = true;

                /*
                Console.WriteLine("Vælg Sprog");
                Console.WriteLine("Choose Language");
                Console.WriteLine("1. For Dansk" + "\n" + "2. For English");
                int langChoice = 0;
                string menuLang = Console.ReadLine();

                try
                {
                    langChoice = Int32.Parse(menuLang);
                }

                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.Clear();

                if (langChoice == 1)
                {
                    menuSpecPath = @"..\..\MenuSpec.txt";
                    menuPathSet = true;
                }
                else if (langChoice == 2)
                {
                    menuSpecPath = @"..\..\MenuSpecEng.txt";
                    menuPathSet = true;
                }
                else
                {
                    Console.WriteLine("Ikke en mulighed" + "\n" + "Not an Option" + "\n" + "0 to Exit");
                }
                */

                if (menuPathSet == true)
                {
                    System.IO.StreamReader file =
                        new System.IO.StreamReader(menuSpecPath);

                    while ((line = file.ReadLine()) != null)
                    {
                        menuLines.Add(line);
                        counter++;
                    }
                    file.Close();
                }

            }

            public void Activate()
            {
                foreach (var item in menuLines)
                {
                    int i = 0;
                    string idCut = item.Split(';')[i];
                    Console.WriteLine(idCut);
                    i++;
                }

                int choice = 0;

                do
                {
                    string userInput = Console.ReadLine();
                    try
                    {
                        choice = Int32.Parse(userInput);
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    Call(choice);

                } while (choice != 0);
            }

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

        }
    }
