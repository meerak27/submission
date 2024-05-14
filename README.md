The attached file will likely not work properly as 3 files were too large to push to github. The full project can be found here along with a demo video (.rar was the only way i can compress to upload it) - https://drive.google.com/drive/folders/1g4KBPjxplH9CD2FDnSf6f4tglxhGTaAC 

First Person Shooter (FPS) game

## Points Completed In Game
1) Mountainious terrain along with an urban environment. The environment is closed with cliffs and walls.
2) Two weapons implemented a riffle, pistol along with a melee weapon and a grenade.
3) Life Bar, Armour with differen health and damage ratings. Also applied armour to protect player.
4) Visual UI of both armour and HP along with other details like ammo and gun is also implemented.
5) Locked doors implemented
6) Enemy patrolling the streets has also been implemented, AI shooting at players implemented
7) Sound Effects implemented. Shoot, hurt,jump,fall etc
8) GameOver screen as well as restart when the player dies is also implemented.

## Bonus Point
2) Player can respawn and start over where he left.
3) DeadZones like walls and cliffs are implemented to stop the player from going the area.

## Overview
The game is set in a mountain terrain with a neighborhood that is guarded by two agents. The player's objective is to find a key to open the gates to enter the neighborhood and then eliminate the two agents. The game includes a variety of weapons, including an M4 assault rifle with a holographic scope and laser, a secondary pistol, a melee weapon (baton), and grenades. The player can perform various actions such as movement, leaning, aiming, and interacting with objects using specified keys.
Process and Implementation
This was the first time to create a game such as this, so it required a lot of hard work and effort. There were luckily many tutorials online and I wanted to push myself to try to implement as many elements from the requirement list as possible. I wanted to create something that I would enjoy playing and can allow my younger siblings and cousins to play and enjoy. 
## Controls
Movement: Use the WASD keys to move the player character.
Leaning: Use the Z and C keys to lean left and right, respectively.
Switching Weapons: Use the number keys to switch between the primary weapon (M4 assault rifle), secondary weapon (pistol), and melee weapon (baton).
Aiming: Use the right mouse button to aim down the sights of the currently equipped weapon (M4 assault rifle or pistol).
Shooting: Use the left mouse button to fire the weapon.
Throwing Grenade: Use the G key to throw a grenade.
Interacting: Use the E key to interact with objects such as doors and keys.
## Weapons
M4 Assault Rifle: The primary weapon of the player, equipped with a holographic scope and laser. The player can switch between viewing through the scope and tilting the gun to aim where the laser is pointing.
Pistol: A secondary weapon for the player.
Melee Weapon (Baton): Used for close combat situations.
## Environment
Mountain Terrain: The game is set in a mountainous environment.
Neighborhood: A guarded neighborhood that the player needs to enter by finding a key.
## Gameplay
Objective: Find the key to open the gates to the neighborhood and eliminate the two agents guarding it.
Navigation: Use the WASD keys to move around the environment. Use the Z and C keys to lean left and right, respectively.
Combat: Use the M4 assault rifle, pistol, and melee weapon to engage enemies. Aim down sights for precision shooting.
Interactions: Use the E key to interact with objects such as doors and keys.
Grenades: Use the G key to throw grenades at enemies.
## Enemy Agents
Weapons: The enemy agents are equipped with M4 assault rifles.
Patrolling: The agents patrol the neighborhood using Navmesh agents from the Unity engine.
## Video Demo

Here is a video demo of the game 
* In the video you can check the armour going down as well as the health. I did not change anything in the code. Sometimes the enemy does critical damage, like a headshot therefore the armour doesnt take hits.

![image](https://github.com/meerak27/submission/assets/98391104/904d7be6-ed07-4bdf-8ce7-60bf4be47cfc)
