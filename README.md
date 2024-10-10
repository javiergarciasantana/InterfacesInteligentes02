# InterfacesInteligentes02
# 3D Object Color and Movement Scripts(Practica II)

This repository contains multiple C# scripts for Unity to control the colors and positions of 3D objects in a scene. Below is a brief description of each script and its functionality.

## Scripts

### `color_3d.cs`

This script changes the color of a 3D object randomly by modifying one of the RGB (Red, Green, or Blue) values after a specified number of frames.

- **How it works**:
  - The object starts with a random color.
  - Every 120 frames, one of the color components (R, G, or B) is randomly changed.

### `CubeColorChange.cs`

This script changes the color of a cube when the player presses the `C` key.

- **How it works**:
  - The cube starts with a random color.
  - Pressing the `C` key randomly changes one of the RGB components.

### `CylinderColorChange.cs`

This script changes the color of a cylinder when the player presses the `Up` arrow key.

- **How it works**:
  - The cylinder starts with a random color.
  - Pressing the `Up` arrow key randomly changes one of the RGB components.

### `NamePrinter.cs`

This script prints the name of the attached object to the console on startup.

- **How it works**:
  - The object’s name is retrieved and printed in the console when the scene starts.

### `ObjDistance.cs`

This script calculates the distances between the object (sphere) and two other tagged objects (cylinder and cube) and logs them.

- **How it works**:
  - On start, it calculates the distances between the sphere and objects tagged `magenta_cylinder` and `blackboard_cube`, and logs the results.

### `ObjectMover.cs`

This script moves an object between three different positions whenever the player presses the `Space` key.

- **How it works**:
  - The object cycles through three positions (relative to its original position) every time the `Space` key is pressed.

### `ObjPos.cs`

This script logs the position of the object to the console when the scene starts.

- **How it works**:
  - It retrieves and prints the position of the object when the scene starts.

### `SphereControl.cs`

This script finds the closest and farthest spheres with the tag `type2` relative to a cube, increases the height of the closest sphere, and changes the color of the farthest one when the `Space` key is pressed.

- **How it works**:
  - The script identifies the nearest and farthest spheres from the cube.
  - It increases the height of the closest sphere on startup and changes the color of the farthest sphere when `Space` is pressed.

### `Vector3Op.cs`

This script performs operations on two `Vector3` vectors, including calculating magnitudes, angles, distances, and comparing the height (`y` component) between them.

- **How it works**:
  - The magnitudes of both vectors are calculated and logged.
  - The angle between the two vectors (in degrees) and the distance between them is calculated and logged.
  - The script compares the `y` component of both vectors and logs which one is higher.

## Requirements

- Unity 2020.3 or higher.
- 3D objects (cube, sphere, cylinder, etc.) set up in the scene.
- Attach these scripts to the corresponding objects in the Unity editor.

