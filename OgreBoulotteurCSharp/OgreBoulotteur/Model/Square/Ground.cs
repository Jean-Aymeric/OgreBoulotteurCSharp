namespace OgreBoulotteurCSharp.OgreBoulotteur.Model.Square {
    class Ground : Square {
        private static readonly Sprite sprite = new(' ');
        public Ground() : base(true) {
            for (int num = 0; num < 4; num++) {
                SetSprite(num, Ground.sprite);
            }
        }
    }
}
