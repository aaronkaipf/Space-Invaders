# Space-Invaders — **01-Starter**

Dieses Projekt ist ein **bewusst unvollständiges** Starter-Gerüst.
Es enthält **`???`-Platzhalter** und **kommentierte AUFGABEN**, die Schritt für Schritt erklären, **was** wo einzusetzen ist und **warum**.

> **Wichtig:** Der Starter **kompiliert absichtlich nicht**, bis alle Pflicht-Stellen ausgefüllt sind.

---

## 🚀 Ziel

* ZIP von GitHub laden, entpacken, in VS Code öffnen
* `AUFGABE-x` Kommentare lesen, `???` gezielt ersetzen
* Projekt anschließend **bauen & starten**

---

## 📥 Projekt als ZIP herunterladen

1. GitHub öffnen: `https://github.com/aaronkaipf/Space-Invaders`
2. **Grüner Button „Code“ → „Download ZIP“**
3. ZIP entpacken (Windows: „Alle extrahieren…“ · macOS: „Entpacken“)
4. **Im entpackten Ordner** weiterarbeiten (nicht in der ZIP).

---

## 🧰 In VS Code öffnen

**Variante A (empfohlen)**

1. VS Code starten
2. **Datei → Ordner öffnen…**
3. Den entpackten Projektordner auswählen (mit **`01-Starter/`**)
4. Evtl. **„Trust the authors?“ → Trust**

**Variante B**
Rechtsklick auf den Ordner → **„Mit Code öffnen“**

---

## 🗂️ Ordnerstruktur (nur Starter)

```
Space-Invaders/
└─ 01-Starter/
   ├─ SpaceInvaders.csproj        # C# Projektdatei (.NET)
   ├─ Game.cs                     # Program/Loop Einstieg (ruft GameManager auf)
   ├─ Utils/
   │  ├─ Constants.cs             # Konstanten (Größen/Geschwindigkeiten)
   │  ├─ GameState.cs             # Spielzustand (Playing/Won/Lost)
   │  └─ Vector2D.cs              # 2D-Vektor mit Operatoren (AUFGABE)
   ├─ GameObjects/
   │  ├─ GameObject.cs            # Basisklasse + AABB-Kollision (AUFGABE)
   │  ├─ Player.cs                # Spieler (AUFGABE)
   │  ├─ Bullet.cs                # Projektil (AUFGABE)
   │  └─ Enemy.cs                 # Gegner (AUFGABE)
   └─ Managers/
      ├─ InputManager.cs          # Tastatur-Input (AUFGABE)
      ├─ CollisionManager.cs      # Kollisionen & Aufräumen (AUFGABE)
      └─ GameManager.cs           # Init/Update/Draw, Gegner-Grid, Score (AUFGABE)
```

> In allen Dateien findest du **`// AUFGABE-x:`** Kommentare und **`???`** als Platzhalter.

---

## 🧭 So arbeitest du richtig (Reihenfolge)

1. **`Utils/Vector2D.cs`**
   – Ersetze `???` in den Operatoren **`+`**, **`-`**, **`*`** (komponentenweise rechnen).
2. **`GameObjects/Player.cs`**
   – Konstruktor-Parameter (Startposition/Größe/Farbe), `MoveLeft/Right`, **Clamp** in `Update()`, `Shoot()`.
3. **`GameObjects/Bullet.cs`**
   – Größe/Farbe, Bewegung **hoch/runter**, außerhalb des Fensters **deaktivieren**.
4. **`GameObjects/Enemy.cs`**
   – Größe/Farbe, horizontale Bewegung, `SwitchDirection()` mit Drop.
5. **`Managers/InputManager.cs`**
   – Tasten: **Left/Right/Space**, **Enter** für Neustart bei Win/Lose.
6. **`Managers/CollisionManager.cs`**
   – Bullet ↔ Enemy, Entfernen inaktiver Objekte, Lose-Bedingungen.
7. **`Managers/GameManager.cs`**
   – Gegner-Grid (Zeilen/Spalten, Abstände), Score-Formel, Win/Endscreen-Text.

---

## ▶️ Bauen & Starten (wenn `???` ersetzt sind)

Im VS-Code-Terminal (Ordner `01-Starter/`):

```bash
dotnet restore
dotnet build
dotnet run
```

**Steuerung:** ←/→ bewegen · **Leertaste** schießen · **Enter** Neustart (nach Win/Lose)

---

## 🆘 Häufige Probleme

* **„Befehl `dotnet` nicht gefunden“**
  → .NET SDK installieren, VS Code neu starten.

* **Build-Fehler mit `???`**
  → Es sind noch Stellen **nicht ersetzt**.
  Suche nach `???` oder `AUFGABE`:

* VS Code: **Strg/Cmd + Shift + F** → nach `???` suchen.

* **raylib fehlt (macOS)**
  → `brew install raylib`

* **Falscher Ordner**
  → Stelle sicher, dass du **im Ordner `01-Starter/`** bist (dort liegt die `.csproj`).

---

## ✅ Done-Check (Minimalziel)

Wenn alles korrekt ist, solltest du:

* den **Player** bewegen (←/→)
* **schießen** (Space), Bullets verschwinden oben
* **Gegner** sehen, die an den Rändern die Richtung wechseln und „droppen“
* **Treffer** entfernen Gegner & geben **Punkte**
* **Win**, wenn alle Gegner weg sind · **Lose**, wenn Gegner unten ankommen oder dich berühren
* **Enter** startet neu

---

**Viel Erfolg & Spaß beim Coden! 👾🎮**
