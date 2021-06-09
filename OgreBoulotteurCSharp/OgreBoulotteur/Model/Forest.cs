using System;
using System.Collections.Generic;

namespace OgreBoulotteurCSharp.OgreBoulotteur.Model {
    using OgreBoulotteur.Model.Pawn;
    using OgreBoulotteur.Model.Square;
    class Forest : IForest {
        public int Height { get; private set; }
        public int Width { get; private set; }
        private int density;
        public int Density {
            get => density;
            set {
                if (value < 0 || value > 100) {
                    density = 20;
                } else {
                    density = value;
                }
            }
        }
        private ISquare[,] squares;
        private readonly List<IPawn> pawns;
        private static readonly ISquare tree = new Tree();
        private static readonly ISquare ground = new Ground();

        public Forest(int height, int width, int density) {
            Height = height;
            Width = width;
            Density = density;
            this.pawns = new();
            this.InitializeRandomlySquares();
        }

        private void InitializeRandomlySquares() {
            this.squares = new ISquare[Height, Width];
            for (int y = 0; y < Height; y++) {
                for (int x = 0; x < Width; x++) {
                    ISquare square;
                    if ((x == 0) || (x == (Width - 1)) || (y == 0) || (y == (Height - 1))) {
                        square = Forest.tree;
                    } else {
                        square = this.GetRandomSquare();
                    }
                    this.squares[y, x] = square;
                }
            }
        }

        private ISquare GetRandomSquare() {
            Random random = new();
            if (random.Next(0, 100) < Density) {
                return Forest.tree;
            }
            return Forest.ground;
        }

        public ISquare GetSquare(int x, int y) {
            if (x < Width && y < Height) {
                return this.squares[y, x];
            }
            return null;
        }

        public List<IPawn> GetPawn(int x, int y) {
            List<IPawn> result = new();

            foreach (IPawn pawn in this.pawns) {
                if (pawn.X == x && pawn.Y == y) {
                    result.Add(pawn);
                }
            }
            return result;
        }

        public void LivePawns() {
            foreach (IPawn pawn in this.pawns) {
                pawn.Live();
            }
        }

        public void AddPawn(IPawn pawn) {
            this.pawns.Add(pawn);
            pawn.Forest = this;
        }
    }
}
