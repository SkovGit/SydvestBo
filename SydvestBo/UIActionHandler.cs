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

        public Udlejer udlejer = new Udlejer();

        public override void Opret()
        {
            udlejer.opretUdlejer();
            Console.ReadKey();
        }

        public override void Vis()
        {

            udlejer.visUdlejer();
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
