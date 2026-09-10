namespace Forms
{
    partial class MainForm
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
            panel1 = new Panel();
            button1 = new Button();
            lblMode = new Label();
            lblBright = new Label();
            lblLight = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            panel2 = new Panel();
            textBox1 = new TextBox();
            panel3 = new Panel();
            panel4 = new Panel();
            textBox2 = new TextBox();
            lstOperations = new ListBox();
            lblNameOfOperation = new Label();
            label1 = new Label();
            btnRun = new Button();
            panel5 = new Panel();
            panel6 = new Panel();
            label2 = new Label();
            label3 = new Label();
            panel7 = new Panel();
            lblPred = new Label();
            lblPost = new Label();
            panel8 = new Panel();
            panel9 = new Panel();
            label4 = new Label();
            label5 = new Label();
            btnContract = new Button();
            textBox3 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.фон;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lblMode);
            panel1.Controls.Add(lblBright);
            panel1.Controls.Add(lblLight);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(925, 170);
            panel1.Name = "panel1";
            panel1.Size = new Size(562, 708);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(158, 654);
            button1.Name = "button1";
            button1.Size = new Size(256, 45);
            button1.TabIndex = 22;
            button1.Text = "Журнал операций";
            button1.UseVisualStyleBackColor = false;
            // 
            // lblMode
            // 
            lblMode.BackColor = Color.Lavender;
            lblMode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblMode.Location = new Point(136, 605);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(403, 38);
            lblMode.TabIndex = 5;
            lblMode.Text = "ручной";
            // 
            // lblBright
            // 
            lblBright.BackColor = Color.Lavender;
            lblBright.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblBright.Location = new Point(136, 546);
            lblBright.Name = "lblBright";
            lblBright.Size = new Size(403, 38);
            lblBright.TabIndex = 4;
            // 
            // lblLight
            // 
            lblLight.BackColor = Color.Lavender;
            lblLight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblLight.Location = new Point(136, 488);
            lblLight.Name = "lblLight";
            lblLight.Size = new Size(403, 38);
            lblLight.TabIndex = 3;
            // 
            // label8
            // 
            label8.BackColor = Color.Lavender;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(27, 605);
            label8.Name = "label8";
            label8.Size = new Size(103, 38);
            label8.TabIndex = 2;
            label8.Text = "Режим:";
            // 
            // label7
            // 
            label7.BackColor = Color.Lavender;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(27, 546);
            label7.Name = "label7";
            label7.Size = new Size(103, 38);
            label7.TabIndex = 1;
            label7.Text = "Яркость:";
            // 
            // label6
            // 
            label6.BackColor = Color.Lavender;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(27, 488);
            label6.Name = "label6";
            label6.Size = new Size(103, 38);
            label6.TabIndex = 0;
            label6.Text = "Свет:";
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(192, 192, 255);
            txtName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtName.Location = new Point(12, 12);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(1475, 45);
            txtName.TabIndex = 1;
            txtName.Text = "Ночник";
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Location = new Point(12, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(1475, 5);
            panel2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(192, 192, 255);
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(12, 99);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(347, 45);
            textBox1.TabIndex = 3;
            textBox1.Text = "Операции";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 192, 255);
            panel3.Location = new Point(380, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 819);
            panel3.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(192, 192, 255);
            panel4.Location = new Point(890, 75);
            panel4.Name = "panel4";
            panel4.Size = new Size(5, 819);
            panel4.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(192, 192, 255);
            textBox2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(407, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(458, 45);
            textBox2.TabIndex = 6;
            textBox2.Text = "Карточка операции";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // lstOperations
            // 
            lstOperations.BackColor = Color.Lavender;
            lstOperations.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lstOperations.FormattingEnabled = true;
            lstOperations.ItemHeight = 32;
            lstOperations.Location = new Point(12, 170);
            lstOperations.Name = "lstOperations";
            lstOperations.Size = new Size(347, 708);
            lstOperations.TabIndex = 7;
            // 
            // lblNameOfOperation
            // 
            lblNameOfOperation.BackColor = Color.Lavender;
            lblNameOfOperation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblNameOfOperation.Location = new Point(407, 170);
            lblNameOfOperation.Name = "lblNameOfOperation";
            lblNameOfOperation.Size = new Size(458, 38);
            lblNameOfOperation.TabIndex = 8;
            lblNameOfOperation.Text = "label1";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(407, 234);
            label1.Name = "label1";
            label1.Size = new Size(458, 38);
            label1.TabIndex = 9;
            label1.Text = "Параметры:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRun
            // 
            btnRun.BackColor = Color.FromArgb(192, 192, 255);
            btnRun.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnRun.Location = new Point(557, 551);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(152, 45);
            btnRun.TabIndex = 10;
            btnRun.Text = "Выполнить";
            btnRun.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(192, 192, 255);
            panel5.Location = new Point(407, 614);
            panel5.Name = "panel5";
            panel5.Size = new Size(458, 5);
            panel5.TabIndex = 11;
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightGray;
            panel6.Location = new Point(407, 639);
            panel6.Name = "panel6";
            panel6.Size = new Size(28, 32);
            panel6.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Lavender;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(441, 639);
            label2.Name = "label2";
            label2.Size = new Size(166, 32);
            label2.TabIndex = 13;
            label2.Text = "Предусловие:";
            // 
            // label3
            // 
            label3.BackColor = Color.Lavender;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(441, 684);
            label3.Name = "label3";
            label3.Size = new Size(166, 32);
            label3.TabIndex = 15;
            label3.Text = "Постусловие:";
            // 
            // panel7
            // 
            panel7.BackColor = Color.LightGray;
            panel7.Location = new Point(407, 684);
            panel7.Name = "panel7";
            panel7.Size = new Size(28, 32);
            panel7.TabIndex = 14;
            // 
            // lblPred
            // 
            lblPred.BackColor = Color.Lavender;
            lblPred.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPred.Location = new Point(613, 639);
            lblPred.Name = "lblPred";
            lblPred.Size = new Size(252, 32);
            lblPred.TabIndex = 16;
            lblPred.Text = "label4";
            // 
            // lblPost
            // 
            lblPost.BackColor = Color.Lavender;
            lblPost.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPost.Location = new Point(613, 684);
            lblPost.Name = "lblPost";
            lblPost.Size = new Size(252, 32);
            lblPost.TabIndex = 17;
            lblPost.Text = "label4";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(192, 192, 255);
            panel8.Location = new Point(407, 824);
            panel8.Name = "panel8";
            panel8.Size = new Size(458, 5);
            panel8.TabIndex = 12;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(192, 192, 255);
            panel9.Location = new Point(407, 742);
            panel9.Name = "panel9";
            panel9.Size = new Size(458, 5);
            panel9.TabIndex = 13;
            // 
            // label4
            // 
            label4.BackColor = Color.Lavender;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(407, 766);
            label4.Name = "label4";
            label4.Size = new Size(127, 38);
            label4.TabIndex = 18;
            label4.Text = "Результат:";
            // 
            // label5
            // 
            label5.BackColor = Color.Lavender;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(540, 766);
            label5.Name = "label5";
            label5.Size = new Size(325, 38);
            label5.TabIndex = 19;
            label5.Text = "label5";
            // 
            // btnContract
            // 
            btnContract.BackColor = Color.FromArgb(192, 192, 255);
            btnContract.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnContract.Location = new Point(557, 849);
            btnContract.Name = "btnContract";
            btnContract.Size = new Size(152, 45);
            btnContract.TabIndex = 20;
            btnContract.Text = "Контракт";
            btnContract.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(192, 192, 255);
            textBox3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(925, 99);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(561, 45);
            textBox3.TabIndex = 21;
            textBox3.Text = "Состояние";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(1498, 903);
            Controls.Add(textBox3);
            Controls.Add(btnContract);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel8);
            Controls.Add(panel9);
            Controls.Add(lblPost);
            Controls.Add(lblPred);
            Controls.Add(label3);
            Controls.Add(panel7);
            Controls.Add(label2);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(btnRun);
            Controls.Add(label1);
            Controls.Add(lblNameOfOperation);
            Controls.Add(lstOperations);
            Controls.Add(textBox2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(textBox1);
            Controls.Add(panel2);
            Controls.Add(txtName);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtName;
        private Panel panel2;
        private TextBox textBox1;
        private Panel panel3;
        private Panel panel4;
        private TextBox textBox2;
        private ListBox lstOperations;
        private Label lblNameOfOperation;
        private Label label1;
        private Button btnRun;
        private Panel panel5;
        private Panel panel6;
        private Label label2;
        private Label label3;
        private Panel panel7;
        private Label lblPred;
        private Label lblPost;
        private Panel panel8;
        private Panel panel9;
        private Label label4;
        private Label label5;
        private Button btnContract;
        private Label label6;
        private TextBox textBox3;
        private Label lblMode;
        private Label lblBright;
        private Label lblLight;
        private Label label8;
        private Label label7;
        private Button button1;
    }
}
