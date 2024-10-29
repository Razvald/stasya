namespace WinFormsApp1
{
    partial class AddEditRequestForm
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
            SaveButton = new Button();
            label1 = new Label();
            ClientCmb = new ComboBox();
            PriorityTxt = new TextBox();
            EquipCmb = new ComboBox();
            Клиент = new Label();
            label = new Label();
            ProblemTxt = new TextBox();
            DescriptionTxt = new TextBox();
            ReasonTxt = new TextBox();
            CostTxt = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButton.Location = new Point(610, 344);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(162, 59);
            SaveButton.TabIndex = 0;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(105, 23);
            label1.TabIndex = 1;
            label1.Text = "Приоритет";
            // 
            // ClientCmb
            // 
            ClientCmb.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ClientCmb.FormattingEnabled = true;
            ClientCmb.Location = new Point(610, 35);
            ClientCmb.Name = "ClientCmb";
            ClientCmb.Size = new Size(162, 31);
            ClientCmb.TabIndex = 3;
            // 
            // PriorityTxt
            // 
            PriorityTxt.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PriorityTxt.Location = new Point(12, 35);
            PriorityTxt.Name = "PriorityTxt";
            PriorityTxt.Size = new Size(524, 32);
            PriorityTxt.TabIndex = 4;
            // 
            // EquipCmb
            // 
            EquipCmb.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            EquipCmb.FormattingEnabled = true;
            EquipCmb.Location = new Point(610, 177);
            EquipCmb.Name = "EquipCmb";
            EquipCmb.Size = new Size(162, 31);
            EquipCmb.TabIndex = 5;
            // 
            // Клиент
            // 
            Клиент.AutoSize = true;
            Клиент.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Клиент.Location = new Point(610, 9);
            Клиент.Name = "Клиент";
            Клиент.Size = new Size(74, 23);
            Клиент.TabIndex = 6;
            Клиент.Text = "Клиент";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label.Location = new Point(610, 151);
            label.Name = "label";
            label.Size = new Size(137, 23);
            label.TabIndex = 7;
            label.Text = "Оборудование";
            // 
            // ProblemTxt
            // 
            ProblemTxt.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ProblemTxt.Location = new Point(12, 107);
            ProblemTxt.Name = "ProblemTxt";
            ProblemTxt.Size = new Size(524, 32);
            ProblemTxt.TabIndex = 8;
            // 
            // DescriptionTxt
            // 
            DescriptionTxt.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionTxt.Location = new Point(12, 191);
            DescriptionTxt.Name = "DescriptionTxt";
            DescriptionTxt.Size = new Size(524, 32);
            DescriptionTxt.TabIndex = 9;
            // 
            // ReasonTxt
            // 
            ReasonTxt.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ReasonTxt.Location = new Point(12, 275);
            ReasonTxt.Name = "ReasonTxt";
            ReasonTxt.Size = new Size(524, 32);
            ReasonTxt.TabIndex = 10;
            // 
            // CostTxt
            // 
            CostTxt.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CostTxt.Location = new Point(12, 359);
            CostTxt.Name = "CostTxt";
            CostTxt.Size = new Size(524, 32);
            CostTxt.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 81);
            label4.Name = "label4";
            label4.Size = new Size(180, 23);
            label4.TabIndex = 12;
            label4.Text = "Тип неисправности";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 165);
            label5.Name = "label5";
            label5.Size = new Size(189, 23);
            label5.TabIndex = 13;
            label5.Text = "Описание проблемы";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 249);
            label6.Name = "label6";
            label6.Size = new Size(225, 23);
            label6.TabIndex = 14;
            label6.Text = "Причина неисправности";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 333);
            label7.Name = "label7";
            label7.Size = new Size(108, 23);
            label7.TabIndex = 15;
            label7.Text = "Стоимость";
            // 
            // AddEditRequestForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 415);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(CostTxt);
            Controls.Add(ReasonTxt);
            Controls.Add(DescriptionTxt);
            Controls.Add(ProblemTxt);
            Controls.Add(label);
            Controls.Add(Клиент);
            Controls.Add(EquipCmb);
            Controls.Add(PriorityTxt);
            Controls.Add(ClientCmb);
            Controls.Add(label1);
            Controls.Add(SaveButton);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "AddEditRequestForm";
            Text = "AddEditRequestForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveButton;
        private Label label1;
        private ComboBox ClientCmb;
        private TextBox PriorityTxt;
        private ComboBox EquipCmb;
        private Label Клиент;
        private Label label;
        private TextBox ProblemTxt;
        private TextBox DescriptionTxt;
        private TextBox ReasonTxt;
        private TextBox CostTxt;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}