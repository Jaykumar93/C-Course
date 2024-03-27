namespace To_Do_List
{
    partial class ToDoList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            DescriptionBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            New = new Button();
            Edit = new Button();
            Delete = new Button();
            Save = new Button();
            ToDoListView = new DataGridView();
            TitleBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ToDoListView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(776, 40);
            label1.TabIndex = 0;
            label1.Text = "To Do List";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // DescriptionBox
            // 
            DescriptionBox.BorderStyle = BorderStyle.None;
            DescriptionBox.Location = new Point(12, 111);
            DescriptionBox.Multiline = true;
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(776, 23);
            DescriptionBox.TabIndex = 2;
            DescriptionBox.TextChanged += DescriptionBox_TextChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(776, 23);
            label2.TabIndex = 3;
            label2.Text = "Title:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(12, 93);
            label3.Name = "label3";
            label3.Size = new Size(776, 23);
            label3.TabIndex = 4;
            label3.Text = "Description:";
            label3.Click += label3_Click;
            // 
            // New
            // 
            New.BackColor = Color.DodgerBlue;
            New.Location = new Point(12, 140);
            New.Margin = new Padding(0);
            New.Name = "New";
            New.Size = new Size(188, 23);
            New.TabIndex = 5;
            New.Text = "New";
            New.UseVisualStyleBackColor = false;
            New.Click += New_Click;
            // 
            // Edit
            // 
            Edit.BackColor = Color.DodgerBlue;
            Edit.Location = new Point(208, 140);
            Edit.Margin = new Padding(0);
            Edit.Name = "Edit";
            Edit.Size = new Size(188, 23);
            Edit.TabIndex = 6;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = false;
            Edit.Click += Edit_Click;
            // 
            // Delete
            // 
            Delete.BackColor = Color.DodgerBlue;
            Delete.Location = new Point(404, 140);
            Delete.Margin = new Padding(0);
            Delete.Name = "Delete";
            Delete.Size = new Size(188, 23);
            Delete.TabIndex = 7;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // Save
            // 
            Save.BackColor = Color.DodgerBlue;
            Save.Location = new Point(600, 140);
            Save.Margin = new Padding(0);
            Save.Name = "Save";
            Save.Size = new Size(188, 23);
            Save.TabIndex = 8;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // ToDoListView
            // 
            ToDoListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ToDoListView.BackgroundColor = SystemColors.ControlLightLight;
            ToDoListView.BorderStyle = BorderStyle.None;
            ToDoListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ToDoListView.Location = new Point(12, 169);
            ToDoListView.Margin = new Padding(0);
            ToDoListView.Name = "ToDoListView";
            ToDoListView.Size = new Size(776, 278);
            ToDoListView.TabIndex = 9;
            // 
            // TitleBox
            // 
            TitleBox.BorderStyle = BorderStyle.None;
            TitleBox.Location = new Point(12, 66);
            TitleBox.Multiline = true;
            TitleBox.Name = "TitleBox";
            TitleBox.Size = new Size(776, 23);
            TitleBox.TabIndex = 10;
            TitleBox.TextChanged += TitleBox_TextChanged_1;
            // 
            // ToDoList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(TitleBox);
            Controls.Add(DescriptionBox);
            Controls.Add(ToDoListView);
            Controls.Add(Save);
            Controls.Add(Delete);
            Controls.Add(Edit);
            Controls.Add(New);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "ToDoList";
            Text = "To-Do List";
            Load += ToDoList_Load;
            ((System.ComponentModel.ISupportInitialize)ToDoListView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox DescriptionBox;
        private Label label2;
        private Label label3;
        private Button New;
        private Button Edit;
        private Button Delete;
        private Button Save;
        private DataGridView ToDoListView;
        private TextBox TitleBox;
    }
}
