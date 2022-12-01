using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedAllert
{
    public partial class BattleWindow : Form
    {

        private Random _random = new Random();

        private GameObject _player;
        private GameObject _enemy;

        public BattleWindow()
        {
            InitializeComponent();
            //_player = player;
            // _enemy = enemy;

            label1.Text = $"Здоровьешко ";
            label2.Text = $"Здоровьешко ";


            pictureBox1.Invalidate();
            Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Draw(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;
            // _player.Draw(graphics);
            // _enemy.Draw(graphics);
        }

        /// <summary>
        /// stone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            var ratChoose = _random.Next(0,3);
            switch (ratChoose) {
                case 0:
                    new DebufWindow("Ничья!");
                    break;
                case 1:
                    new DebufWindow("Победа! Вы наносите Мише 15 ед. урона");
                    break;
                case 2:
                    new DebufWindow("Поражение! Миша наносит вам 15 ед. урона");
                    break;
            }
        }

        /// <summary>
        /// nojnica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            var ratChoose = _random.Next(0, 3);
            switch (ratChoose)
            {
                case 0:
                    new DebufWindow("Поражение! Миша наносит вам 15 ед. урона");
                    break;
                case 1:
                    new DebufWindow("Ничья!");
                    break;
                case 2:
                    new DebufWindow("Победа! Вы наносите Мише 15 ед. урона");
                    break;
            }

        }

        /// <summary>
        /// paper
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            var ratChoose = _random.Next(0, 3);
            switch (ratChoose)
            {
                case 0:
                    new DebufWindow("Победа! Вы наносите Мише 15 ед. урона");
                    break;
                case 1:
                    new DebufWindow("Поражение! Миша наносит вам 15 ед. урона");
                    break;
                case 2:
                    new DebufWindow("Ничья!");
                    break;
            }

            // if(rat.health < 0) 
            // if(player.health < 0 ) 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
