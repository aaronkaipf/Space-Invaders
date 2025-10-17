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
    // AUFGABE-2: Basisklasse verstehen: Position, Größe, Farbe, Zeichnen
    public abstract class GameObject
    {
        protected Vector2D _position;
        public Vector2D Position => _position;
        public Vector2D Size { get; }
        public Color Color { get; }
        public bool IsActive { get; set; } = true;

        protected GameObject(Vector2D position, Vector2D size, Color color)
        {
            _position = position;
            Size = size;
            Color = color;
        }

        public void Move(Vector2D delta)
        {
            // AUFGABE-2a: Position verändern mit Vektor-Addition
            _position = ??? /* _position + delta */;
        }

        // AABB-Kollision
        public virtual bool CollidesWith(GameObject other)
        {
            // AUFGABE-2b: Ersetze die '???' so, dass die AABB-Prüfung korrekt ist
            return !(
                _position.X + Size.X/2 < ??? /* other.Position.X - other.Size.X/2 */ ||
                _position.X - Size.X/2 > ??? /* other.Position.X + other.Size.X/2 */ ||
                _position.Y + Size.Y/2 < ??? /* other.Position.Y - other.Size.Y/2 */ ||
                _position.Y - Size.Y/2 > ??? /* other.Position.Y + other.Size.Y/2 */
            );
        }

        public virtual void Update() { }

        public virtual void Draw()
        {
            Raylib.DrawRectangle((int)(_position.X - Size.X/2),
                                 (int)(_position.Y - Size.Y/2),
                                 (int)Size.X, (int)Size.Y, Color);
        }
    }
}
