# GE2-Assignment
The Battle I will be recreating is the Battle of Antarctica from Stargate SG-1. Here is the scene:
[![IMAGE ALT TEXT HERE](http://img.youtube.com/vi/XKvLHLqPUQc/0.jpg)](https://youtu.be/XKvLHLqPUQc)

Here is my Version: https://youtu.be/W9XPjO8YJ88

## Interim:

Any scenes that take place in cockpits are replaced with the camera following a particular ship in the scene.
The rest of the scene follows the scene as close to the original as possible. Most of the ships in the scene are using pursue and evade behaviours. When the battle moves to space, 
it transitions to a new scene which takes place in space. 

## Final Submission:
### The story

The story follows a basic structure where our hereos arrive to Antartica and are spotted by an Alien force. The enemy sends some fighters to destory our hereos, at the last moment
help arrives for our hereos. A battle over antartica then occurs while our hereos travel to the surface to activate a super weapon. The main captial ship of the humans then goes 
to distract the Alien force while our hereos activate the weapon. We then move to space where the super weapon from our hereos destroys all the invading forces. 

### The Behaviours

There is a number of behaviours used in the scenes. The follow path behaviour is used most often, it allows for the most predictable movements and is reserved for when 
transitioning from each part of the story. 
The next behaviours used are the obstacle avoidance behaviours. These are used on the enemy ships only. The human ships use the follow path behaviour and are on the obstacle 
layer so the enemy ships know to avoid them. This is used during the clash of the two armies, it allows for a more organic movement of the ships when they come close rather than 
perfectly flying through each other. 
When the main battle is taking place there is numerous behaviours being used. The human capital ship and two enemy fighters are using the follow path behaviour while all the 
human fighters are using pursue, flee and follow path behaviours. The rest of the enemy fighters are using pursue, flee and seek behaviours. The fighters in the background are 
chasing each other using these behaviours and firing at each other. Acting like a predator prey simulation. 

### How the Behaviours are Used

A finite state machine is used to transition between each behaviour. It allows the follow path behaviours to work by transitioning bewteen seek and arrive behaviours, it is also 
used in the predator prey simulations, making the fighters search for ammo and then pursue their enemy.

### The Art

The models are from sketchFab. They were imported into an empty scene in Unity where materials were applied to them and then these were scaled to reflect the proper porportions 
of the show. The models were then saved as a child of a parent object and these were saved as prefabs. 
The enviroment of Antartica is procedurally generated using techniques from the previous semester. 
The skybox of the space enviroment was made in Photoshop and imported into Unity as PNG. This was then turned into a skybox and applied to the scene. 


### The Weapons

There is 4 different types of weapons in the scenes. Human super weapon and missles, alien super weapon and lasers. 
The missles are a simple missle projectile that is instantiated and a force is applied to it to make it move. A trail renderer is added to this to produce a smoke effect. Upon 
impact with any objects in the scene the missle will explode, the explosion is a particle system with the default unity particle. The particles are emitted in a sphere around the 
area, as they expand their velocity reduces and colour changes to show them interacting with friction in the air and start to fissle out. All explosions in the scene use this 
particle effect except in some cases where the material is changed to a yellow emissisve material that gives off more of a fire explosion. 
This yellow emissive material is used for all projectiles in the scene.
The lasers from the enemy fighters work much the same as the missles except they do not have a trail renderer on them. 
The enemy super weapon is again much the same, except much bigger. The enemy super weapon also has a different fire rate to the rest of the weapons and it is specifically targeted 
at the human capital ship. The super weapon bullets hit away from the human captial ship to show its shield being used.
The human super weapon is a particle system, it uses the same yellow emissive material. This particle system emits in the shape of a cylinder to form like how it is in the show. 
The lifetime of the particles is high to allow it to travel far distances. When it reaches the enemy ships it triggers the yellow explosions. 

### Post-Processing 

A bloom effect is added to all the cameras in the scene. A post-processing volume is held on a gameobject in its own layer so that it does not affect performance too much.

### Cameras

The camera transitions are done using triggers in the scene when certain ships collide with them as they fly along their paths. One of the cameras is set as a physical camera so 
that a zoom could be used. The zoom triggers when a targeted object leaves a large collider around the camera.

