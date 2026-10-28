# Abu Janti – 3D Taxi Driving Game

A single-player 3D taxi driving game built in **Unity** with **C#**. You play as Abu Janti, a taxi driver in a Jordanian-style city, picking up passengers and delivering them to their destinations across three levels.

> Built as the final project for the Game Engine and Scripting course at Al-Hussein Technical University (HTU).

![alt text](image.png)

## Gameplay

- Drive the taxi through the city streets and stop near a waiting passenger to pick them up.
- Follow the laser-guided marker to the passenger's destination.
- Drop the passenger off to earn money, then move on to the next customer.
- Finish all deliveries in a level to unlock the next one. There are 3 levels in total.
- There is no losing condition. The game focuses on driving and finishing deliveries at your own pace.

## Features

- **Taxi physics:** force-based acceleration, braking and steering using Unity's Rigidbody and colliders.
- **Wear and repair:** overusing the speed boost (Shift) wears the taxi down and affects its handling.
- **Passenger NPCs:** animated customers (walk and idle states via the Animator) with proximity-based pickup and drop-off.
- **Game Manager:** tracks each customer's delivery state and handles level progression.
- **Laser destination marker:** points the player toward the current destination.
- **UI:** speedometer, money counter and volume sliders, connected to C# methods through Unity's Event System.
- **Audio:** sound sources on the taxi, customers and environment, plus a horn.

## Controls

| Key | Action |
|-----|--------|
| W / A / S / D | Drive the taxi (forward, left, reverse, right) |
| Shift | Speed boost (overuse damages the taxi) |
| `/` | Make the customer walk to the taxi |
| `.` | Make the passenger walk to the destination |

## Project structure

```
Assets/
├── Scripts/     # All gameplay code (C#)
└── Scenes/      # Game scenes
Packages/
ProjectSettings/
```

Main scripts in `Assets/Scripts`:

- `Taxicontroller.cs` – taxi movement and driving behavior
- `CharacterMovement.cs`, `Animationcontroller.cs` – passenger movement and animation
- `CustomerCollition.cs`, `CapsuleCollision.cs` – proximity and collision detection
- `Delivering.cs`, `Deliveringlevel2.cs`, `Deliveringlevel3.cs` – delivery logic per level
- `DestinationManager.cs` – destination markers and tracking
- `Finished.cs` – level completion
- `camerapos.cs` – follow camera
- `Honk.cs` – horn

## Tech stack

- Unity (version: **add your Unity version here**)
- C#
- Blender (used to fix the pivot point of the imported taxi model)

## Running the project

This repository contains the **code, scenes and project settings only**. The third-party art assets are not included because their licenses do not allow redistribution.

To run it locally:

1. Clone this repository and open it with the Unity version listed above.
2. Download the assets listed under **Credits** and import them into the `Assets` folder.
3. Open a scene from `Assets/Scenes` and press Play.

## Credits

The following third-party assets were used and are **not** included in this repository:

- **POLYGON city pack** – city environment
- **ARCADE – FREE Racing Car** – taxi model
- Character models and animations: *add the source here*
- Music and sound effects: *add the source here*
- **TextMesh Pro** – Unity package

All gameplay code, systems and UI logic in `Assets/Scripts` were written by me.

## Author

**Abdallah Hamdan**
[GitHub](https://github.com/Abdallahhamdan187) · [LinkedIn](https://www.linkedin.com/in/abdallah--hamdan/)