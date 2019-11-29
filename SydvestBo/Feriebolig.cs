using System;
using System.Reflection;

namespace SydvestBo
{
    // Klasse til at manipulere data fra Ferieboligtabellen i databasen
    public class Feriebolig
    {
        UIface uiface = new UIface();

        public int GetUnderKat { get; set; }
        public int GetOverKat { get; set; }
        public Feriebolig()
        {
        }
        public void PlayTask()
        {
            string methodName = $"{uiface.UnderKats[GetUnderKat]}";

            Type thisType = this.GetType();
            MethodInfo myMethod = thisType.GetMethod(methodName);

            try
            {

                myMethod.Invoke(this, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadKey();
            }

            Console.Clear();

        }
        // ****************************** | Underkategori Metoder
        public void Opret()
        {
            Console.WriteLine($"{uiface.UnderKats[GetUnderKat]} {uiface.Kategorier[GetOverKat]}");
            Console.WriteLine();

            Console.ReadKey();
        }
        public void Vis()
        {
            Console.WriteLine($"{uiface.UnderKats[GetUnderKat]} {uiface.Kategorier[GetOverKat]}");
            Console.WriteLine();

            Console.ReadKey();
        }
        public void Slet()
        {
            Console.WriteLine($"{uiface.UnderKats[GetUnderKat]} {uiface.Kategorier[GetOverKat]}");
            Console.WriteLine();

            Console.ReadKey();
        }
        public void Opdater()
        {
            Console.WriteLine($"{uiface.UnderKats[GetUnderKat]} {uiface.Kategorier[GetOverKat]}");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}