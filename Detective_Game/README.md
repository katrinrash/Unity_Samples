# Detective Game (Do You Trust Them?)

This folder contains several key gameplay scripts from a detective-style 3D puzzle game.  
It includes day management logic using the **Observer Design Pattern** and a complete set of scripts for a **Code Sequence Mini-Game** inspired by Cyberpunk.

---

### 🕓 1. Day Management System
The **DaysManager** script controls day transitions and notifies other systems about the change of day through an event system based on the **Observer Pattern**.  
This allows various game components to react dynamically depending on the day.

**Key features:**
- Event-driven architecture using the Observer Pattern  
- Centralized control over day cycles  
- Automatic synchronization of day-based gameplay elements

---

### 🧩 2. Code Sequence Mini-Game
A set of scripts responsible for generating and managing the code-sequence mini-game.
The system handles grid creation, random code generation, input validation, and enforces gameplay rules when the player enters the combination.

**Key features:**
- Dynamic grid generation  
- Random code sequence creation  
- Validation logic based on target sequence  
- Input rules and restrictions for combination entry  
- Modular design for easy balancing and extension


