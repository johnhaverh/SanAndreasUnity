# San Andreas Unity

We're porting [GTA: San Andreas](http://www.rockstargames.com/sanandreas/) to Unity!

This won't be a complete re-implementation of the game, but we're hoping to build something similar to [Multi Theft Auto](http://www.mtasa.com/) with assets streamed from an existing installation of San Andreas.

## Setup Instructions

Before starting the game, create/edit config.user.json inside project folder to specify path to gta.

Also, after building binary, you need to copy 'Data' folder to 'game_name'_Data folder. The script which should do that, doesn't work right now.

## In game controls

V - spawn vehicle

P - change pedestrian model

L shift - run / fly fast

mouse scroll - zoom in/out

Q - toggle debug menu

T - enable debug flying mode

R - enable debug noclip mode

backspace - fly up

delete - fly down

Z - fly very fast

E - Enter/exit vehicles

Space - Jump

F10 - Toggle FPS 

## Here is a list of what I think should be done next

* Animations must be loaded/played by index – because different anim definition groups (man, woman, etc) use different anim names ( walk_civi, woman_walknorm, respectively).

* Weapons. Aiming with weapons – aim animation.

* What else can be imported: ai paths, character spawn info, item pickups, audio, 

* Rigid body character.

* Airplane.

* Load map in editor.

* Async geometry loading.

* Make everything networked.

## TODO

### Features

- Two driving camera modes (aim to front and free look)

- See the entire map (pressing M)

- Dev profiles (for paths) and for the keyboard & mouse controls

- Health, money & armor system

- AI System for Peds

- Peds (and worker peds)

- Cars can be damaged

- Cars & fuel stations can explode

### Effects & Enhancements

* Jump, swim & fall animations

* Water effects (Swim, bouyancy, get darker and blurry the deeper you get)

* Work on props (lampposts, fences, etc)

* Decay system for Weapons

* Burnout trace

* Vehicle damage

* Dust and water particles with vehicles (cars travelling through dirt and boats, respectively)

### Environment

* Daylight cycle

* Weather

### Vehicles

* Enhance car lights, turning, doors and braking

* Gear system (to make cars keep stoped on slopes)

* Boats, airplanes and bikes (+ fall)

### Mods system

* Integrate a mod system that is capable of reading source files and managed compiled assemblies, some exaples of mods:
    - Access to all interiors (without any yellow marker) generating them
    - Speedometer and rpm meter (like FO2) + fuel
    - GMOD physics and prop menu
    - Map editor
    - Ragdoll effects (like GTA IV) when falling and dying
    - Broke car windshield on hard impact

### Fixes

- Weird circular shadow appears when drving and the car passes next to a building that projects a shadow (low quality)

- Block camera when Escape is pressed

- Car moves when the player is still getting inside it

- Auto-zoom with big vehicles

## Media

![screen shot 2017-04-01 at 00 01 31](https://cloud.githubusercontent.com/assets/557828/24571347/d95f11a0-1670-11e7-9e8e-d2a511d9f929.png)

![screen shot 2017-04-01 at 00 03 25](https://cloud.githubusercontent.com/assets/557828/24571348/d964f098-1670-11e7-8759-0160dbf5bcb5.png)

![screen shot 2017-04-01 at 00 02 13](https://cloud.githubusercontent.com/assets/557828/24571349/d96b7c24-1670-11e7-997d-ae15913481f8.png)

## Resources

* [GTAModding Wiki](http://www.gtamodding.com/wiki/Main_Page)

