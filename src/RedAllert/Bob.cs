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
        private World _world;


        public Bob(int x, int y, int width, int height, Form1 form, World world) : base(x, y, width, height, form) 
        {
            _world = world;
            world.SetToTile(this);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawImage(Image.FromFile("../../../resources/characters.png"), new Point(X * Width, Y * Height)); 
        }

        public override void Update()
        {

            _world.MoveToNextTile(this);
        }
    }
}
