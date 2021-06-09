namespace OgreBoulotteurCSharp.OgreBoulotteur.Model.Square {
    abstract class Square : ISquare {
        public ISprite Sprite { get; private set; }
        private readonly ISprite[] sprites;

        public bool Throughable { get; private set; }

        protected Square(bool throughable) {
            Throughable = throughable;
            this.sprites = new ISprite[4];
        }

        public ISprite GetSprite(int num) {
            return this.sprites[num];
        }

        public void SetSprite(int num, ISprite sprite) {
            this.sprites[num] = sprite;
        }
    }
}
