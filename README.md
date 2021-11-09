# Assignment 4_A
# SpaceShips
Play in space as a spaceship - hit with your laser on all asteroids


In this task We created a game for 1 player controlling a spaceship in space.

### Instructions:

Move with the left and right arrow keys.

### Components
**SpaceShip -** Shoot the asteroids that fall from the sky, avoid them.

## Shani Itzhakov

[Source Code.](Shani/)

Play the game on Itch.io:
https://littlegamers2021.itch.io/spaceship-shani


### The Changes I Made: 
1) Added hit points to the player (3 hit points till game over).
2) Original change is dropping a bomb (slower speed and less spawn),
  if the player grabs it - there's a big explosion and all enemies are dead.
### Scripts added:
  [BombHit](Shani/Assets/BombHit.cs)
  
  [EnemyHit](Shani/Assets/EnemyHit.cs)
  
  [RandomBombExplosion](Shani/Assets/RandomBombExplosion.cs)

## Avshalom Avraham

[Source Code.](Avshalom)

Play the game on Itch.io:
https://littlegamers2021.itch.io/spaceships-avshalom

### The Changes I Made: 
1) **Round World -** Added the abilty to move through one side of the screen to the other side.
2) **Special Power -** Kill 10 enemies to get thhe special ability. Follow instructions on the screen. Used to kill all enemies.

### Scripts added:
  **Bomb Explosion -** Spawns explosion animations on random points. [Source Code.](Avshalom/Assets/BombExplosion.cs)
  
  **Flicker -** Makes the special power alert flicker. [Source Code.](Avshalom/Assets/Flicker.cs)
  
  **Locator -** Places the power bar on the edge of the background. [Source Code.](Avshalom/Assets/Locator.cs)
  
  **OutOfBounds -** Let the player "Move throug walls" .[Source Code.](Avshalom/Assets/OutOfBounds.cs)
  
  **PowerCharge -** Triggers 10% power bar fill when destroying an enemy. [Source Code.](Avshalom/Assets/PowerCharge.cs)
  
  **SpecialPower -** Use the special power which kill all enemies. [Source Code.](Avshalom/Assets/SpecialPower.cs)
  <br/>
  
## **Have Fun!**
