namespace OgreBoulotteurCSharp.OgreBoulotteur.Controller {
    using OgreBoulotteur.Model;
    using OgreBoulotteur.View;
    using OgreBoulotteur.Model.Pawn;

    public class Controller : IController {
        private IModel Model { get; set; }
        private IView View { get; set; }

        public Controller() {
            Model = new Model();
            View = new View(Model);
            Model.AddPawn(new PawnTest(1, 1));
            Model.AddPawn(new PawnTest(10, 1));
            Model.AddPawn(new PawnTest(12, 1));
            Model.AddPawn(new PawnTest(14, 1));
        }

        public void GameLoop() {
            for (;;) {
                View.Show();
                Model.Live();
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
