using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedAllert
{
    public class Bob : GameObject
    {
        private SolidBrush _gameObjectSolidBrush;
        private World _world;


        public Bob(int x, int y, int width, int height, Form1 form, World world) : base(x, y, width, height, form) 
        {
            _gameObjectSolidBrush = new SolidBrush(Color.Blue);
            _world = world;
            world.SetToTile(this);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillRectangle(_gameObjectSolidBrush, new Rectangle(X * Width, Y * Height, Width, Height));
        }

        public override void Update()
        {

            _world.MoveToNextTile(this);
        }
    }
}
