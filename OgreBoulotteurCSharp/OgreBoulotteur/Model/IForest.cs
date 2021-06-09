using System.Collections.Generic;

namespace OgreBoulotteurCSharp.OgreBoulotteur.Model {
    using OgreBoulotteur.Model.Pawn;
    using OgreBoulotteur.Model.Square;
    public interface IForest {
        int Height { get; }
        int Width { get; }
        ISquare GetSquare(int x, int y);
        List<IPawn> GetPawn(int x, int y);
        void LivePawns();
        void AddPawn(IPawn pawn);
    }
}
