// =====================================================
// ⚠️ STARTER (UNFERTIG) – SOLL NICHT KOMPILIEREN!
// Ziel: Schüler ersetzen alle '???' gemäß den Kommentaren.
// Jede Datei enthält nummerierte AUFGABEN mit Hinweisen.
// Wenn alle '???' ersetzt wurden, kompiliert und läuft das Spiel.
// =====================================================

using SpaceInvaders.Utils;
using Raylib_cs;

namespace SpaceInvaders.GameObjects
{
    public class Bullet : GameObject
    {
        public bool IsPlayerBullet { get; }

        public Bullet(Vector2D position, bool isPlayerBullet)
            : base(position, ??? /* Constants.BULLET_SIZE */, ??? /* Color.White */)
        {
            IsPlayerBullet = isPlayerBullet;
        }

        public override void Update()
        {
            // AUFGABE-4: Spieler-Bullets nach oben, Gegner-Bullets nach unten bewegen
            float dy = IsPlayerBullet ? ??? /* -Constants.BULLET_SPEED */ : ??? /* Constants.BULLET_SPEED */;
            Move(new Vector2D(0, dy));

            // AUFGABE-4a: Außerhalb des Fensters deaktivieren
            if (??? /* _position.Y < 0 */ || ??? /* _position.Y > Constants.WINDOW_HEIGHT */)
                IsActive = true /* ??? -> false */;
        }
    }
}
