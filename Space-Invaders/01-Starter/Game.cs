// =====================================================
// ⚠️ STARTER (UNFERTIG) – SOLL NICHT KOMPILIEREN!
// Ziel: Schüler ersetzen alle '???' gemäß den Kommentaren.
// Jede Datei enthält nummerierte AUFGABEN mit Hinweisen.
// Wenn alle '???' ersetzt wurden, kompiliert und läuft das Spiel.
// =====================================================

using SpaceInvaders.Managers;
using SpaceInvaders.Utils;
using Raylib_cs;

namespace SpaceInvaders
{
    public static class Game
    {
        public static void Main()
        {
            // AUFGABE-0: Prüfe WINDOW_WIDTH/HEIGHT in Constants.cs
            Raylib.InitWindow(Constants.WINDOW_WIDTH, Constants.WINDOW_HEIGHT, "Space Invaders – Starter (Unfertig)");
            Raylib.SetTargetFPS(60);

            GameManager.Initialize(); // AUFGABE: GameManager.Initialize muss implementiert werden

            while (!Raylib.WindowShouldClose())
            {
                GameManager.Update(); // AUFGABE: GameManager.Update muss implementiert werden
                GameManager.Draw();   // AUFGABE: GameManager.Draw muss implementiert werden
            }

            Raylib.CloseWindow();
        }
    }
}
