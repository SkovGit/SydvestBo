using System;
using System.Reflection;
using System.Text.RegularExpressions;


namespace SydvestBo.Uifolder
{
    public class AddUser
    {

        public void PlayTask()
        {
            // String til funktionsnavn
            string methodName = $"opgave{ MenuClass.counter }_{  MenuClass.taskCount }";

            //Man skal bruge en variabel af typen 'Type', for at bruge 'GetMethod' funktionen
            Type thisType = this.GetType();

            //Opretter en metodeinfo 'MethodInfo' og kalder min kalder min metode som matcher stringnavn 'methodName'
            MethodInfo myMethod = thisType.GetMethod(methodName);

            while (MenuClass.LoopTask == true)
            {
                //Her invoker jeg jeg (namespace.ClassName, metodeparametre)
                myMethod.Invoke(this, null);
                Console.Clear();
            }
        }
        void StayAtLine()
        {
            int thisLine = Console.CursorTop - 1;
            Console.SetCursorPosition(0, thisLine);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, thisLine);
        }
        void TaskIntro()
        {
            Console.WriteLine($"Velkommen til opgave { MenuClass.counter }.{ MenuClass.taskCount }");
            Console.WriteLine();
        }
        void TaskOutro()
        {
            Console.WriteLine();
            Console.WriteLine($@"Opgave { MenuClass.counter }.{ MenuClass.taskCount } slut
Tryk Escape for at gå tilbage
Tryk på en tilfældig tast for at køre opgaven igen");//slut
            MenuClass.tast = Console.ReadKey(true);
            if (MenuClass.tast.Key == ConsoleKey.Escape)
                MenuClass.LoopTask = false;
        }

        public void opgave1_1()
        {
            bool prøvIgen = true;
            TaskIntro();
            Console.WriteLine("\nSkriv et Binært tal");
            string binær;
            for (; ; )
            {
                binær = Console.ReadLine();
                if (Regex.IsMatch(binær, "^[0-1]+$"))
                {
                    break;
                }
                StayAtLine();
                if (prøvIgen == true)
                {
                    Console.WriteLine("Prøv igen");
                    prøvIgen = false;
                }
            }
            prøvIgen = true;
            string hej = Convert.ToInt64(binær, 2).ToString();
            Console.WriteLine($"{binær} = {hej}");
            Console.WriteLine("\nSkrev et Hexa tal");
            string hexa;
            for (; ; )
            {
                hexa = Console.ReadLine();
                if (Regex.IsMatch(hexa, @"^[0-9,a-f,A-F]+$"))
                    break;

                int thisLine = Console.CursorTop - 1;
                Console.SetCursorPosition(0, thisLine);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, thisLine);
                if (prøvIgen == true)
                {
                    Console.WriteLine("Prøv igen");
                    prøvIgen = false;
                }
            }
            string hejs = Convert.ToInt64(hexa, 16).ToString();
            Console.WriteLine(hejs);

            TaskOutro();
        }
        public void opgave1_2()
        {
            TaskIntro();
            Console.WriteLine("Indtast dit fulde navn");
            string navn;
            do
            {
                navn = Console.ReadLine();
                StayAtLine();
            } while (navn == "");

            navn = navn.ToLower();
            string[] plit = navn.Split(' ');
            string fuldenavn = "";

            foreach (var c in plit)
            {
                string startbogstav = c.Substring(0, 1).ToUpper();
                string ord = startbogstav + c.Substring(1);
                fuldenavn = fuldenavn + ord + " ";

            }
            plit = fuldenavn.Split('-');


            string fuldenavn2 = "";
            foreach (var c in plit)
            {
                string startbogstav = c.Substring(0, 1).ToUpper();
                string ord = startbogstav + c.Substring(1);
                fuldenavn2 = fuldenavn2 + ord + "-";
            }

            int _trim = fuldenavn2.Length - 1;
            string fixFuldeNavn = fuldenavn2.Substring(0, _trim);

            Console.WriteLine();
            Console.WriteLine($@"Dit fulde navn er:
{fixFuldeNavn}");
            TaskOutro();
        }
        public void opgave1_3()
        {
            TaskIntro();

            TaskOutro();
        }

        public void opgave2_1()
        {
            TaskIntro();

            TaskOutro();
        }
        public void opgave2_2()
        {
            TaskIntro();

            TaskOutro();
        }
        public void opgave2_3()
        {
            TaskIntro();

            TaskOutro();
        }

        public void opgave3_1()
        {
            TaskIntro();

            TaskOutro();
        }
        public void opgave3_2()
        {
            TaskIntro();

            TaskOutro();
        }
        public void opgave3_3()
        {
            TaskIntro();

            TaskOutro();
        }
    }

}