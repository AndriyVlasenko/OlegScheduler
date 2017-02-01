using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PlannerFormBL.DataModel
{
    [Serializable]
    public  class PlanTask
    {
       
            public int PlanTaskID { get; set; }

            [MaxLength(1000)]
            [Required]
            public string TaskName { get; set; }

            [Required]
            public DateTime TaskData { get; set; }

        
    }
}
