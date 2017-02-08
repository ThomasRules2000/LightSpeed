# LightSpeed
Space Age Rogue Runner for OCR A-Level Computing Programming Project

Music by [Eric Skiff](http://ericskiff.com/music/), licenced under a Creative Commons Attribution Licence

## To-Do:
- Main Menu with Buttons
- Create Ship
  - Larger ships are slower
    - LightSpeed charges slower
	- Less evasion
  - Ships have certain amounts of points to spend at start
    - Can be upgraded to change shape at shops (shipyard?)
  - Ship is 2D array of Tiles
  - Tile Class
    - Attributes for O2 (float), bools for others (isCracked, isWalkable etc.)
  - RoomBase Class
    - Marks Tiles it Uses
	- Marks centre to render icon
	- Certain Rooms have specific size requirements
	- All room classes inherit off this base class
	
- Create Entities
  - EntityBase Class
    - Attributes: health (float), maxHealth (float), team (int), bools: fireDamage, lowO2Damage, etc.
	  - Teams are player and enemy (leaves room for mp expansion with more than one player later)
	- All players and enemies inherit off this class
	  - Includes different species with different stats/abilities
	  
- Weapons/Drones
  - WeaponBase Class 
    - Attributes: power (int), isEnabled (bool), shots (int), damagePerShot (int), usesMissile (bool)
	- All Weapons inherit this class
  - DroneBase Class
    - Similar to WeaponBase, but for drones
	- All Drone Weapons inherit this class
	
- Abilities
  - Active cost resources to use
  - Active abilities require charging using power for certain amount of time
  - Passive abilities are less powerful, but don't require charging
    - Provide buffs to player/enemies
  - Take up space in ship
	
- AI
  - Use A* Algorithm for entity pathfinding between rooms
  - Select what to repair based on priorities
    - Change depending on situation
	  - If whole room is on fire, avoid it
	  - If trying to escape, prioritise engines/helm + keep helm manned
	  - Default priorities are O2 first if any crew requires it & low, followed by weapons/shields
  - Crew is selected based on time & dist
    - Minimise damage*fixTime + speed*distance
	- Best crew mans each station
	  - If conflict (one person best at 2 things), order is helm, weapons, engine, shields, other
	
- Warp Nodes
  - Map for LightSpeed Travel
  - Randomly generate connected graph and plot nodes on map
 
- Events
  - When travelling to a node, an event can occur
  - Types
    - Encounter - Enemy ship to fight
	- Empty - Nothing happens - flavour text
	- Shop - marked on map, can buy & sell items
	- Distress - marked with beacon on map, can be trap, often civilian trapped
	- Special - special events that cause things to happen other than default
	  - Events can have multiple outcomes depending on choices

- Saves
  - Save achievement data & hi scores to file, & overwrite but keep on disk
    - Also save stats e.g. total playthroughs etc.
  - Save games are deleted when loading, recreated when saving
    - Prevents cheating by reloading old saves