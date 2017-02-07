# LightSpeed
Space Age Rogue Runner for OCR A-Level Computing Programming Project

Music by [Eric Skiff](http://ericskiff.com/music/), licenced under a Creative Commons Attribution Licence

## To-Do:
- Main Menu with Buttons
- Create Ship
  - Tile Class
    - Attributes for O2 (float), bools for others (is cracked etc.)
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

