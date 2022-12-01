
namespace RedAllert
{
    public class Bob : ALifeUnit
    {
        public Image Sprite = Image.FromFile("../../../resources/dirt.png");
        public Image SpriteOnBattle;
        private World _world;


        public Bob(int x, int y, int width, int height, Form1 form, World world, int health = 10, int attack = 2, string name = "Bob") :
            base(x, y, width, height, form, health, attack, name)
        {
            _world = world;
            world.SetToTile(this);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawImage(Image.FromFile("../../../resources/characters.png"), new Point(X * Width, Y * Height)); 
        }

        public void DrawOnBattle(Graphics graphics)
        {
        }

        public override void Update()
        {

            _world.MoveToNextTile(this);
            var random = new Random();
            var cube = random.Next(1, 6);
            switch (cube)
            {
                case 1:
                    if (this.Attack > 0)
                        this.Attack -= 1;
                    break;
                case 2:
                    this.Attack += 1;
                    break;
                case 3:
                    this.Health += 1;
                    break;
                case 4:
                    if (this.Health > 1)
                        this.Health -= 1;
                    break;
                case 5:
                    if ((this.Health == 1 && this.Attack < 2) || (this.Health < 4 && this.Attack == 0))
                    {
                        this.Health = 1;
                        this.Attack = 10;
                    }
                    break;
                case 6:
                    
                    break;
                
            }
        }
    }
}
