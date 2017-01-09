﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace ConsolePlanner
{
    class Program
    {
        static void Main()
        {

            Planner = new PlannerBL();
           
            Menu();
       }
        private static PlannerBL Planner { get; set; }


        private static void Menu()
        {
            Console.WriteLine(" MENU:\n   Show Tasks: 1 \n   Add Task: 2\n   Delet Task:  3\n   Exit: 4\n");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a == 1)
            {
                var plans= Planner.GetPlans();
               
                    foreach (var plan in plans)
                    {
                        Console.WriteLine("Task: {0}, Data: {1}", plan.TaskName, plan.TaskData);
                        Console.WriteLine();
                    }
                Menu();
            }
            else if (a == 2)
            {
                var plans =new PlanTask();
                Planner.AddEvent(plans);

                Menu();
            }
            else if (a == 3)
            {
                var plans = new PlanTask();
                Planner.DeletEvent(plans);
                Menu();
            }
            else if (a == 4)
            {
                Console.WriteLine("Goodbye!");
                Thread.Sleep(3000);
            }

            else

            {
                Console.WriteLine("Follow Menu instructions!");
                Menu();
            }
        }
    }
}
