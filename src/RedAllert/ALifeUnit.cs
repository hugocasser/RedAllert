using System.Media;

namespace RedAllert
{

    public abstract class ALifeUnit : GameObject
    {
        public string Name { get; set; }
        internal int Health { get; set; }
        internal int Attack { get; set; }

        protected List<SoundPlayer> VoiceLines = new List<SoundPlayer>();
        public ALifeUnit(int x, int y, int width, int height, Form1 form, int health, int attack, string name) : base(x, y, width,
            height, form)
        {
            Health = health;
            Attack = attack;
            Name = name;
        }

        public abstract void BattleDraw(Graphics graphics);

        public void PlayRandomVoice()
        {
            var random = new Random().Next(0, VoiceLines.Count);
            VoiceLines[random].Play();
        }
    }
}