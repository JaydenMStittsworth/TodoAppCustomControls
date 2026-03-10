using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace TodoAppCustomControls
{
    public partial class frmTodoApp : Form
    {
        public List<TaskToDo> NewTask { get; set; }
        public frmTodoApp()
        {
            InitializeComponent();
            NewTask = new List<TaskToDo>();
        }
        public int Num { get; set; }

        public void UpdateTaskListBox()
        {
            // refreshes the list box with the newest contacts
            fpTasks.Controls.Clear();

            //var orderTasks = NewTask.OrderBy(TaskToDo => TaskToDo.Due);
            foreach (TaskToDo newtask in NewTask)
            {
                var item = new TaskControl(newtask);
                item.Parent = this;
                fpTasks.Controls.Add(item);
            }

            // TODO: create a new task control
        }

        public void AddTaskToDo(
            DateTime due,
            string task)
        {
            NewTask.Add(new TaskToDo
            {
                Task = task,
                Due = due,
            });
        }

        private void frmTodoApp_Load(object sender, EventArgs e)
        {
        }

        private void ClearForm()
        {
            txtTask.Clear();
            txtDue.Clear();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTask.Text == "" && txtDue.Text == "")
            {
                MessageBox.Show(
                "Both the Task Textbox and " +
                "the Due Date Textbox cannot be left empty.");
                txtTask.Focus();
                return;
            }
            else if (txtTask.Text == "")
            {
                MessageBox.Show("The Task Textbox cannot be left empty.");
                txtTask.Focus();
                return;
            }
            else if (txtDue.Text == "")
            {
                MessageBox.Show("The Due Date Textbox cannot be left empty.");
                txtDue.Focus();
                return;
            }
            else
            {
                try
                {
                    // capture the data
                    // create a new task
                    TaskToDo newTask = new TaskToDo
                    {
                        Task = txtTask.Text,
                        Due = DateTime.Parse(txtDue.Text),
                    };
                    // add it to the list
                    NewTask.Add(newTask);

                    // pull the lever to update
                    UpdateTaskListBox();

                    // clear text boxes
                    ClearForm();

                    // reset cursor
                    txtTask.Focus();
                }
                catch
                {
                    MessageBox.Show("Please write a valid date in the Due Date Textbox");
                    txtDue.Focus();
                }
            }
                
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
            txtTask.Focus();
        }
    }
}
