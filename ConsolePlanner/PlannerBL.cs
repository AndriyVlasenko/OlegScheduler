using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsolePlanner
{
    public interface IPlannerBl
    {
        void AddEvent();
        void DeletEvent();
        void ShowPlans();
        
    }
   class PlannerBL : IPlannerBl
    {
        
        private string Days { get; set; }

        List<string> days = new List<string> { "ПН:", "ВТ:", "СР:", "ЧТ:", "ПТ:", "СБ:", "ВС:" };

        public PlannerBL()
        {
            
        }
        public void AddEvent()
        {
                Console.WriteLine("Введите день события!(ПН,ВТ,СР,ЧТ,ПТ,СБ,ВС)\n  Для выхода в главное меню нажмите - E\n");

                string d = Console.ReadLine();
            switch (d)
            {
                case "ПН":
                    Console.WriteLine("Введите текст события.");
                    string p = Console.ReadLine();
                    days.RemoveAt(0);
                    days.Insert(0, p); 
                    break;
                case "ВТ":
                    Console.WriteLine("Введите текст события");
                    string v = Console.ReadLine();
                    days.RemoveAt(1);
                    days.Insert(1, v);
                    break;
                case "СР":
                    Console.WriteLine("Введите текст события");
                    string cp = Console.ReadLine();
                    days.RemoveAt(2);
                    days.Insert(2, cp);
                    break;
                case "ЧТ":
                    Console.WriteLine("Введите текст события");
                    string ch = Console.ReadLine();
                    days.RemoveAt(3);
                    days.Insert(3, ch);
                    break;
                case "ПТ":
                    Console.WriteLine("Введите текст события");
                    string pt = Console.ReadLine();
                    days.RemoveAt(4);
                    days.Insert(4, pt);
                    break;
                case "СБ":
                    Console.WriteLine("Введите текст события");
                    string s = Console.ReadLine();
                    days.RemoveAt(5);
                    days.Insert(5, s);
                    break;
                case "ВС":
                    Console.WriteLine("Введите текст события");
                    string vs = Console.ReadLine();
                    days.RemoveAt(6);
                    days.Insert(6, vs);
                    break;
                case "E":
                    break;
                }
            
            Console.Clear();
            

        }
        public void DeletEvent()
        {
            Console.WriteLine("Введите день события,которое нужно удалить!(ПН,ВТ,СР,ЧТ,ПТ,СБ,ВС)\nДля выхода в главное меню нажмите - E\n");
            string d = Console.ReadLine();
            switch (d)
            {
                case "ПН":
                    days.RemoveAt(0);
                    break;
                case "ВТ":
                    days.RemoveAt(1);
                    break;
                case "СР":
                    days.RemoveAt(2);
                    break;
                case "ЧТ":
                    days.RemoveAt(3);
                    break;
                case "ПТ":
                    days.RemoveAt(4);
                    break;
                case "СБ":
                    days.RemoveAt(5);
                    break;
                case "ВС":
                    days.RemoveAt(6);
                    break;
                case "E":
                    break;          
            }
            
        }
        public void ShowPlans()
        {
            FileStream file = new FileStream("C:/Users/oleg/Documents/Visual Studio 2015/Projects/ FilePlanner.txt", FileMode.OpenOrCreate);
            StreamWriter writer = new StreamWriter(file);
            foreach (string el in days)
            {
                writer.WriteLine(el);
                Console.WriteLine(el);
            }
            writer.Close();
           
        }
    }
}
