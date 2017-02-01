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
    public partial class FormEventAdd : Form
    {
        public FormEventAdd()
        {
            InitializeComponent();
        }
        PlanTask newTask = new PlanTask();

        private void FormEventAdd_Load(object sender, EventArgs e)
        {

        }

        private void EventTextBox_TextChanged(object sender, EventArgs e)
        {
            newTask.TaskName = EventTextBox.Text;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            newTask.TaskData =Convert.ToDateTime(dateTimePicker1.Value);
        }

        private void SaveEventText_Click(object sender, EventArgs e)
        {
            using (PlannerContext dbContext = new PlannerContext())
            {
                dbContext.PlanListData.Add(newTask);
                dbContext.SaveChanges();
                MessageBox.Show("Ваше событие добавлено!");
                Thread.Sleep(500);
                Close();  
            }
        }


    }
}

