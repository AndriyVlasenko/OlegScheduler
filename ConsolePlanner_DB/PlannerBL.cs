using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ConsolePlanner.DataModel;

namespace ConsolePlanner
{

    public interface IPlannerBl
    {
        void AddEvent(PlanTask plan);
        void DeletEvent(PlanTask plan);
        List<PlanTask> GetPlans();
        void SavePlans();
    }
    class PlannerBL : IPlannerBl
    {

        private List<PlanTask> PlanList { get; set; }

        private const string PATH = "C:/Users/oleg/Documents/Visual Studio 2015/Projects/ FilePlanner.txt";

        public PlannerBL()
        {
            PlanList = new List<PlanTask>();
            PlanTask plan = new PlanTask();
            plan.TaskName = "Today is";
            plan.TaskData = DateTime.Now;
            // PlanList.Add(plan);
            // SavePlans();                      
        }

        public void AddEvent(PlanTask plan)
        {
            try
            {
                Console.WriteLine("Write plan!(format: № - text.)");
                plan.TaskName = Console.ReadLine();
                Console.WriteLine("Write date!(format: yyyy-mm-dd  hh:mm:ss)");
                plan.TaskData = Convert.ToDateTime(Console.ReadLine());
                // Альтернативный вариан кода для добавления даты.
                /* string dateString = Console.ReadLine();
                 DateTime dateValue;
                 if (DateTime.TryParse(dateString, out dateValue))
                 {
                     plan.TaskData = dateValue;
                 } 
                 */
                PlanList.Add(plan);
                SavePlans();
            }
            catch (FormatException)
            {
                Console.WriteLine("Follow Menu Format!");
            }
        }
        public void DeletEvent(PlanTask plan)
        {
            try
            {
                var plans = MySaver.ReadFromJsonFile<List<PlanTask>>(PATH);

                foreach (var el in plans)
                {
                    Console.WriteLine("Task: {0}, Data: {1}", el.TaskName, el.TaskData);
                    Console.WriteLine();
                }
                Console.WriteLine("Write Number of Task you want remove!");
                int num= Convert.ToInt32(Console.ReadLine());
                PlanList.RemoveAt(num-1);
                //Вариант удаления из БД.
                /*
                plan.PlanTaskID= Convert.ToInt32(Console.ReadLine());
                PlanList.RemoveAt(plan.PlanTaskID-1);
                */
                SavePlans();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Not correct number of Task!");
            }
        }
        public List<PlanTask> GetPlans()
        {
            PlanList = MySaver.ReadFromJsonFile<List<PlanTask>>(PATH);
            return PlanList;
        }

        public void SavePlans()
        {
            MySaver.WriteToJsonFile(PATH, PlanList);
        }
    }
}
