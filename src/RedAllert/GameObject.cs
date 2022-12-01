using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedAllert
{
    public abstract class GameObject
    {
        protected Form1 Form;
        public int X;
        public int Y;
        public int Width;
        public int Height;

        public GameObject(int x, int y, int width, int height, Form1 form)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Form = form;
            Form.CreateNewObject(this);
        }

        public abstract void Draw(Graphics graphics);
        public abstract void Update();
    }
}
