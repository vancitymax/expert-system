namespace ExpertSystemWinForms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.AnswerList = new System.Windows.Forms.CheckedListBox();
            this.AnswerBTN = new System.Windows.Forms.Button();
            this.ResultList = new System.Windows.Forms.ListBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.PhysikDMGInput = new System.Windows.Forms.TextBox();
            this.MagikDMGInput = new System.Windows.Forms.TextBox();
            this.PhysikDMGText = new System.Windows.Forms.Label();
            this.MagikDMGText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartBTN
            // 
            this.StartBTN.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartBTN.Location = new System.Drawing.Point(255, 124);
            this.StartBTN.Name = "StartBTN";
            this.StartBTN.Size = new System.Drawing.Size(284, 97);
            this.StartBTN.TabIndex = 0;
            this.StartBTN.Text = "Почати";
            this.StartBTN.UseVisualStyleBackColor = true;
            this.StartBTN.Click += new System.EventHandler(this.StartBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(62, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(695, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вас вітає експертна система з вибору дій у грі Dota2";
            // 
            // ExitBTN
            // 
            this.ExitBTN.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitBTN.Location = new System.Drawing.Point(255, 260);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(284, 96);
            this.ExitBTN.TabIndex = 2;
            this.ExitBTN.Text = "Вийти";
            this.ExitBTN.UseVisualStyleBackColor = true;
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.QuestionLabel.Font = new System.Drawing.Font("Segoe UI Historic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QuestionLabel.Location = new System.Drawing.Point(62, 44);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(695, 88);
            this.QuestionLabel.TabIndex = 3;
            this.QuestionLabel.Text = "Приклад довгого запитання блабалаліваоіваіваіваіваіваіваіваіваіваіва?";
            this.QuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.QuestionLabel.Visible = false;
            // 
            // AnswerList
            // 
            this.AnswerList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.AnswerList.BackColor = System.Drawing.SystemColors.Menu;
            this.AnswerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AnswerList.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnswerList.FormattingEnabled = true;
            this.AnswerList.Items.AddRange(new object[] {
            "да",
            "нет",
            "бла бла",
            "івраішлариліуиаліувиаілуа",
            "аівапукпукепркепр",
            "пркепркеркеркеркер"});
            this.AnswerList.Location = new System.Drawing.Point(179, 151);
            this.AnswerList.Name = "AnswerList";
            this.AnswerList.Size = new System.Drawing.Size(477, 224);
            this.AnswerList.TabIndex = 4;
            this.AnswerList.Visible = false;
            this.AnswerList.SelectedIndexChanged += new System.EventHandler(this.AnswerList_SelectedIndexChanged);
            // 
            // AnswerBTN
            // 
            this.AnswerBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AnswerBTN.Location = new System.Drawing.Point(283, 374);
            this.AnswerBTN.Name = "AnswerBTN";
            this.AnswerBTN.Size = new System.Drawing.Size(256, 64);
            this.AnswerBTN.TabIndex = 5;
            this.AnswerBTN.Text = "Наступне питання";
            this.AnswerBTN.UseVisualStyleBackColor = true;
            this.AnswerBTN.Visible = false;
            this.AnswerBTN.Click += new System.EventHandler(this.AnswerBTN_Click);
            // 
            // ResultList
            // 
            this.ResultList.FormattingEnabled = true;
            this.ResultList.ItemHeight = 15;
            this.ResultList.Location = new System.Drawing.Point(12, 72);
            this.ResultList.Name = "ResultList";
            this.ResultList.Size = new System.Drawing.Size(776, 364);
            this.ResultList.TabIndex = 6;
            this.ResultList.Visible = false;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResultLabel.Location = new System.Drawing.Point(255, 4);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(288, 65);
            this.ResultLabel.TabIndex = 7;
            this.ResultLabel.Text = "Результат:";
            this.ResultLabel.Visible = false;
            // 
            // PhysikDMGInput
            // 
            this.PhysikDMGInput.Location = new System.Drawing.Point(487, 156);
            this.PhysikDMGInput.Name = "PhysikDMGInput";
            this.PhysikDMGInput.Size = new System.Drawing.Size(71, 23);
            this.PhysikDMGInput.TabIndex = 8;
            this.PhysikDMGInput.Visible = false;
            // 
            // MagikDMGInput
            // 
            this.MagikDMGInput.Location = new System.Drawing.Point(487, 198);
            this.MagikDMGInput.Name = "MagikDMGInput";
            this.MagikDMGInput.Size = new System.Drawing.Size(71, 23);
            this.MagikDMGInput.TabIndex = 9;
            this.MagikDMGInput.Visible = false;
            // 
            // PhysikDMGText
            // 
            this.PhysikDMGText.AutoSize = true;
            this.PhysikDMGText.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PhysikDMGText.Location = new System.Drawing.Point(179, 151);
            this.PhysikDMGText.Name = "PhysikDMGText";
            this.PhysikDMGText.Size = new System.Drawing.Size(302, 25);
            this.PhysikDMGText.TabIndex = 10;
            this.PhysikDMGText.Text = "Ведіть відсоток фізичного урона";
            this.PhysikDMGText.Visible = false;
            // 
            // MagikDMGText
            // 
            this.MagikDMGText.AutoSize = true;
            this.MagikDMGText.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MagikDMGText.Location = new System.Drawing.Point(181, 196);
            this.MagikDMGText.Name = "MagikDMGText";
            this.MagikDMGText.Size = new System.Drawing.Size(300, 25);
            this.MagikDMGText.TabIndex = 11;
            this.MagikDMGText.Text = "Ведіть відсоток магічного урона";
            this.MagikDMGText.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MagikDMGText);
            this.Controls.Add(this.PhysikDMGText);
            this.Controls.Add(this.MagikDMGInput);
            this.Controls.Add(this.PhysikDMGInput);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.AnswerBTN);
            this.Controls.Add(this.AnswerList);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.ExitBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartBTN);
            this.Controls.Add(this.ResultList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Експертна система Dota 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button StartBTN;
        private Label label1;
        private Button ExitBTN;
        private Label QuestionLabel;
        private CheckedListBox AnswerList;
        private Button AnswerBTN;
        private ListBox ResultList;
        private Label ResultLabel;
        private TextBox PhysikDMGInput;
        private TextBox MagikDMGInput;
        private Label PhysikDMGText;
        private Label MagikDMGText;
    }
}