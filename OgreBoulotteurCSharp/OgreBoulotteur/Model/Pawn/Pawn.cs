namespace OgreBoulotteurCSharp.OgreBoulotteur.Model.Pawn {
    using OgreBoulotteur.Model.Square;
    abstract class Pawn : Square, IPawn {
        public int X { get; protected set; }
        public int Y { get; protected set; }
        public IForest Forest { get; set; } 

        protected Pawn(int x, int y) : base(true){
            X = x;
            Y = y;
            Forest = null;
        }

        public abstract void Live();
        public abstract void Die();
    }
}
