<img src="./Images/Baner.gif" width="300" alt="PathweaveUIX" />

# PathweaveUIX

**Powerful and intuitive page navigation system for Unity UI.**

PathweaveUIX makes it easy to create multi-page interfaces with smooth navigation, transition animations, history support, and custom actions — similar to modern mobile and web applications.

[![Unity](https://img.shields.io/badge/Unity-2021.3+-brightgreen.svg)](https://unity.com/)
[![UPM](https://img.shields.io/badge/UPM-Supported-blue.svg)](https://github.com/ModuDevCore/PathweaveUIX-Unity)
[![GitHub releases](https://img.shields.io/github/v/release/ModuDevCore/ElysiumDB-Unity?style=flat-square)](https://github.com/ModuDevCore/PathweaveUIX-Unity/releases)

---

## ✨ Key Features

- ✅ Flexible routing system (`/page1/page2`, hash data support)
- ✅ Smooth animated page transitions
- ✅ Rich navigation API: `SetPage`, `Navigate`, `NavigateBack`, `NavigateWithHash`, etc.
- ✅ Custom actions and events (`PathweaveAction` + `PathweaveEvent`)
- ✅ Convenient editor tools for creating pages and buttons
- ✅ Full Prefab workflow integration
- ✅ Works in both Play Mode and Editor

---

## 📌 Useful Links

| Link                                   | Description                                      |
|----------------------------------------|--------------------------------------------------|
| **[Tutorial](./TUTORIAL.md)**          | Step-by-step guide with examples and screenshots |
| **[API Reference](./REFERENCE.md)**    | Complete public API documentation                |
| **[Technical](./TECHNICAL.md)**        | Internal architecture and extensibility          |

---

## 🚀 Quick Start

### Installation

**Option 1 — OpenUPM** (Recommended)
```bash
openupm add com.modudevcore.pathweaveuix
```

**Option 2 — Git URL**
1. Open `Window → Package Manager`
2. Click `+ → Add package from git URL`
3. Paste:
   ```
   https://github.com/ModuDevCore/PathweaveUIX-Unity.git
   ```

**Option 3 — .unitypackage**  
Download the latest release and import the `.unitypackage`.

---

### Getting Started

1. Create a **Canvas**
2. Add the **`PathweaveUIX`** component to the Canvas
3. Create a folder for pages (`Assets/*/Pages`)
4. Create a new page: `Right Click → Create → Pathweave → New Page`
5. Add pages to the PathweaveUIX manager
6. Use `PathweaveButton` for navigation

Full step-by-step instructions → **[Tutorial.md](./TUTORIAL.md)**

---

## 📚 Documentation

- **[Tutorial](./TUTORIAL.md)** — Step-by-step guide for everyone
- **[API Reference](./REFERENCE.md)** — Full public API documentation
- **[Technical](./TECHNICAL.md)** — For developers and deep understanding

---

## 🛠 Core Components

- `PathweaveUIX` — Main navigation manager
- `PathweavePage` — Single page definition
- `PathweaveButton` — Button with built-in action support
- `PathweaveAction` — Navigation or custom action
- `PathweaveAnimatorEvents` — Animation transition handling

---

## 🤝 Contributing

Contributions are welcome!  
Please read **[TECHNICAL.md](./TECHNICAL.md)** before submitting a Pull Request.

---

## 📄 License

This project is licensed under the **MIT License**.  
See the [LICENSE](LICENSE) file for details.

---

**Made with ❤️ for better Unity UI development**