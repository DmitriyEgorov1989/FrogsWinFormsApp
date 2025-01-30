namespace FrogWinFormsApp
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            leftPictureBox1 = new PictureBox();
            leftPictureBox2 = new PictureBox();
            leftPictureBox3 = new PictureBox();
            leftPictureBox4 = new PictureBox();
            emptyPictureBox = new PictureBox();
            rightPictureBox1 = new PictureBox();
            rightPictureBox2 = new PictureBox();
            rightPictureBox3 = new PictureBox();
            rightPictureBox4 = new PictureBox();
            label = new Label();
            countMovesLabel = new Label();
            controlTimer = new System.Windows.Forms.Timer(components);
            gameRulesButton = new Label();
            gameRestartButton = new Label();
            ((System.ComponentModel.ISupportInitialize)leftPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptyPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightPictureBox4).BeginInit();
            SuspendLayout();
            // 
            // leftPictureBox1
            // 
            leftPictureBox1.Image = (Image)resources.GetObject("leftPictureBox1.Image");
            leftPictureBox1.Location = new Point(0, 0);
            leftPictureBox1.Margin = new Padding(3, 2, 3, 2);
            leftPictureBox1.Name = "leftPictureBox1";
            leftPictureBox1.Size = new Size(96, 82);
            leftPictureBox1.TabIndex = 0;
            leftPictureBox1.TabStop = false;
            leftPictureBox1.Click += PictureBox_Click;
            // 
            // leftPictureBox2
            // 
            leftPictureBox2.Image = (Image)resources.GetObject("leftPictureBox2.Image");
            leftPictureBox2.Location = new Point(96, 0);
            leftPictureBox2.Margin = new Padding(3, 2, 3, 2);
            leftPictureBox2.Name = "leftPictureBox2";
            leftPictureBox2.Size = new Size(96, 82);
            leftPictureBox2.TabIndex = 1;
            leftPictureBox2.TabStop = false;
            leftPictureBox2.Click += PictureBox_Click;
            // 
            // leftPictureBox3
            // 
            leftPictureBox3.Image = (Image)resources.GetObject("leftPictureBox3.Image");
            leftPictureBox3.Location = new Point(192, 0);
            leftPictureBox3.Margin = new Padding(3, 2, 3, 2);
            leftPictureBox3.Name = "leftPictureBox3";
            leftPictureBox3.Size = new Size(96, 82);
            leftPictureBox3.TabIndex = 2;
            leftPictureBox3.TabStop = false;
            leftPictureBox3.Click += PictureBox_Click;
            // 
            // leftPictureBox4
            // 
            leftPictureBox4.Image = (Image)resources.GetObject("leftPictureBox4.Image");
            leftPictureBox4.Location = new Point(289, 0);
            leftPictureBox4.Margin = new Padding(3, 2, 3, 2);
            leftPictureBox4.Name = "leftPictureBox4";
            leftPictureBox4.Size = new Size(96, 82);
            leftPictureBox4.TabIndex = 3;
            leftPictureBox4.TabStop = false;
            leftPictureBox4.Click += PictureBox_Click;
            // 
            // emptyPictureBox
            // 
            emptyPictureBox.Image = (Image)resources.GetObject("emptyPictureBox.Image");
            emptyPictureBox.Location = new Point(385, 0);
            emptyPictureBox.Margin = new Padding(3, 2, 3, 2);
            emptyPictureBox.Name = "emptyPictureBox";
            emptyPictureBox.Size = new Size(96, 82);
            emptyPictureBox.TabIndex = 4;
            emptyPictureBox.TabStop = false;
            emptyPictureBox.Click += PictureBox_Click;
            // 
            // rightPictureBox1
            // 
            rightPictureBox1.Image = (Image)resources.GetObject("rightPictureBox1.Image");
            rightPictureBox1.Location = new Point(481, 0);
            rightPictureBox1.Margin = new Padding(3, 2, 3, 2);
            rightPictureBox1.Name = "rightPictureBox1";
            rightPictureBox1.Size = new Size(96, 82);
            rightPictureBox1.TabIndex = 5;
            rightPictureBox1.TabStop = false;
            rightPictureBox1.Click += PictureBox_Click;
            // 
            // rightPictureBox2
            // 
            rightPictureBox2.Image = (Image)resources.GetObject("rightPictureBox2.Image");
            rightPictureBox2.Location = new Point(578, 0);
            rightPictureBox2.Margin = new Padding(3, 2, 3, 2);
            rightPictureBox2.Name = "rightPictureBox2";
            rightPictureBox2.Size = new Size(96, 82);
            rightPictureBox2.TabIndex = 6;
            rightPictureBox2.TabStop = false;
            rightPictureBox2.Click += PictureBox_Click;
            // 
            // rightPictureBox3
            // 
            rightPictureBox3.Image = (Image)resources.GetObject("rightPictureBox3.Image");
            rightPictureBox3.Location = new Point(674, 0);
            rightPictureBox3.Margin = new Padding(3, 2, 3, 2);
            rightPictureBox3.Name = "rightPictureBox3";
            rightPictureBox3.Size = new Size(96, 82);
            rightPictureBox3.TabIndex = 7;
            rightPictureBox3.TabStop = false;
            rightPictureBox3.Click += PictureBox_Click;
            // 
            // rightPictureBox4
            // 
            rightPictureBox4.Image = (Image)resources.GetObject("rightPictureBox4.Image");
            rightPictureBox4.Location = new Point(770, 0);
            rightPictureBox4.Margin = new Padding(3, 2, 3, 2);
            rightPictureBox4.Name = "rightPictureBox4";
            rightPictureBox4.Size = new Size(96, 82);
            rightPictureBox4.TabIndex = 8;
            rightPictureBox4.TabStop = false;
            rightPictureBox4.Click += PictureBox_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label.Location = new Point(33, 132);
            label.Name = "label";
            label.Size = new Size(117, 21);
            label.TabIndex = 9;
            label.Text = "Кол-во ходов";
            // 
            // countMovesLabel
            // 
            countMovesLabel.AutoSize = true;
            countMovesLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            countMovesLabel.Location = new Point(175, 132);
            countMovesLabel.Name = "countMovesLabel";
            countMovesLabel.Size = new Size(19, 21);
            countMovesLabel.TabIndex = 10;
            countMovesLabel.Text = "0";
            // 
            // gameRulesButton
            // 
            gameRulesButton.AutoSize = true;
            gameRulesButton.Cursor = Cursors.Hand;
            gameRulesButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            gameRulesButton.Location = new Point(768, 168);
            gameRulesButton.Name = "gameRulesButton";
            gameRulesButton.Size = new Size(90, 15);
            gameRulesButton.TabIndex = 11;
            gameRulesButton.Text = "Правила игры";
            gameRulesButton.Click += GameRulesButton_Click;
            // 
            // gameRestartButton
            // 
            gameRestartButton.AutoSize = true;
            gameRestartButton.BackColor = SystemColors.AppWorkspace;
            gameRestartButton.Cursor = Cursors.Hand;
            gameRestartButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            gameRestartButton.Location = new Point(402, 166);
            gameRestartButton.Name = "gameRestartButton";
            gameRestartButton.Size = new Size(62, 19);
            gameRestartButton.TabIndex = 12;
            gameRestartButton.Text = "Рестарт";
            gameRestartButton.Click += GameRestartButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(968, 190);
            Controls.Add(gameRestartButton);
            Controls.Add(gameRulesButton);
            Controls.Add(countMovesLabel);
            Controls.Add(label);
            Controls.Add(rightPictureBox4);
            Controls.Add(rightPictureBox3);
            Controls.Add(rightPictureBox2);
            Controls.Add(rightPictureBox1);
            Controls.Add(emptyPictureBox);
            Controls.Add(leftPictureBox4);
            Controls.Add(leftPictureBox3);
            Controls.Add(leftPictureBox2);
            Controls.Add(leftPictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)leftPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptyPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightPictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox leftPictureBox1;
        private PictureBox leftPictureBox2;
        private PictureBox leftPictureBox3;
        private PictureBox leftPictureBox4;
        private PictureBox emptyPictureBox;
        private PictureBox rightPictureBox1;
        private PictureBox rightPictureBox2;
        private PictureBox rightPictureBox3;
        private PictureBox rightPictureBox4;
        private Label label;
        private Label countMovesLabel;
        private System.Windows.Forms.Timer controlTimer;
        private Label gameRulesButton;
        private Label gameRestartButton;
    }
}
