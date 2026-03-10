namespace TodoAppCustomControls
{
    partial class TaskControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDueDate = new Label();
            lblTask = new Label();
            lblDataDueDate = new Label();
            lblDataTask = new Label();
            btnMarkDone = new Button();
            SuspendLayout();
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(3, 10);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(58, 15);
            lblDueDate.TabIndex = 0;
            lblDueDate.Text = "Due Date:";
            // 
            // lblTask
            // 
            lblTask.AutoSize = true;
            lblTask.Location = new Point(29, 34);
            lblTask.Name = "lblTask";
            lblTask.Size = new Size(32, 15);
            lblTask.TabIndex = 1;
            lblTask.Text = "Task:";
            // 
            // lblDataDueDate
            // 
            lblDataDueDate.AutoSize = true;
            lblDataDueDate.Location = new Point(67, 10);
            lblDataDueDate.Name = "lblDataDueDate";
            lblDataDueDate.Size = new Size(111, 15);
            lblDataDueDate.TabIndex = 2;
            lblDataDueDate.Text = "Date data goes here";
            // 
            // lblDataTask
            // 
            lblDataTask.AutoSize = true;
            lblDataTask.Location = new Point(67, 34);
            lblDataTask.Name = "lblDataTask";
            lblDataTask.Size = new Size(109, 15);
            lblDataTask.TabIndex = 3;
            lblDataTask.Text = "Task data goes here";
            // 
            // btnMarkDone
            // 
            btnMarkDone.Location = new Point(298, 6);
            btnMarkDone.Name = "btnMarkDone";
            btnMarkDone.Size = new Size(75, 23);
            btnMarkDone.TabIndex = 4;
            btnMarkDone.Text = "Mark Done";
            btnMarkDone.UseVisualStyleBackColor = true;
            // 
            // TaskControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnMarkDone);
            Controls.Add(lblDataTask);
            Controls.Add(lblDataDueDate);
            Controls.Add(lblTask);
            Controls.Add(lblDueDate);
            Name = "TaskControl";
            Size = new Size(384, 60);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDueDate;
        private Label lblTask;
        private Label lblDataDueDate;
        private Label lblDataTask;
        private Button btnMarkDone;
    }
}
