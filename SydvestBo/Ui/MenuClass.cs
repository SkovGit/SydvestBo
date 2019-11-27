using System;
using Aflevering_44;


namespace Aflevering_44
{
    public class MenuClass
    {
        public static ConsoleKeyInfo tast;
        public static bool LoopTask = true;
        public static int menu;
        static int counter;
        public static int taskCount;

        public void RunMenu()
        {
            TaskClass taskclass = new TaskClass();
            bool tastSkift = true;
            menu = 1;
            
            while (tastSkift == true)
            {
                if (menu > 3) menu = 3;
                if (menu < 1) menu = 1;
                if (menu == 1)
                Console.Clear();
                MenuText();
                Console.WriteLine();
                Console.WriteLine();
                RunOpg();
                tast = Console.ReadKey(true);
                Console.Clear();
                switch (tast.Key)
                {
                    case ConsoleKey.RightArrow:
                        MenuArrrowRight();
                        break;
                    case ConsoleKey.LeftArrow:
                        MenuArrowLeft();
                        break;
                    default:
                        continue;
                    case ConsoleKey.DownArrow:
                        MenuArrowDown();
                        break;
                    case ConsoleKey.UpArrow:
                        MenuArrowUp();
                        break;
                    case ConsoleKey.Enter:
                        LoopTask = true;
                        taskclass.PlayTask();
                        break;
                }

                
            }
        }
        public void RunOpg()
        {

            if (counter == 0) taskCount = 1;
            counter++;
            if (MenuClass.menu == 1) Menu1();
            else if (MenuClass.menu == 2) Menu2();
            else if (MenuClass.menu == 3) Menu3();

            Console.WriteLine();

        }
        static void Menu1()
        {
            if (taskCount == 1)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write($"Opgave {MenuClass.menu}.1\t"); Console.BackgroundColor = ConsoleColor.Green; Console.WriteLine(" ");
                Console.ResetColor();
                Console.WriteLine($"Opgave {MenuClass.menu}.2\t");
                Console.WriteLine($"Opgave {MenuClass.menu}.3\t");
            }
            if (taskCount == 2)
            {

                Console.WriteLine($"Opgave {MenuClass.menu}.1\t");
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write($"Opgave {MenuClass.menu}.2\t"); Console.BackgroundColor = ConsoleColor.Green; Console.WriteLine(" ");
                Console.ResetColor();
                Console.WriteLine($"Opgave {MenuClass.menu}.3\t");
            }
            if (taskCount == 3)
            {
                Console.WriteLine($"Opgave {MenuClass.menu}.1\t");
                Console.WriteLine($"Opgave {MenuClass.menu}.2\t");
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.WriteLine($"Opgave {MenuClass.menu}.3\t");
                Console.ResetColor();
            }
        }
        static void Menu2()
        {
            if (taskCount == 1)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.WriteLine($"Opgave {MenuClass.menu}.1\t");
                Console.ResetColor();
                Console.WriteLine($"Opgave {MenuClass.menu}.2\t");
                Console.WriteLine($"Opgave {MenuClass.menu}.3\t");
            }
            if (taskCount == 2)
            {

                Console.WriteLine($"Opgave {MenuClass.menu}.1\t");
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.WriteLine($"Opgave {MenuClass.menu}.2\t");
                Console.ResetColor();
                Console.WriteLine($"Opgave {MenuClass.menu}.3\t");
            }
            if (taskCount == 3)
            {
                Console.WriteLine($"Opgave {MenuClass.menu}.1\t");
                Console.WriteLine($"Opgave {MenuClass.menu}.2\t");
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.WriteLine($"Opgave {MenuClass.menu}.3\t");
                Console.ResetColor();
            }
        }
        static void Menu3()
        {
            if (taskCount == 1)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.WriteLine($"Opgave {MenuClass.menu}.1\t");
                Console.ResetColor();
                Console.WriteLine($"Opgave {MenuClass.menu}.2\t");
                Console.WriteLine($"Opgave {MenuClass.menu}.3\t");
            }
            if (taskCount == 2)
            {

                Console.WriteLine($"Opgave {MenuClass.menu}.1\t");
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.WriteLine($"Opgave {MenuClass.menu}.2\t");
                Console.ResetColor();
                Console.WriteLine($"Opgave {MenuClass.menu}.3\t");
            }
            if (taskCount == 3)
            {
                Console.WriteLine($"Opgave {MenuClass.menu}.1\t");
                Console.WriteLine($"Opgave {MenuClass.menu}.2\t");
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.WriteLine($"Opgave {MenuClass.menu}.3\t");
                Console.ResetColor();
            }
        }
        public void MenuArrowDown()
        {
            if (taskCount != 3)
                taskCount++;
        }
        public void MenuArrowUp()
        {
            if (taskCount != 1)
                taskCount--;
        }  
        static void MenuArrrowRight()
        {
            menu++;
        }
        static void MenuArrowLeft()
        {
            menu--;
        }
        static void MenuText()
        {
            if (menu == 1)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("Opgave 1\t");
                Console.ResetColor();
                Console.Write("Opgave 2\t");
                Console.Write("Opgave 3\t");
            }
            if (menu == 2)
            {

                Console.Write("Opgave 1\t");
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("Opgave 2\t");
                Console.ResetColor();
                Console.Write("Opgave 3\t");
            }
            if (menu == 3)
            {
                Console.Write("Opgave 1\t");
                Console.Write("Opgave 2\t");
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("Opgave 3\t");
                Console.ResetColor();
            }
        }
    }
}
