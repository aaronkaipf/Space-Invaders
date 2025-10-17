// =====================================================
// ⚠️ STARTER (UNFERTIG) – SOLL NICHT KOMPILIEREN!
// Ziel: Schüler ersetzen alle '???' gemäß den Kommentaren.
// Jede Datei enthält nummerierte AUFGABEN mit Hinweisen.
// Wenn alle '???' ersetzt wurden, kompiliert und läuft das Spiel.
// =====================================================

namespace SpaceInvaders.Utils
{
    // AUFGABE-1: Implementiere alle Operatoren exakt wie beschrieben.
    public struct Vector2D
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Vector2D(float x, float y) { X = x; Y = y; }

        // Addition: (ax+bx, ay+by)
        public static Vector2D operator +(Vector2D a, Vector2D b)
        {
            // Ersetze die '???' korrekt.
            return new Vector2D(??? /* a.X + b.X */, ??? /* a.Y + b.Y */);
        }

        // Subtraktion: (ax-bx, ay-by)
        public static Vector2D operator -(Vector2D a, Vector2D b)
        {
            return new Vector2D(??? /* a.X - b.X */, ??? /* a.Y - b.Y */);
        }

        // Skalarmultiplikation: (ax*s, ay*s)
        public static Vector2D operator *(Vector2D a, float s)
        {
            return new Vector2D(??? /* a.X * s */, ??? /* a.Y * s */);
        }
    }
}
