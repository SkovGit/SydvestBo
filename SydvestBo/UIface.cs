using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Configuration;


namespace SydvestBo
{
    

    public class UIface
    {
		public static ConsoleKeyInfo Tast; //Lader mig bruge ConsoleKeys 

        static bool Loopkat = true; //  ************| Er vi inde i Menuen?
        static int KatTæller; // ************| Hvilken Menu kigger vi på: udlejer, feriebolig, kontrakt
        public int UnderKat; // ************| Under kategori: opret, vis, slet, opdater
        static int Menu; // ************| Current Menu
        static int UnderKatYpos = 2;

        public List<string> Kategorier = new List<string> {"Udlejer", "Feriebolig", "Kontrakt", "DB Connection" };
        public List<string> UnderKats  = new List<string> { "Opret", "Vis", "Slet", "Opdater" };

       

        public void KørMenu()
        {

            UIudlejer uIudlejer = new UIudlejer();
            UIferiebolig uIferiebolig = new UIferiebolig();
            UIkontrakt uIkontrakt = new UIkontrakt();

            int testint = 0;
            
            KatTæller = Kategorier.IndexOf(Kategorier.First<string>()); // ************| Hvilken Menu kigger vi på: udlejer, feriebolig, kontrakt
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
                        if (KatTæller > Kategorier.IndexOf(Kategorier.First<string>()))
                            KatTæller--;
                        break;
                    case ConsoleKey.RightArrow:
                        if (KatTæller < Kategorier.IndexOf(Kategorier.Last<string>()))
                            KatTæller++;
						
						break;

                    // ************| Trykker Enter  oksds
                    case ConsoleKey.Enter:
                        if (testint == 0)
                            uIudlejer.PlayTask();
                        if (testint == 1)
                            uIferiebolig.PlayTask();
                        if (testint == 2)
                            uIkontrakt.PlayTask();
						if (testint == 3)
						{
							Console.SetCursorPosition(default, UnderKatYpos + UnderKats.IndexOf(UnderKats.Last<string>())+2);
                            SqlAccess.ConnectionOK();
                            	
						}
                        break;
                }
                int musPosition = Console.CursorTop;
                Console.SetCursorPosition(default, UnderKats.IndexOf(UnderKats.First<string>()) + UnderKatYpos);

                List<int> getUKatsPos = new List<int>();

                for (int i = UnderKats.IndexOf(UnderKats.First<string>()); i <= UnderKats.IndexOf(UnderKats.Last<string>()); i++)
                {
                    getUKatsPos.Add(i);
                    if (i == UnderKat)
                    {

                        uIudlejer.GetUnderKat = i;
                        uIferiebolig.GetUnderKat = i;
                        uIkontrakt.GetUnderKat = i;
                        
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
				
						Console.WriteLine($"{UnderKats[i]}\t:");
					Console.ResetColor();
                }

                
                Console.SetCursorPosition(Kategorier.IndexOf(Kategorier.First<string>()), default);

                List<int> getKatsPos = new List<int>();

                for (int i = Kategorier.IndexOf(Kategorier.First<string>()); i <= Kategorier.IndexOf(Kategorier.Last<string>()); i++)
                {
                    getKatsPos.Add(i);
                    if (i == Kategorier.IndexOf(Kategorier.First<string>()))
                        Console.Write("\t    ");
                    if (i == KatTæller)
                    {
                        testint = i;
                        
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
					int x = Console.CursorLeft;
					int y = Console.CursorTop;

					if (i < Kategorier.IndexOf(Kategorier.Last<string>()))
					{
						Console.Write($"{Kategorier[i]}");
						Console.ResetColor();
						Console.Write("    ");
					}
					else
					{
						Console.WriteLine($"{Kategorier[i]}");
						Console.ResetColor();
					}                    
                }
                uIudlejer.GetOverKat = testint;
                uIkontrakt.GetOverKat = testint;
                uIferiebolig.GetOverKat = testint;

                Console.SetCursorPosition(default, getUKatsPos[UnderKat] + UnderKatYpos);
                Tast = Console.ReadKey(true); 
            }
            
        }
    }   
}