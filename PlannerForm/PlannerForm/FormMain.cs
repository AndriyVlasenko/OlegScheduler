using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlannerFormBL;
using PlannerFormBL.DataModel;

namespace PlannerForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowWinAddBut_Click(object sender, EventArgs e)
        {
            FormEventAdd dialog = new FormEventAdd();

            dialog.ShowDialog();
        }
        private void ShowWinDelBut_Click(object sender, EventArgs e)
        {
            FormEventDel dialog = new FormEventDel();

            dialog.ShowDialog();
        }

        private void ExitBut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void GetEventBut_Click(object sender, EventArgs e)
        {
            ContextListBox.Items.Clear();
            using (PlannerContext dbContext = new PlannerContext())
            {
                List<PlanTask> allTasks = dbContext.PlanListData.ToList();
                
                foreach (PlanTask el in allTasks)
                {
                    ContextListBox.Items.AddRange(new object[] { el.PlanTaskID, el.TaskName, el.TaskData });
                }
            }
        }

        private void ContextListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }        
    }
    }
