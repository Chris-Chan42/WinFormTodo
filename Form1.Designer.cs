namespace WinFormTodo
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbTaskForm = new System.Windows.Forms.GroupBox();
            this.txtDueDate = new System.Windows.Forms.TextBox();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.lblTask = new System.Windows.Forms.Label();
            this.btnAddTodo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbTaskList = new System.Windows.Forms.GroupBox();
            this.lvTaskList = new System.Windows.Forms.ListView();
            this.gbTaskForm.SuspendLayout();
            this.gbTaskList.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTaskForm
            // 
            this.gbTaskForm.Controls.Add(this.btnClear);
            this.gbTaskForm.Controls.Add(this.btnAddTodo);
            this.gbTaskForm.Controls.Add(this.txtDueDate);
            this.gbTaskForm.Controls.Add(this.lblDueDate);
            this.gbTaskForm.Controls.Add(this.txtTaskDescription);
            this.gbTaskForm.Controls.Add(this.lblTask);
            this.gbTaskForm.Location = new System.Drawing.Point(12, 12);
            this.gbTaskForm.Name = "gbTaskForm";
            this.gbTaskForm.Size = new System.Drawing.Size(295, 92);
            this.gbTaskForm.TabIndex = 0;
            this.gbTaskForm.TabStop = false;
            this.gbTaskForm.Text = "Task Form";
            // 
            // txtDueDate
            // 
            this.txtDueDate.Location = new System.Drawing.Point(65, 37);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.Size = new System.Drawing.Size(224, 20);
            this.txtDueDate.TabIndex = 3;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(6, 40);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(53, 13);
            this.lblDueDate.TabIndex = 2;
            this.lblDueDate.Text = "Due Date";
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.Location = new System.Drawing.Point(65, 13);
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(230, 20);
            this.txtTaskDescription.TabIndex = 1;
            this.txtTaskDescription.TextChanged += new System.EventHandler(this.tbTask_TextChanged);
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Location = new System.Drawing.Point(6, 16);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(31, 13);
            this.lblTask.TabIndex = 0;
            this.lblTask.Text = "Task";
            // 
            // btnAddTodo
            // 
            this.btnAddTodo.Location = new System.Drawing.Point(214, 63);
            this.btnAddTodo.Name = "btnAddTodo";
            this.btnAddTodo.Size = new System.Drawing.Size(75, 23);
            this.btnAddTodo.TabIndex = 4;
            this.btnAddTodo.Text = "Add Todo";
            this.btnAddTodo.UseVisualStyleBackColor = true;
            this.btnAddTodo.Click += new System.EventHandler(this.btnAddTodo_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(133, 63);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gbTaskList
            // 
            this.gbTaskList.Controls.Add(this.lvTaskList);
            this.gbTaskList.Location = new System.Drawing.Point(12, 110);
            this.gbTaskList.Name = "gbTaskList";
            this.gbTaskList.Size = new System.Drawing.Size(295, 378);
            this.gbTaskList.TabIndex = 1;
            this.gbTaskList.TabStop = false;
            this.gbTaskList.Text = "Task List";
            // 
            // lvTaskList
            // 
            this.lvTaskList.HideSelection = false;
            this.lvTaskList.Location = new System.Drawing.Point(9, 19);
            this.lvTaskList.Name = "lvTaskList";
            this.lvTaskList.Size = new System.Drawing.Size(280, 353);
            this.lvTaskList.TabIndex = 0;
            this.lvTaskList.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 500);
            this.Controls.Add(this.gbTaskList);
            this.Controls.Add(this.gbTaskForm);
            this.Name = "Form1";
            this.Text = "Todo App";
            this.gbTaskForm.ResumeLayout(false);
            this.gbTaskForm.PerformLayout();
            this.gbTaskList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTaskForm;
        private System.Windows.Forms.TextBox txtDueDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddTodo;
        private System.Windows.Forms.GroupBox gbTaskList;
        private System.Windows.Forms.ListView lvTaskList;
    }
}

