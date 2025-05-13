
## 🌀 Scramble (Wish Edition)

**Scramble (Wish Edition)** is a plugin for **SCP: Secret Laboratory**, built using [EXILED](https://gitlab.com/exmod-team/EXILED), which introduces a custom item: the **Scramble Goggles**, represented by a **Coin** (`ItemType.Coin`).

When a player carries this item, they become **immune to being targeted by SCP-096**, even if they look directly at its face.

[![downloads](https://img.shields.io/github/downloads/TheKolo12/Scramble-Wish-Edition-/total?style=for-the-badge&logo=icloud&color=%233A6D8C)](https://github.com/TheKolo12/Scramble-Wish-Edition-/releases/latest)

---

### 🔧 Features

* 🛡️ **SCP-096 immunity** for players holding the Scramble item.
* 🎲 **Configurable spawn system** – define spawn points and chances.
* 🪙 Uses `ItemType.Coin` as the base item.
* ⚡ Lightweight, efficient, and easy to integrate.

---

### ⚙️ Configuration

Spawn locations and chances are fully customizable via the config file. Example:

```yaml
spawn_locations:
  Outside: 30
  LczArmory: 50
  HczTestRoom: 20
```

---

### 💻 Requirements

* **EXILED 9.5.2 or higher**
* A server running a compatible version of SCP\:SL

---

### 📦 Installation

1. Compile the plugin or download the precompiled DLL.
2. Place the `.dll` in your `Exiled/Plugins/` folder.
3. Restart your server.
4. Customize spawn points in your config file.

---


Developed by **Kolo**

