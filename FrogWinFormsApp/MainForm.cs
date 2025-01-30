namespace FrogWinFormsApp
{
    public partial class MainForm : Form
    {
        private int _lengthOfOneCell = 110;
        public MainForm()
        {
            InitializeComponent();
            LoadSizeForm();
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            Swap((PictureBox)sender);
        }
        private void Swap(PictureBox clickedPicture)
        {
            countMovesLabel.Text = (Convert.ToInt32(countMovesLabel.Text) + 1).ToString();
            var distance = Math.Abs(clickedPicture.Location.X - emptyPictureBox.Location.X) / emptyPictureBox.Size.Width;
            if (distance > 2)
            {
                MessageBox.Show("нее");
            }
            else
            {
                var location = clickedPicture.Location;
                clickedPicture.Location = emptyPictureBox.Location;
                emptyPictureBox.Location = location;
            }
            if (EndGame())
            {
                if (Convert.ToInt32(countMovesLabel.Text) <= 24)
                {
                    var result = MessageBox.Show("вы молодец!Хотите повторить?", "Конец Игры!", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                    else
                    {
                        Close();
                    };
                }
                else
                {
                    var result = MessageBox.Show("молодец,но шагов больше чем 24,хотите попробывать еще раз?", "Конец Игры!", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                    else
                    {
                        Close();
                    }
                }
            }
        }
        private bool EndGame()
        {
            return leftPictureBox1.Location.X > emptyPictureBox.Location.X
                && leftPictureBox2.Location.X > emptyPictureBox.Location.X
                && leftPictureBox3.Location.X > emptyPictureBox.Location.X
                && leftPictureBox4.Location.X > emptyPictureBox.Location.X
                && emptyPictureBox.Location.X > rightPictureBox1.Location.X
                && emptyPictureBox.Location.X > rightPictureBox2.Location.X
                && emptyPictureBox.Location.X > rightPictureBox3.Location.X
                && emptyPictureBox.Location.X > rightPictureBox4.Location.X;
        }
        private void GameRulesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Цель игры — расположить лягушек, которые смотрят влево, в левую часть, а остальных - в правую часть за минимальное количество перепрыгиваний.\nПрыгать можно на листок, если он находится рядом или через 1 лягушку");
        }
        private void GameRestartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void LoadSizeForm()
        {
            Width = 1010;
            Height = 300;
            leftPictureBox1.Size = new Size(110, 110);
            leftPictureBox1.Location = new Point(0, 0);

            leftPictureBox2.Size = new Size(110, 110);
            leftPictureBox2.Location = new Point(leftPictureBox1.Location.X + leftPictureBox1.ClientSize.Width, 0);

            leftPictureBox3.Size = new Size(110, 110);
            leftPictureBox3.Location = new Point(leftPictureBox2.Location.X + leftPictureBox2.ClientSize.Width, 0);

            leftPictureBox4.Size = new Size(110, 110);
            leftPictureBox4.Location = new Point(leftPictureBox3.Location.X + leftPictureBox3.ClientSize.Width, 0);

            emptyPictureBox.Size = new Size(110, 110);
            emptyPictureBox.Location = new Point(leftPictureBox4.Location.X + leftPictureBox4.ClientSize.Width, 0);

            rightPictureBox1.Size = new Size(110, 110);
            rightPictureBox1.Location = new Point(emptyPictureBox.Location.X + emptyPictureBox.ClientSize.Width, 0);

            rightPictureBox2.Size = new Size(110, 110);
            rightPictureBox2.Location = new Point(rightPictureBox1.Location.X + rightPictureBox1.ClientSize.Width, 0);

            rightPictureBox3.Size = new Size(110, 110);
            rightPictureBox3.Location = new Point(rightPictureBox2.Location.X + rightPictureBox2.ClientSize.Width, 0);

            rightPictureBox4.Size = new Size(110, 110);
            rightPictureBox4.Location = new Point(rightPictureBox3.Location.X + leftPictureBox1.ClientSize.Width, 0);
        }
    }
}