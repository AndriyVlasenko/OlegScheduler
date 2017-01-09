using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePlanner
{
    [Serializable]
    public class PlanTask
    {
        public string TaskName { get; set; }
        public DateTime TaskData { get; set; }
    }
}
