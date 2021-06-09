﻿using System;

namespace OgreBoulotteurCSharp.OgreBoulotteur.Model.Pawn {
    using OgreBoulotteur.Model.Square;
    class PawnTest : Pawn {
        private static readonly Sprite sprite = new('☺');
        public PawnTest(int x, int y) : base(x, y) {
            this.SetSprite(0, sprite);
            this.SetSprite(1, sprite);
            this.SetSprite(2, sprite);
            this.SetSprite(3, sprite);
        }

        public override void Die() {
            // Nothing
        }

        public override void Live() {
            int newX = X;
            int newY = Y;
            switch (this.GetRandomDirection()) {
                case 0:
                    newY = Y == 0 ? 0 : Y - 1;
                    break;
                case 1:
                    newX = X == Forest.Width ? Forest.Width : X + 1;
                    break;
                case 2:
                    newY = Y == Forest.Height ? Forest.Height : Y + 1;
                    break;
                case 3:
                    newX = X == 0 ? 0 : X - 1;
                    break;
            }
            if (Forest.GetSquare(newX, newY).Throughable) {
                X = newX;
                Y = newY;
            }
        }

        private int GetRandomDirection() {
            Random random = new();
            return random.Next(0, 4);
        }
    }
}
