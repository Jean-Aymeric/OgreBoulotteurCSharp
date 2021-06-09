using System.Collections.Generic;

namespace OgreBoulotteurCSharp.OgreBoulotteur.Model {
    using OgreBoulotteur.Model.Pawn;
    using OgreBoulotteur.Model.Square;
    class Model : IModel {
        private IForest Forest { get; set; }

        public int Height { get { return Forest.Height; } }
        public int Width { get { return Forest.Width; } }

        public Model() {
            Forest = new Forest(15, 59, 10);
        }

        public ISquare GetSquare(int x, int y) {
            return Forest.GetSquare(x, y);
        }

        public List<IPawn> GetPawn(int x, int y) {
            return Forest.GetPawn(x, y);
        }

        public void Live() {
            LivePawns();
        }

        public void LivePawns() {
            Forest.LivePawns();
        }

        public void AddPawn(IPawn pawn) {
            Forest.AddPawn(pawn);
        }
    }
}
