namespace WinFormsApp1
{
    partial class MainForm
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
            dataGridView1 = new DataGridView();
            SearchBox = new TextBox();
            label1 = new Label();
            AddButton = new Button();
            EditButton = new Button();
            AnaliticButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(295, 14);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(718, 542);
            dataGridView1.TabIndex = 1;
            // 
            // SearchBox
            // 
            SearchBox.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            SearchBox.Location = new Point(16, 44);
            SearchBox.Margin = new Padding(4, 5, 4, 5);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(272, 39);
            SearchBox.TabIndex = 2;
            SearchBox.TextChanged += SearchBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(242, 31);
            label1.TabIndex = 3;
            label1.Text = "Поиск по описанию";
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.Location = new Point(13, 347);
            AddButton.Margin = new Padding(4, 5, 4, 5);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(274, 63);
            AddButton.TabIndex = 5;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // EditButton
            // 
            EditButton.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            EditButton.Location = new Point(13, 420);
            EditButton.Margin = new Padding(4, 5, 4, 5);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(274, 63);
            EditButton.TabIndex = 6;
            EditButton.Text = "Сохранить изменения";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // AnaliticButton
            // 
            AnaliticButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            AnaliticButton.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            AnaliticButton.Location = new Point(13, 493);
            AnaliticButton.Margin = new Padding(4, 5, 4, 5);
            AnaliticButton.Name = "AnaliticButton";
            AnaliticButton.Size = new Size(274, 63);
            AnaliticButton.TabIndex = 7;
            AnaliticButton.Text = "Анализ";
            AnaliticButton.UseVisualStyleBackColor = true;
            AnaliticButton.Click += AnaliticButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 570);
            Controls.Add(AnaliticButton);
            Controls.Add(EditButton);
            Controls.Add(AddButton);
            Controls.Add(label1);
            Controls.Add(SearchBox);
            Controls.Add(dataGridView1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private TextBox SearchBox;
        private Label label1;
        private Button button2;
        private Button AddButton;
        private Button EditButton;
        private Button AnaliticButton;
    }
}