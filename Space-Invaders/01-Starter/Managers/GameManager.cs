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
    public static class GameManager
    {
        private static Player _player = null!;
        private static List<Bullet> _bullets = null!;
        private static List<Enemy> _enemies = null!;

        private static GameState _gameState = GameState.Playing;
        private static int _score;
        private static float _elapsedTime;

        public static GameState GameState => _gameState;

        public static void Initialize()
        {
            // AUFGABE-8: Objekte initialisieren
            _player  = new Player();
            _bullets = new List<Bullet>();
            _enemies = new List<Enemy>();
            _score = 0;
            _elapsedTime = 0f;

            // AUFGABE-8a: Gegner-Grid erzeugen (Zeilen x Spalten)
            int startX = ??? /* 100 */, startY = ??? /* 100 */;
            int dx = ??? /* 60 */, dy = ??? /* 40 */;

            for (int row = 0; row < ??? /* Constants.ENEMY_ROWS */; row++)
            {
                for (int col = 0; col < ??? /* Constants.ENEMY_COLUMNS */; col++)
                {
                    var enemy = new Enemy(new Vector2D(startX + col * dx, startY + row * dy));
                    _enemies.Add(enemy);
                }
            }
        }

        public static void RestartGame()
        {
            Initialize();
            _gameState = GameState.Playing;
        }

        public static void AddScore()
        {
            // AUFGABE-8b: Einfaches Punktesystem
            int points = (int)(1000 / (_elapsedTime + 0.001f));
            _score += ??? /* Math.Max(points, 10) */;
            _elapsedTime = ??? /* 0f */;
        }

        public static void SetGameState(GameState state) => _gameState = state;

        public static void Update()
        {
            InputManager.HandleInput(_player, _bullets);

            if (_gameState == GameState.Playing)
            {
                _player.Update();

                bool changeDirection = false;
                foreach (var e in _enemies)
                {
                    e.Update();
                    if (e.Position.X >= Constants.WINDOW_WIDTH - e.Size.X/2 ||
                        e.Position.X <= e.Size.X/2)
                    {
                        changeDirection = true;
                    }
                }

                if (changeDirection)
                {
                    foreach (var e in _enemies) e.SwitchDirection();
                }

                foreach (var b in _bullets) b.Update();

                CollisionManager.HandleCollisions(_player, _enemies, _bullets);

                if (??? /* _enemies.Count == 0 */) _gameState = ??? /* GameState.Won */;

                _elapsedTime += Raylib.GetFrameTime();
            }
        }

        public static void Draw()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.Black);

            if (_gameState == GameState.Playing)
            {
                Raylib.DrawText($"Score: {_score}", 10, 10, 20, Color.RayWhite);
                _player.Draw();
                foreach (var b in _bullets) b.Draw();
                foreach (var e in _enemies) e.Draw();
            }
            else
            {
                // AUFGABE-8c: Endscreen zeichnen (You Win/You Lose + Restart-Hinweis + Final Score)
                // Als einfache Variante reicht auch ein Text:
                Raylib.DrawText(??? /* "Game Over – Press Enter" */, 200, 280, 20, Color.Red);
            }

            Raylib.EndDrawing();
        }
    }
}
