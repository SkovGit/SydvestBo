using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SydvestBo
{

    public abstract class UIActionHandler
    {
        public abstract void PlayTask();
        public abstract void Opret();
        public abstract void Vis();
        public abstract void Slet();
        public abstract void Opdater();
    }

    public class UIudlejer : UIActionHandler
    {
        UIface uiface = new UIface();

        public int GetUnderKat { get; set; }
        public int GetOverKat { get; set; }

        List<string> opret = new List<string> { "Navn       :", "Cpr        :", "Postnummer :", "Email      :", "Telefon    :" };
        List<string> gemOpretInput = new List<string>();

        public override void PlayTask()
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
        public override void Opret()
        {
            var udlejer = new Udlejer();
            udlejer.opretUdlejer();
            Console.ReadKey();
        }
        public override void Vis()
        {
            Console.WriteLine($"{uiface.UnderKats[GetUnderKat]} {uiface.Kategorier[GetOverKat]}");
            Console.WriteLine();
            List<int> gemOpretTop = new List<int>();
            List<int> gemOpretBredde = new List<int>();
            for (int i = opret.IndexOf(opret.First<string>()); i <= opret.IndexOf(opret.Last<string>()); i++)
            {

                Console.Write(opret[i]);
                gemOpretTop.Add((Console.CursorTop + 1));
                gemOpretBredde.Add((Console.CursorLeft + 3));
                Console.WriteLine();

            }
            for (int i = opret.IndexOf(opret.First<string>()); i <= opret.IndexOf(opret.Last<string>()); i++)
            {
                Console.SetCursorPosition(gemOpretBredde[i], gemOpretTop[i]);
                Console.WriteLine(gemOpretInput[i]);


                //Det her foreach loop udskriver alle elementer i listen og ikke kun de første 5
                foreach (var item in gemOpretInput)
                {
                    i = gemOpretInput.IndexOf(item) % opret.IndexOf(opret.Last<string>() + 1);
                    Console.Write(opret[i]);
                    Console.WriteLine(item);

                }


                //for (int i = opret.IndexOf(gemOpretInput.First<string>()); i <= gemOpretInput.IndexOf(gemOpretInput.Last<string>()); i++)
                //{
                //    Console.Write(opret[i]);
                //    Console.WriteLine(gemOpretInput[i]);
                //}
                Console.ReadKey();
            }
        }
        public override void Slet()
        {
            Console.WriteLine($"{uiface.UnderKats[GetUnderKat]} {uiface.Kategorier[GetOverKat]}");
            Console.WriteLine();

            Console.ReadKey();
        }
        public override void Opdater()
        {
            Console.WriteLine($"{uiface.UnderKats[GetUnderKat]} {uiface.Kategorier[GetOverKat]}");
            Console.WriteLine();

            Console.ReadKey();
        }
    }

    public class UIferiebolig : UIActionHandler
    {
        UIface uiface = new UIface();

        public int GetUnderKat { get; set; }
        public int GetOverKat { get; set; }
        
        public override void PlayTask()
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
        public override void Opret()
        {
            Console.WriteLine($"{uiface.UnderKats[GetUnderKat]} {uiface.Kategorier[GetOverKat]}");
            Console.WriteLine();

            Console.ReadKey();
        }
        public override void Vis()
        {
            Console.WriteLine($"{uiface.UnderKats[GetUnderKat]} {uiface.Kategorier[GetOverKat]}");
            Console.WriteLine();

            Console.ReadKey();
        }
        public override void Slet()
        {
            Console.WriteLine($"{uiface.UnderKats[GetUnderKat]} {uiface.Kategorier[GetOverKat]}");
            Console.WriteLine();

            Console.ReadKey();
        }
        public override void Opdater()
        {
            Console.WriteLine($"{uiface.UnderKats[GetUnderKat]} {uiface.Kategorier[GetOverKat]}");
            Console.WriteLine();

            Console.ReadKey();
        }
    }

    public class UIkontrakt : UIActionHandler
    {
        UIface uiface = new UIface();

        public int GetUnderKat { get; set; }
        public int GetOverKat { get; set; }
        
        public override void PlayTask()
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
        public override void Opret()
        {
            Console.WriteLine($"{uiface.UnderKats[GetUnderKat]} {uiface.Kategorier[GetOverKat]}");
            Console.WriteLine();

            Console.ReadKey();
        }
        public override void Vis()
        {
            Console.WriteLine($"{uiface.UnderKats[GetUnderKat]} {uiface.Kategorier[GetOverKat]}");
            Console.WriteLine();

            Console.ReadKey();
        }
        public override void Slet()
        {
            Console.WriteLine($"{uiface.UnderKats[GetUnderKat]} {uiface.Kategorier[GetOverKat]}");
            Console.WriteLine();

            Console.ReadKey();
        }
        public override void Opdater()
        {
            Console.WriteLine($"{uiface.UnderKats[GetUnderKat]} {uiface.Kategorier[GetOverKat]}");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
