# RPG UI Systems Demo

[![Unity Version](https://img.shields.io/badge/Unity-6000.0+-black.svg?logo=unity)](https://unity.com/en/releases/editor/archive)
![Status](https://img.shields.io/badge/Status-In%20Active%20Development-orange)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://github.com/LLarean/rpg-ui-mvvm-demo/blob/main/LICENSE)

A practical demonstration of modern, optimized UI architecture in Unity, featuring a classic RPG inventory and equipment system.

## Project Goals

This prototype serves as a hands-on exploration of key UI development concepts:

1.  **MVVM Architecture:** Implementing the Model-View-ViewModel pattern for clean, testable, and scalable UI code.
2.  **Reactive Programming:** Utilizing the **[R3 (Reactive Rewritten)](https://github.com/Cysharp/R3)** library for declarative and efficient state management.
3.  **UI Optimization:**
    *   Custom `ScrollView` with object pooling.
    *   Minimizing allocations and GC pressure.
    *   Efficient rebinding and UI updates.
4.  **Interactive Elements:** Implementing a Drag & Drop system for equipping items.
5. "Input System:" Implementing navigation and control for both mouse and gamepad.

## Implementation Plan

-   [ ] **Project Setup & Core Architecture**
    -   [ ] Integrate R3 UniRx.
    -   [ ] Create base `Model`, `ViewModel`, `View` classes.
    -   [ ] Set up a basic data binding system.

-   [ ] **Data Models**
    -   [ ] `ItemModel`: Data structure for inventory items (ID, name, icon, type, stats).
    -   [ ] `PlayerModel`: Data structure for player state (equipment, base stats, calculated stats).

-   [ ] **ViewModels (Core Logic)**
    -   [ ] `InventoryViewModel`: Manage a reactive collection of items.
    -   [ ] `EquipmentViewModel`: Manage equipped items per slot.
    -   [ ] `StatsPanelViewModel`: Reactively calculate final player stats.

-   [ ] **Inventory View & Optimization**
    -   [ ] Create a custom `ScrollRect` with object pooling.
    -   [ ] `InventoryItemView`: Prefab bound to an `ItemViewModel`.
    -   [ ] Implement the pooling mechanism for optimal performance.

-   [ ] **Drag & Drop System**
    -   [ ] Begin drag handling on `InventoryItemView`.
    -   [ ] Visual feedback for dragged item.
    -   [ ] Drop zone handling on `EquipmentSlotView`.
    -   [ ] Validation logic for equipment slots.

-   [ ] **Equipment & Stats UI**
    -   [ ] `EquipmentSlotView`: Prefab bound to the `EquipmentViewModel`.
    -   [ ] `StatsPanelView`: UI component bound to the `StatsPanelViewModel`.

-   [ ] **Navigation & Polish**
    -   [ ] Add a simple secondary screen (e.g., a menu).
    -   [ ] Implement a navigation service between screens.
    -   [ ] Final testing, profiling, and preparation of talking points.

## Tech Stack

*   **Unity:** 6000.0 LTS or newer.
*   **Architecture:** MVVM Pattern.
*   **Reactive Framework:** [R3 (UniRx)](https://github.com/Cysharp/R3).
*   **UI System:** Unity uGUI.

## License

This project is licensed under the MIT License - see the [LICENSE.md](https://github.com/LLarean/rpg-ui-mvvm-demo/blob/main/LICENSE) file for details.
