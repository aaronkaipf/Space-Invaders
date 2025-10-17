// =====================================================
// ⚠️ STARTER (UNFERTIG) – SOLL NICHT KOMPILIEREN!
// Ziel: Schüler ersetzen alle '???' gemäß den Kommentaren.
// Jede Datei enthält nummerierte AUFGABEN mit Hinweisen.
// Wenn alle '???' ersetzt wurden, kompiliert und läuft das Spiel.
// =====================================================

using SpaceInvaders.GameObjects;
using SpaceInvaders.Utils;

namespace SpaceInvaders.Managers
{
    public static class CollisionManager
    {
        public static void HandleCollisions(Player player, List<Enemy> enemies, List<Bullet> bullets)
        {
            // AUFGABE-7: Bullet vs Enemy -> beide inaktiv + Punkte addieren
            foreach (var b in bullets)
            {
                if (!b.IsActive) continue;
                foreach (var e in enemies)
                {
                    if (!e.IsActive) continue;
                    if (??? /* b.CollidesWith(e) */)
                    {
                        b.IsActive = ??? /* false */;
                        e.IsActive = ??? /* false */;
                        GameManager.AddScore();
                        break;
                    }
                }
            }

            // AUFGABE-7a: Inaktive entfernen
            bullets.RemoveAll(b => ??? /* !b.IsActive */);
            enemies.RemoveAll(e => ??? /* !e.IsActive */);

            // AUFGABE-7b: Enemy berührt Player -> Lost
            foreach (var e in enemies)
            {
                if (e.IsActive && player.IsActive && ??? /* e.CollidesWith(player) */)
                {
                    player.IsActive = ??? /* false */;
                    GameManager.SetGameState(??? /* GameState.Lost */);
                    break;
                }
            }

            // AUFGABE-7c: Enemy erreicht unteren Rand -> Lost
            foreach (var e in enemies)
            {
                if (e.Position.Y + e.Size.Y/2 >= ??? /* Constants.WINDOW_HEIGHT */)
                {
                    GameManager.SetGameState(??? /* GameState.Lost */);
                    break;
                }
            }
        }
    }
}
