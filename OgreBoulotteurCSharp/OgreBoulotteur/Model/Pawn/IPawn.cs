namespace OgreBoulotteurCSharp.OgreBoulotteur.Model.Pawn {
    using OgreBoulotteur.Model.Square;
    using OgreBoulotteur.Model;

    public interface IPawn:ISquare {
        int X { get; }
        int Y { get; }
        public IForest Forest { get; set; }
        void Live();
        void Die();
    }
}
