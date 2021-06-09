namespace OgreBoulotteurCSharp.OgreBoulotteur.Model.Square {
    class Sprite : ISprite {
        public char Character { get; set; }

        public Sprite(char character) {
            this.Character = character;
        }
    }
}
