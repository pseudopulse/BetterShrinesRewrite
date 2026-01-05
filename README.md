# NOTICE
This mod is not currently maintained by its original author. Report any issues to `pseudopulse` in the Risk of Rain 2 modding discord.

# More Shrines

This mod aims to add new shrines to risk of rain!


**The mod currently adds:**

* Shrine of Imps
	* Spawns tiny imps, if all imps are killed in time the shrine spawns a item.
* Shrine of the Fallen (disabled by default due to SOTS' Shrine of Shaping)
	* Revives a team mate, however you pay for it by reducing your max hp by a percentage for the rest of the stage.
	* The revived player suffers the same fate.
* Shrine of Disorder
	* If you have stacked items this shrine will take those away and replace them with random items.
* Shrine of Heresy
	* When you interact with this shrine it will spawn a random heresy item that you do not currently have.
	* This is meant as a alternative way to become the Heretic
* Shrine of Wisps
	* You can offer a item to this shrine.
	* If it accepts your offer it will spawn ghostly wisp allies which will use that item to fight alongside you.
	* If it rejects your offer it will spawn angry wisps which will use the item to fight you.
	* Each spawned angry wisp has a chance to drop the item you offered when killed.
* Rusty Fusebox
	* Damages you for 80% of your current HP
	* Strikes nearby enemies for 1500% damage, allowing you to escape dangerous situations.
* Totem Pole
	* On use, activates a random equipment.

### Images:

**Shrine of Imps**
  
![Shine of Imps](https://media.giphy.com/media/S8x8nRoQaL761cAwKt/giphy.gif)
  
**Shrine of the Fallen**

![Shrine of the Fallen](https://media.giphy.com/media/Xs0L2YFFcvAFJuk61x/giphy.gif)
  
**Shrine of Disorder**

![Shrine of Disorder](https://media.giphy.com/media/kMk4ltJL18GMW67kZu/giphy.gif)
  
**Shrine of Heresy**

![Shrine of Heresy](https://media.giphy.com/media/HoI1SoRogSJXNKJOXb/giphy.gif)
  
**Shrine of Wisps**

![Shrine of Wisps](https://media.giphy.com/media/Pu3iOyTJl2e2A49nit/giphy.gif)
 
**Rusty Fusebox**
  
![Rusty Fusebox](https://media.giphy.com/media/U0ol3Y14nVzQlWsw1j/giphy.gif)
 
**Totem Pole**
  
![Totem Pole](https://media.giphy.com/media/QATCFrn6ik03EwCESI/giphy.gif)
  

### Patch Notes:
1.5.3
* Fixed incompatibility with Mystic's Items that caused invincibility whenever one of the shrines was present on a stage if Black Monolith was enabled.

1.5.2
* Updated for Alloyed Collective.

1.5.1
* Update README because i forgot something.


1.5.0
* Add Totem Pole (Shrine of Enigma, Suggested by EnderGrimm)
* Fix normals on the new shrines
* Make sure the symbol above the shrines gets properly disabled on use for the host.


1.4.0
* Compatibility patch for the Monolith from Mystic's Items


1.3.4
* Change default Base Imp count from 30 to 5, I forgor 💀


1.3.3
* Added Shrine of Imps options
	* Base Imp Count - The base imp count spawned. This is scaled by (baseImpCount - 1) + (playerCount * runDifficulty)
	* Imp Count Cap - The cap for Base Imp Count scaling. If the base scaling exceeds this value it is set to this value. 
	* [Does not override stage difficulty scaling.]


1.3.2
* Change the spawn flag for Rusty Fusebox (Should fix compatibility issue with BiggerBazaar)


1.3.1
* Add Rusty Fusebox


1.2.1
* Fix some inverted if statements causing enabled shrines to be disabled.


1.2.0
* Fix another potential desync point.
* Add option to spawn at least one Shrine of the Fallen per stage.
* Note that until the next version of BetterAPI this might not work correctly


1.1.9
* Update for Survivors of the Void update and dlc.
* Requires BetterAPI 4.0.0+ or will not work.


1.1.8

* Fix networking for fallen shrine price, it should no longer get desynced if clients or host have different settings.


1.1.7

* Update to new version of better API
* Changed some systems, tell me if anything broke.


1.1.5

* Forgot to patch for networking, no one complained so it might have been a non issue mostly but still.


1.1.4

* Hopefully fix artifact of swarms.


1.1.3

* Fix the weird crash some people were having when launching the game.


1.1.2

* Disable debug mode.
* Possibly fix error that people are having.


1.1.1

* Shrine of Imps should more reliably spawn imps, however can no longer spawn elites.
* Shrine of Wisps should no longer crash the game, but will probably spawn less wisps.


1.1.0

* Added shrine of wisps.
* Fixed Shrine of Imps objective not disappearing after teleporting.
* Fixed some Shrine of Disorder stuff.
* Added option to return Shrine of the Fallen to using money rather than HP penalty.
* I think I fixed some other issues but honestly cannot remember.


1.0.4

* Prevent Shrine of Disorder from rerolling no tier items.


1.0.3

* Fix issues with the Shrine of Imps when using the Dedicated Server.
* Added option to disable Elites for the Shrine of Imps


1.0.2

* Fixed the mod crashing with the thunderstore version of BetterAPI


1.0.1

* Nothing changed, I just messed up the description and thunderstore doesn't let me change it without uploading a new version.


1.0.0

* Rewrote the entire mod and got rid of the R2API dependency, the mod now depends on BetterAPI.
* Added Shrine of Disorder, credit goes to [XoXFaby](https://thunderstore.io/package/XoXFaby/) for the logic behind it.
* Added Shrine of Heresy.

## Installation

* Drop MoreShrines.dll in your plugins folder.
