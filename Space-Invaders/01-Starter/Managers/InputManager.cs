// =====================================================
// ⚠️ STARTER (UNFERTIG) – SOLL NICHT KOMPILIEREN!
// Ziel: Schüler ersetzen alle '???' gemäß den Kommentaren.
// Jede Datei enthält nummerierte AUFGABEN mit Hinweisen.
// Wenn alle '???' ersetzt wurden, kompiliert und läuft das Spiel.
// =====================================================

using Raylib_cs;
using SpaceInvaders.GameObjects;
using SpaceInvaders.Utils;

namespace SpaceInvaders.Managers
{
    public static class InputManager
    {
        public static void HandleInput(Player player, List<Bullet> bullets)
        {
            // AUFGABE-6: Eingaben ergänzen
            if (Raylib.IsKeyDown(??? /* KeyboardKey.Left  */))  player.MoveLeft();
            if (Raylib.IsKeyDown(??? /* KeyboardKey.Right */))  player.MoveRight();
            if (Raylib.IsKeyPressed(??? /* KeyboardKey.Space */)) bullets.Add(player.Shoot());

            if (Raylib.IsKeyPressed(??? /* KeyboardKey.Enter */) &&
               (GameManager.GameState == GameState.Won || GameManager.GameState == GameState.Lost))
            {
                GameManager.RestartGame();
            }
        }
    }
}
