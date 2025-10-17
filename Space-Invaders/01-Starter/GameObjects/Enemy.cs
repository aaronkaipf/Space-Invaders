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
    public class Enemy : GameObject
    {
        private float _direction = 1.0f; // 1=rechts, -1=links

        public Enemy(Vector2D position) : base(position, ??? /* Constants.ENEMY_SIZE */, ??? /* Color.Red */) {}

        public override void Update()
        {
            // AUFGABE-5: horizontale Bewegung
            Move(new Vector2D(??? /* Constants.ENEMY_SPEED */ * _direction, 0));
        }

        public void SwitchDirection()
        {
            // AUFGABE-5a: Richtungswechsel + nach unten fallen
            _direction *= ??? /* -1.0f */;
            Move(new Vector2D(0, ??? /* Constants.ENEMY_DROP_DISTANCE */));
        }
    }
}
