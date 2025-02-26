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

namespace WinFormTodo
{
    public partial class Form1 : Form
    {
        private List<Todo> TaskList {  get; set; }
        public Form1()
        {
            InitializeComponent();
            TaskList = new List<Todo>();
        }

        private void tbTask_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitForm(object sender, EventArgs e)
        {
           

            if (Validators.IsEmptyText(txtTaskDescription))
            {
                MessageBox.Show("Description is empty, please provide a description.");
                return;
            } 

            if (Validators.IsTextNull(txtTaskDescription))
            {
                MessageBox.Show("Description needs to be created.");
                return;
            }
            
            if (Validators.IsEmptyText(txtDueDate))
            {
                MessageBox.Show("missing a due date. Format as xxxx-xx-xx");
                return;
            }

            if (!Validators.IsValidDate(txtDueDate))
            {
                MessageBox.Show("Date is incorrectly formatted, Format as xxxx-xx-xx");
                return;
            }

            Todo myTodo = new Todo(txtTaskDescription.Text, DateTime.Parse(txtDueDate.Text));

            
            TaskList.Add(myTodo);
            fpTasks.Controls.Add(new TaskControl(myTodo));

            UpdateListBox();

            ClearForm();
        }

        public void UpdateListBox()
        {
            //lbTaskList.Items.Clear();

            var list = TaskList
                //.Where(t => t.IsDone == false)
                .OrderBy(t => t.DueDate)
                .ToList();

            for (int i = 0; i < list.Count; i++)
            {
                //lbTaskList.Items.Add(list[i].ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
            MessageBox.Show("Form Cleared");
        }
        private void ClearForm ()
        {
            txtDueDate.Clear();
            txtTaskDescription.Clear();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                submitForm(sender, e);
            }
        }

        //private void lbTaskList_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //MessageBox.Show($"Selected Index is: {lbTaskList.SelectedIndex}");

        //    //int selectedIndex = lbTaskList.SelectedIndex;
        //    //string selectedItem = (string)lbTaskList.SelectedItem;

        //    if (selectedIndex == -1)
        //    {
        //        return;
        //    }

        //    if (selectedItem == null)
        //    {
        //        MessageBox.Show("No item selected at the index.");
        //        return;
        //    }


        //    int id = Int32.Parse(selectedItem.Split(new string[]{" - "}, StringSplitOptions.None)[0]);

        //    var todo = TaskList.Find(t => t. Id == id);

        //    if (todo != null)
        //    {
        //        todo.IsDone = !todo.IsDone;
        //        UpdateListBox();
        //    }
        //}
    }
}
