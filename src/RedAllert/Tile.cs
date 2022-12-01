using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedAllert
{
    public class Tile : GameObject
    {
        private SolidBrush _gameObjectSolidBrush;

        public Tile(int x, int y, int width, int height, Form1 form) : base(x, y, width, height, form) 
        {
            _gameObjectSolidBrush = new SolidBrush(Color.Gray);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillRectangle(_gameObjectSolidBrush, new Rectangle(X * Width, Y * Height, Width, Height));
        }

        public override void Update() {}
    }
}
