// =====================================================
// ⚠️ STARTER (UNFERTIG) – SOLL NICHT KOMPILIEREN!
// Ziel: Schüler ersetzen alle '???' gemäß den Kommentaren.
// Jede Datei enthält nummerierte AUFGABEN mit Hinweisen.
// Wenn alle '???' ersetzt wurden, kompiliert und läuft das Spiel.
// =====================================================

namespace SpaceInvaders.Utils
{
    public static class Constants
    {
        // Bildschirm
        public const int WINDOW_WIDTH  = 800;
        public const int WINDOW_HEIGHT = 600;

        // Größen & Geschwindigkeiten
        public static readonly Vector2D PLAYER_SIZE = new Vector2D(50, 20);
        public const float PLAYER_SPEED = 5.0f;

        public static readonly Vector2D ENEMY_SIZE = new Vector2D(40, 20);
        public const float ENEMY_SPEED = 2.0f;
        public const float ENEMY_DROP_DISTANCE = 20.0f;
        public const int ENEMY_ROWS = 3;
        public const int ENEMY_COLUMNS = 6;

        public static readonly Vector2D BULLET_SIZE = new Vector2D(5, 10);
        public const float BULLET_SPEED = 8.0f;
    }
}
