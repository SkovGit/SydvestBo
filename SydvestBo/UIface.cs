using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SydvestBo
{
    public class Kategori
    {
        public static ConsoleKeyInfo Tast; //Lader mig bruge ConsoleKeys 

        static bool Loopkat = true; //  ************| Er vi inde i Menuen?
        static int KatTæller; // ************| Hvilken Menu kigger vi på: udlejer, feriebolig, kontrakt
        static int UnderKat; // ************| Under kategori: opret, vis, slet, opdater
        static int Menu; // ************| Current Menu
        static int UnderKatYpos = 1;

        List<string> Kategorier = new List<string> {"Udlejer", "Feriebolig", "Kontrakt" };
        List<string> UnderKats  = new List<string> { "Opret", "Vis", "Slet", "Opdater" };

       
        public void KørMenu()
        {
            
            KatTæller = Kategorier.IndexOf(Kategorier.First<string>());
            UnderKat = UnderKats.IndexOf(UnderKats.First<string>());


            while (Loopkat == true)
            {
                Console.Clear();
                switch (Tast.Key)
                {
                    // ************| Skift mellem Opret, Vis, Slet, Opdater
                    case ConsoleKey.UpArrow:
                        if (UnderKat > UnderKats.IndexOf(UnderKats.First<string>()))
                            UnderKat--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (UnderKat < UnderKats.IndexOf(UnderKats.Last<string>()))
                            UnderKat++;
                        break;


                    // ************| Skift mellem Udlejer, Feriebolig, Kontrakt
                    case ConsoleKey.LeftArrow:
                        if(KatTæller > Kategorier.IndexOf(Kategorier.First<string>()))
                            KatTæller--;
                        break;
                    case ConsoleKey.RightArrow:
                        if (KatTæller < Kategorier.IndexOf(Kategorier.Last<string>()))
                            KatTæller++;
                        break;

                    // ************| Trykker Enter
                    case ConsoleKey.Enter:
                        PlayTask();
                        break;
                }
                int musPosition = Console.CursorTop;
                Console.SetCursorPosition(default, UnderKats.IndexOf(UnderKats.First<string>()) + UnderKatYpos);

                List<int> getUKatsPos = new List<int>();

                for (int i = UnderKats.IndexOf(UnderKats.First<string>()); i <= UnderKats.IndexOf(UnderKats.Last<string>()); i++)
                {
                    getUKatsPos.Add(i);
                    if (i == UnderKat)
                        Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{UnderKats[i]}\t:");
                    Console.ResetColor();
                }

                Console.SetCursorPosition(default, getUKatsPos[UnderKat] + UnderKatYpos);
                Tast = Console.ReadKey(true);

            }
        }




        public void PlayTask()
        {
            string methodName = $"{UnderKats[UnderKat]}";

            Type thisType = this.GetType();
            MethodInfo myMethod = thisType.GetMethod(methodName);

            
            myMethod.Invoke(this, null);
            Console.Clear();

        }

        
        
            // ****************************** | Underkategori Metoder
        public void Opret()
        {
            Console.WriteLine("Opret");
            Console.ReadKey();
        }
        public void Vis()
        {
            Console.WriteLine("Vis");
            Console.ReadKey();
        }
        public void Slet()
        {
            Console.WriteLine("Slet");
            Console.ReadKey();
        }
        public void Opdater()
        {
            Console.WriteLine("Opdater");
            Console.ReadKey();
        }

    }
    
}
