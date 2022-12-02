﻿using System.Media;

namespace RedAllert
{
    public partial class Form1 : Form
    {
        private List<GameObject> _gameObjects  = new List<GameObject>();

        private Bob _bob;

        public Form1()
        {
            InitializeComponent();
        }
        private void Start(object sender, EventArgs e)
        {
            var world = new World(3,3,0,0,this);
            _bob = new Bob(4, 6, 32, 32, this,world, 10, 3, "Bob");
            label2.Text = $"Attack / {_bob.Attack}";
            label3.Text = $"Health / {_bob.Health}";
        }

        public void CreateNewObject(GameObject gameObject) => _gameObjects.Add(gameObject);

        /// <summary>
        /// Step Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < _gameObjects.Count; i++)
                _gameObjects[i]?.Update();
            
            //Battle();

            pictureBox1.Invalidate();
            label2.Text = $"Attack / {_bob.Attack}";
            label3.Text = $"Health / {_bob.Health}";

        }
        

        /// <summary>
        /// Draw picturebox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Draw(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;
            for (var i = 0; i < _gameObjects.Count; i++)
                _gameObjects[i]?.Draw(graphics);
        }

    }
}