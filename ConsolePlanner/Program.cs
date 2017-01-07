using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsolePlanner
{
    class Program
    {
        static void Main()
        {



            PlannerBL newevent = new PlannerBL();

    Console.WriteLine(" Меню:\n Показать события: 1 \n Добавить событие: 2\n Удалить событие:  3\n Для выхода: 4\n");





            int a = Convert.ToInt32(Console.ReadLine());
            
                if (a == 1)
                {
                    newevent.ShowPlans();
                }
                else if (a == 2)
                {
                    newevent.AddEvent();
                }
                else if (a == 3)
                {
                    newevent.DeletEvent();
                }
                else if (a == 4)
                {
                    Console.WriteLine("Досвидания!");
                    Console.ReadLine();
                    
            }
              
                else Console.WriteLine("Следуйте Указаниям Меню!");
                Console.ReadLine();
                Console.Clear();
                Main();

            Console.ReadKey();

             
        
    }
    }
}
