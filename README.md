# Space-Invaders (Unterrichtsversion)

Diese README erklärt **Schritt für Schritt**, wie Schülerinnen und Schüler das Projekt **als ZIP von GitHub herunterladen**, **entpacken** und **in VS Code öffnen**.

---

## 🚀 Ziel

* Projekt schnell lokal starten
* In VS Code arbeiten (Code lesen, anpassen, ausführen)
* Keine Vorkenntnisse mit Git erforderlich

---

## ✅ Voraussetzungen (empfohlen)

* **Visual Studio Code**: [https://code.visualstudio.com/](https://code.visualstudio.com/)
* **VS Code Erweiterung für C#** – *C#* (oder *C# Dev Kit*)
* **.NET SDK** (falls C#-Projekt) – [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)

---

## 📥 Projekt als ZIP herunterladen

1. **Zur GitHub-Seite gehen:**
   `https://github.com/aaronkaipf/Space-Invaders`
2. **Grüner Button „Code“ → „Download ZIP“** anklicken.
3. Die Datei **`Space-Invaders-main.zip`** wird heruntergeladen.

---

## 🗃️ ZIP entpacken

1. Öffne den **Downloads**-Ordner (oder den Speicherort, den dein Browser verwendet).
2. **Rechtsklick** auf `Space-Invaders-main.zip` → **„Alle extrahieren…“** (Windows) bzw. **„Entpacken“** (macOS).
3. Nach dem Entpacken entsteht ein Ordner, z. B. **`Space-Invaders-main/`**.

> Wichtig: **Arbeite immer im entpackten Ordner**, nicht in der ZIP.

---

## 🧰 Projekt in VS Code öffnen

**Variante A (empfohlen):**

1. VS Code starten.
2. **Datei → Ordner öffnen…**
3. Den entpackten Ordner **`Space-Invaders-main/`** auswählen.
4. VS Code fragt evtl. nach **„Trust the authors?“** → **Trust** bestätigen.

**Variante B (Schnell per Explorer/Finder):**

1. Rechtsklick auf den entpackten Ordner → **„Mit Code öffnen“** (falls Kontextmenüeintrag vorhanden).

---

## ▶️ Ausführen (typisch für C#/.NET)

Öffne in VS Code die **Terminal-Leiste**: **Terminal → Neues Terminal**. Führe im Projektordner aus:

```bash
dotnet restore
dotnet build
dotnet run
```

---

## 🧭 Ordnerstruktur (Beispiel)

> Kann je nach Version leicht abweichen.

```
Space-Invaders/
├─ src/                  # Quellcode
├─ assets/               # Grafiken/Sounds (falls vorhanden)
├─ README.md             # Diese Anleitung
└─ <Projektdateien>      # z. B. .csproj / solution
```

---

## 🆘 Häufige Probleme & schnelle Lösungen

* **„Befehl 'dotnet' nicht gefunden“**
  → .NET SDK installieren und VS Code neu starten.

* **Projekt startet nicht / Build-Fehler**
  → Im Terminal zuerst `dotnet restore`, dann `dotnet build`.
  → Prüfen, ob du **im richtigen Ordner** bist (dort, wo die `.csproj` liegt).

* **Falscher Ordner geöffnet**
  → Stelle sicher, dass **der entpackte Projektordner** (und nicht der ZIP-Container) geöffnet ist.

---

## 💡 Optional: Mit Git klonen (für Fortgeschrittene)

```bash
git clone https://github.com/aaronkaipf/Space-Invaders.git
cd Space-Invaders
code .
```

---

## Viel Erfolg & viel Spaß beim Coden! 🎮👾
