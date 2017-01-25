using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePlanner
{
    [Serializable]
    public class PlanTask
    {
       
        public int PlanTaskID { get; set; }

        [MaxLength(1000)]
        [Required]
        public string TaskName { get; set; }

        [Required]
        public DateTime TaskData { get; set; }

    }
}
