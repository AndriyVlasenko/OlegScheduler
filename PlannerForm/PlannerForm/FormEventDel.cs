using PlannerFormBL.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlannerForm
{
    public partial class FormEventDel : Form
    {
        public FormEventDel()
        {
            InitializeComponent();
        }

        private void FormEventDel_Load(object sender, EventArgs e)
        {

        }
        private void ContextListDelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void SaveChangesDelBut_Click(object sender, EventArgs e)
        {
            using (PlannerContext dbContext = new PlannerContext())
            {
                PlanTask plan = new PlanTask();
                plan.PlanTaskID = (int)numericUpDown1.Value;
                dbContext.PlanListData.Attach(plan);
                dbContext.PlanListData.Remove(plan);
                dbContext.SaveChanges();
                MessageBox.Show("Событие успешно удалено!");
                Thread.Sleep(500);
                Close();
            }
        }
        private void EventListBut_Click(object sender, EventArgs e)
        {
            using (PlannerContext dbContext = new PlannerContext())
            {
                List<PlanTask> allTasks = dbContext.PlanListData.ToList();
                foreach (PlanTask el in allTasks)
                {
                    ContextListDelBox.Items.AddRange(new object[] { el.PlanTaskID, el.TaskName, el.TaskData });
                }
                }
            }
        }
    }
