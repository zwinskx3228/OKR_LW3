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

            }
            catch (Exception ex)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
        private void UpdateUI()
        {
            labelTry.Text = $"{_service.AttemptsLeft} attempts left";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
