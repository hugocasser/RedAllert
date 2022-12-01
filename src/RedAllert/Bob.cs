
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

        public override void BattleDraw(Graphics graphics)
        {
            graphics.DrawImage(Sprite, X * Width, Y * Height);
        }

        public override void Update()
        {
            _world.MoveToNextTile(this);
            var random = new Random();
            var cube = random.Next(1, 6);
            switch (cube)
            {
                case 1:
                    if (Attack > 0)
                    {
                        Attack -= 1;
                        new DebufWindow("О нет... Вы нашли бутылочку пива. Ваша атака понижается на 1 ед.");
                    }
                    break;
                case 2:
                    Attack += 1;
                    new DebufWindow("О да... Вы нашли бутылочку пива. Ваша атака повышается на 1 ед.");
                    break;
                case 3:
                    Health += 1;
                    new DebufWindow("О да... У вас в трусах новичок. Ваше здоровье повышается на 1 ед.");
                    break;
                case 4:
                    if (Health > 1)
                    {
                        Health -= 1;
                        new DebufWindow("О нет... У вас в трусах новичок. Ваше здоровье падает на 1 ед.");
                    }
                    break;
                case 5:
                    if ((Health == 1 && this.Attack < 2) || (this.Health < 4 && this.Attack == 0))
                    {
                        Health = 1;
                        Attack = 10;
                        new DebufWindow("ОООООООООООООООООООООО Вы выпили бутылочку водочки.");
                    }
                    break;
                case 6:
                    new BattleWindow();
                    break;
                
            }
        }
    }
}
