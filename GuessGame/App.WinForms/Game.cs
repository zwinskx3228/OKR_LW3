using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.WinForms
{
    public partial class Game : Form
    {
        private readonly GuessNumberService _service = new GuessNumberService();
        public Game()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            labelTry.BackColor = Color.Transparent;

        }

        private void Game_Load(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void Game_Paint(object sender, PaintEventArgs e)
        {
            Graphics mgraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(167, 199, 231));

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area,
                Color.FromArgb(167, 199, 231),
                Color.FromArgb(129, 133, 137),
                LinearGradientMode.ForwardDiagonal);

            mgraphics.FillRectangle(lgb, area);
            mgraphics.DrawRectangle(pen, area);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int min = (int)numericUpDown2.Value;
            int max = (int)numericUpDown1.Value;

            try
            {
                _service.GenerateNumber(min, max);
                MessageBox.Show("Число згенеровано! Починайте гру.");
                textBox1.Text = "";
                UpdateUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int guess))
            {
                MessageBox.Show("Введіть коректне число!");
                return;
            }

            string result = _service.Guess(guess);

            MessageBox.Show(result);
            textBox1.Text = "";

            if (result == "Ви вгадали! Так тримати!")
            {
                // 🔥 оновити streak
                label6.Text = $"🔥 {_service.WinsCount}";
                label6.ForeColor = Color.Red;

                // ❗ Після вгадування нове число НЕ генерується автоматично
                // Користувач повинен натиснути кнопку Generate
                labelTry.Text = "Press generate!";
                return;
            }

            // ❌ Якщо програш — обнуляємо streak
            if (_service.AttemptsLeft == 0)
            {
                _service.ResetStreak();
                label6.Text = $"🔥 {_service.WinsCount}";
                label6.ForeColor = Color.Black;

                labelTry.Text = "Press generate!";
                return;
            }

            // Звичайне оновлення спроб
            UpdateUI();
        }
        private void UpdateUI()
        {
            labelTry.Text = $"{_service.AttemptsLeft} attempts left";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
