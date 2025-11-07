# Card System

This folder contains several key scripts responsible for card validation and player card spawning logic in a card-based game.

### 🧩 1. Card Validation
Implements card validation logic using the **Template Design Pattern(Behavioral)**.  
Each validation step follows a defined template, allowing easy extension or modification of specific validation rules without changing the base algorithm.

**Key features:**
- Template Pattern for modular validation
- Support for flexible card rule definitions
- Clean and scalable architecture for gameplay logic

### 🃏 2. Player Card Spawner
Handles retrieving card objects from the Object Pool and positioning them correctly in the player’s “hand”.
The script dynamically calculates card placement and spacing based on the number of cards, ensuring both efficiency and a visually balanced layout.

**Key features:**
- Dynamic card positioning using calculations
- Automatic spacing 
- Supports object pooling 


