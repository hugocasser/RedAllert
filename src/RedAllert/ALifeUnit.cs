namespace RedAllert
{

    public abstract class ALifeUnit : GameObject
    {
        public string Name { get; set; }
        internal int Health { get; set; }
        internal int Attack { get; set; }

        public ALifeUnit(int x, int y, int width, int height, Form1 form, int health, int attack, string name) : base(x, y, width,
            height, form)
        {
            Health = health;
            Attack = attack;
            Name = name;
        }

        public abstract void BattleDraw(Graphics graphics);
    }
}