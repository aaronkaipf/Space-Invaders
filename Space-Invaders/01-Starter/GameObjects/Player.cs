// =====================================================
// ⚠️ STARTER (UNFERTIG) – SOLL NICHT KOMPILIEREN!
// Ziel: Schüler ersetzen alle '???' gemäß den Kommentaren.
// Jede Datei enthält nummerierte AUFGABEN mit Hinweisen.
// Wenn alle '???' ersetzt wurden, kompiliert und läuft das Spiel.
// =====================================================

using Raylib_cs;
using SpaceInvaders.Utils;

namespace SpaceInvaders.GameObjects
{
    public class Player : GameObject
    {
        // AUFGABE-3: Setze Startposition unten mittig korrekt
        public Player() : base(new Vector2D(??? /* Constants.WINDOW_WIDTH/2f */, ??? /* Constants.WINDOW_HEIGHT-50 */),
                               ??? /* Constants.PLAYER_SIZE */, ??? /* Color.Blue */) {}

        public void MoveLeft()  => Move(new Vector2D(??? /* -Constants.PLAYER_SPEED */, 0));
        public void MoveRight() => Move(new Vector2D(??? /*  Constants.PLAYER_SPEED */, 0));

        public override void Update()
        {
            // AUFGABE-3a: X-Position clampen (im Fenster halten)
            float minX = ??? /* Size.X / 2 */;
            float maxX = ??? /* Constants.WINDOW_WIDTH - minX */;
            float clampedX = Math.Clamp(_position.X, minX, maxX);
            _position = new Vector2D(clampedX, _position.Y);
        }

        public Bullet Shoot()
        {
            // AUFGABE-3b: Projektil knapp über dem Player spawnen, Spieler-Bullet = true
            return new Bullet(new Vector2D(??? /* _position.X */, ??? /* _position.Y - Size.Y/2 */),
                              ??? /* true */);
        }
    }
}
