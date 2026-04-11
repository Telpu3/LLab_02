namespace _2
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            labelResult1 = new Label();
            button1 = new Button();
            textBoxN1 = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            listBoxPerfect = new ListBox();
            buttonGenerate = new Button();
            textBoxN2 = new TextBox();
            label2 = new Label();
            tabPage3 = new TabPage();
            labelSumCheck = new Label();
            pictureBox = new PictureBox();
            buttonVisualize = new Button();
            textBoxPerfect = new TextBox();
            labelPerfectInfo = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(137, 43);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(891, 553);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.RosyBrown;
            tabPage1.Controls.Add(labelResult1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(textBoxN1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(883, 520);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Проверка";
            // 
            // labelResult1
            // 
            labelResult1.AutoSize = true;
            labelResult1.Location = new Point(365, 278);
            labelResult1.Name = "labelResult1";
            labelResult1.Size = new Size(161, 20);
            labelResult1.TabIndex = 3;
            labelResult1.Text = "Здесь будет результат";
            labelResult1.Click += labelresult1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(386, 210);
            button1.Name = "button1";
            button1.Size = new Size(125, 29);
            button1.TabIndex = 2;
            button1.Text = "Проверить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxN1
            // 
            textBoxN1.BackColor = SystemColors.MenuHighlight;
            textBoxN1.BorderStyle = BorderStyle.FixedSingle;
            textBoxN1.Location = new Point(386, 139);
            textBoxN1.Name = "textBoxN1";
            textBoxN1.Size = new Size(125, 27);
            textBoxN1.TabIndex = 1;
            textBoxN1.Text = "5";
            textBoxN1.TextAlign = HorizontalAlignment.Center;
            textBoxN1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(386, 72);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 0;
            label1.Text = "Введите число";
            label1.Click += label1_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Turquoise;
            tabPage2.Controls.Add(listBoxPerfect);
            tabPage2.Controls.Add(buttonGenerate);
            tabPage2.Controls.Add(textBoxN2);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(883, 520);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Диапазон";
            // 
            // listBoxPerfect
            // 
            listBoxPerfect.BackColor = Color.YellowGreen;
            listBoxPerfect.FormattingEnabled = true;
            listBoxPerfect.Location = new Point(23, 220);
            listBoxPerfect.Name = "listBoxPerfect";
            listBoxPerfect.Size = new Size(857, 284);
            listBoxPerfect.TabIndex = 3;
            // 
            // buttonGenerate
            // 
            buttonGenerate.BackColor = Color.Violet;
            buttonGenerate.FlatStyle = FlatStyle.Popup;
            buttonGenerate.Location = new Point(318, 157);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(260, 29);
            buttonGenerate.TabIndex = 2;
            buttonGenerate.Text = "Найти совершенные числа";
            buttonGenerate.UseVisualStyleBackColor = false;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // textBoxN2
            // 
            textBoxN2.BackColor = Color.MintCream;
            textBoxN2.BorderStyle = BorderStyle.FixedSingle;
            textBoxN2.Location = new Point(376, 88);
            textBoxN2.Name = "textBoxN2";
            textBoxN2.Size = new Size(125, 27);
            textBoxN2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 88);
            label2.Name = "label2";
            label2.Size = new Size(213, 20);
            label2.TabIndex = 0;
            label2.Text = "Введите верхнюю границу N:";
            label2.Click += label2_Click;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Violet;
            tabPage3.Controls.Add(labelSumCheck);
            tabPage3.Controls.Add(pictureBox);
            tabPage3.Controls.Add(buttonVisualize);
            tabPage3.Controls.Add(textBoxPerfect);
            tabPage3.Controls.Add(labelPerfectInfo);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(883, 520);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Рисунок";
            // 
            // labelSumCheck
            // 
            labelSumCheck.AutoSize = true;
            labelSumCheck.Location = new Point(295, 144);
            labelSumCheck.Name = "labelSumCheck";
            labelSumCheck.Size = new Size(50, 20);
            labelSumCheck.TabIndex = 4;
            labelSumCheck.Text = "label4";
            labelSumCheck.Click += label4_Click;
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(0, 220);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(883, 300);
            pictureBox.TabIndex = 3;
            pictureBox.TabStop = false;
            pictureBox.Paint += pictureBox_Paint;
            // 
            // buttonVisualize
            // 
            buttonVisualize.BackColor = Color.Wheat;
            buttonVisualize.FlatStyle = FlatStyle.Flat;
            buttonVisualize.Location = new Point(465, 50);
            buttonVisualize.Name = "buttonVisualize";
            buttonVisualize.Size = new Size(200, 29);
            buttonVisualize.TabIndex = 2;
            buttonVisualize.Text = "Визуализировать";
            buttonVisualize.UseVisualStyleBackColor = false;
            buttonVisualize.Click += buttonVisualize_Click;
            // 
            // textBoxPerfect
            // 
            textBoxPerfect.Location = new Point(295, 47);
            textBoxPerfect.Name = "textBoxPerfect";
            textBoxPerfect.Size = new Size(125, 27);
            textBoxPerfect.TabIndex = 1;
            // 
            // labelPerfectInfo
            // 
            labelPerfectInfo.AutoSize = true;
            labelPerfectInfo.Location = new Point(56, 50);
            labelPerfectInfo.Name = "labelPerfectInfo";
            labelPerfectInfo.Size = new Size(213, 20);
            labelPerfectInfo.TabIndex = 0;
            labelPerfectInfo.Text = "Введите совершенное число:";
            labelPerfectInfo.Click += labelPerfectInfo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1385, 645);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label labelResult1;
        private Button button1;
        private TextBox textBoxN1;
        private Label label1;
        private Label label2;
        private TextBox textBoxN2;
        private ListBox listBoxPerfect;
        private Button buttonGenerate;
        private Label labelSumCheck;
        private PictureBox pictureBox;
        private Button buttonVisualize;
        private TextBox textBoxPerfect;
        private Label labelPerfectInfo;
    }
}
