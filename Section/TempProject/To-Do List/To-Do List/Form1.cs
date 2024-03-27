using System.Data;

namespace To_Do_List
{
    public partial class ToDoList : Form
    {
        DataTable todoList = new DataTable();
        bool isEditing = false;

        public ToDoList()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DescriptionBox_TextChanged(object sender, EventArgs e)
        {

        }




        private void ToDoList_Load(object sender, EventArgs e)
        {
            // Columns
            todoList.Columns.Add("Title");
            todoList.Columns.Add("Description");

            // point our datagribvew to out datasources
            ToDoListView.DataSource = todoList;

        }

        private void New_Click(object sender, EventArgs e)
        {
            TitleBox.Text = "";
            DescriptionBox.Text = "";
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            isEditing = true;

            //Fill text fields with data from table

            TitleBox.Text = todoList.Rows[ToDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();

            DescriptionBox.Text = todoList.Rows[ToDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                todoList.Rows[ToDoListView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                todoList.Rows[ToDoListView.CurrentCell.RowIndex]["Title"] = TitleBox.Text;
                todoList.Rows[ToDoListView.CurrentCell.RowIndex]["Description"] = DescriptionBox.Text;
            }
            else
            {
                todoList.Rows.Add(TitleBox.Text, DescriptionBox.Text);
            }

            // clearing the fields 
            TitleBox.Text = "";
            DescriptionBox.Text = "";
        }

        private void TitleBox_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
