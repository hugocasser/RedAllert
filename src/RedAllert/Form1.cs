namespace RedAllert
{
    public partial class Form1 : Form
    {
        private List<GameObject> _gameObjects  = new List<GameObject>();

        public Form1()
        {
            InitializeComponent();
        }
        private void Start(object sender, EventArgs e)
        {
            var world = new World(3,3,0,0,this);
            new Bob(4, 6, 32, 32, this,world);
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

            pictureBox1.Invalidate();

            new DebufWindow("я тебя люблю");
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