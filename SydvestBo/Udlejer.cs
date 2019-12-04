using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace SydvestBo
{
    public class Udlejer
    {
<<<<<<< HEAD
        
=======
        UIface uiface = new UIface();

        public int GetUnderKat { get; set; }
        public int GetOverKat { get; set; }
        public Udlejer()
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
        List<string> opret = new List<string> { "Navn       :", "Cpr        :", "Postnummer :", "Email      :", "Telefon    :" };
        List<string> gemOpretInput = new List<string>();

        public void Opret()
        {
            Console.WriteLine($"{uiface.UnderKats[GetUnderKat]} {uiface.Kategorier[GetOverKat]}");
            Console.WriteLine();

            List<int> gemOpretTop = new List<int>();
            List<int> gemOpretBredde = new List<int>();
            for (int i = opret.IndexOf(opret.First<string>()); i <= opret.IndexOf(opret.Last<string>()); i++)
            {
                Console.Write(opret[i]);
                gemOpretTop.Add(Console.CursorTop +1);
                gemOpretBredde.Add(Console.CursorLeft +2);
                
                Console.WriteLine();
                


            }
            for (int i = opret.IndexOf(opret.First<string>()); i <= opret.IndexOf(opret.Last<string>()); i++)
            {
                Console.SetCursorPosition(gemOpretBredde[i], gemOpretTop[i]);
                gemOpretInput.Add(Console.ReadLine());

            }
            Console.ReadKey();
        }



        public void Vis()
        {
            Console.WriteLine($"{uiface.UnderKats[GetUnderKat]} {uiface.Kategorier[GetOverKat]}");
            Console.WriteLine();
            
            for (int i = opret.IndexOf(opret.First<string>()); i <= opret.IndexOf(opret.Last<string>()); i++)
            {
                Console.Write(opret[i]);
                Console.WriteLine(gemOpretInput[i]);
            }
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
>>>>>>> parent of aa3f1e1... For loop i Vis() ændret til foreach
    }
}