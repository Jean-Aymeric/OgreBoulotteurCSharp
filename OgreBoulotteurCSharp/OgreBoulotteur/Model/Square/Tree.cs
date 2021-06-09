namespace OgreBoulotteurCSharp.OgreBoulotteur.Model.Square {
    class Tree : Square {
        private static readonly Sprite sprite = new('♣');
        public Tree() : base(false) {
            for (int num = 0; num <4; num++) {
                SetSprite(num, Tree.sprite);
            }
        }
    }
}
