//This is for educational purpose only. Not intended for professional use.

This project is a mobile game developed in Unity, featuring a two-player setup on the same device. The game involves simple touch-based controls, with the player characters navigating through obstacles, likely reminiscent of games like *Flappy Bird*. Here's a breakdown of the main components:

- Player Control (Player.cs): The player can control their character using taps or touch inputs. The character responds to gravity and can "jump" with each input, allowing the player to navigate through obstacles. Sprite animation enhances the visual feedback of the character's actions.

- Obstacle and Pipe Management (Pipes.cs & PipeSpawner.cs): Pipes, which act as obstacles, are spawned at intervals and move from right to left. When they exit the screen, they are destroyed. The `PipeSpawner.cs` script handles the random spawning of these pipes at different heights to increase the game's challenge.

- Game Management (GameManager.cs): The `GameManager` script oversees core functionalities like starting, pausing, and ending the game. It tracks the player's score, updates the best score, and manages the user interface elements like the play button and game over screen. Additionally, it integrates sound effects to enhance the user experience.

- Visuals (Parallax.cs): The parallax effect creates the illusion of depth by scrolling background elements at different speeds, adding visual interest to the environment.

-Scene Transition (Background.cs): This script handles the transition between scenes based on user touch input. When the screen is tapped, it triggers an asynchronous scene load, allowing for smooth transitions between different parts of the game, such as from a menu to gameplay.