using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoAppCustomControls
{
    public partial class TaskControl : UserControl
    {
        public TaskToDo TaskDetails { get; set; }
        public TaskControl(TaskToDo taskDetails)
        {
            InitializeComponent();
            TaskDetails = taskDetails;

            // fill in all of the details on the control using data
            lblDataDueDate.Text = TaskDetails.Due.ToShortDateString();
            lblDataTask.Text = TaskDetails.Task;
        }

        private void btnMarkDone_Click(object sender, EventArgs e)
        {
            var frm = this.Parent?.Parent?.Parent as frmTodoApp;

            if (frm != null)
            {
                MessageBox.Show($"TASK COMPLETE - {lblDataTask.Text}");
                frm.NewTask.Remove(TaskDetails);
                frm.UpdateTaskListBox();
            }
        }
    }
}
