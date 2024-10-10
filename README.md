# InterfacesInteligentes02
# 3D Object Color and Movement Scripts(Practica II)

This repository contains multiple C# scripts for Unity to control the colors and positions of 3D objects in a scene. Below is a brief description of each script and its functionality.

## Scripts

### `color_3d.cs`

This script changes the color of a 3D object randomly by modifying one of the RGB (Red, Green, or Blue) values after a specified number of frames.

- **How it works**:
  - The object starts with a random color.
  - Every 120 frames, one of the color components (R, G, or B) is randomly changed.
![Practica-2-Ejercicio_1-Windows_-Mac_-Linux-Unity-2022 3 48f1_-_DX11_-2024-10-10-21-13-48](https://github.com/user-attachments/assets/56fb99ce-ac06-4117-b3ba-9b571b096b98)


### `CubeColorChange.cs`

This script changes the color of a cube when the player presses the `C` key.

- **How it works**:
  - The cube starts with a random color.
  - Pressing the `C` key randomly changes one of the RGB components.
![Practica-2-Ejercicio_1-Windows_-Mac_-Linux-Unity-2022 3 48f1_-_DX11_-2024-10-10-21-30-55](https://github.com/user-attachments/assets/600123f6-db3a-40bd-885a-ea9fb2641593)


### `CylinderColorChange.cs`

This script changes the color of a cylinder when the player presses the `Up` arrow key.

- **How it works**:
  - The cylinder starts with a random color.
  - Pressing the `Up` arrow key randomly changes one of the RGB components.
![Practica-2-Ejercicio_1-Windows_-Mac_-Linux-Unity-2022 3 48f1_-_DX11_-2024-10-10-21-30-55](https://github.com/user-attachments/assets/bc2b963e-45b5-4253-bb57-cf3795ce8222)

### `NamePrinter.cs`

This script prints the name of the attached object to the console on startup.

- **How it works**:
  - The object’s name is retrieved and printed in the console when the scene starts.
![Practica-2-Ejercicio_1-Windows_-Mac_-Linux-Unity-2022 3 48f1_-_DX11_-2024-10-10-21-19-54](https://github.com/user-attachments/assets/0b780d0a-1a44-4501-9a59-2c01a54ff15c)

### `ObjDistance.cs`

This script calculates the distances between the object (sphere) and two other tagged objects (cylinder and cube) and logs them.

- **How it works**:
  - On start, it calculates the distances between the sphere and objects tagged `magenta_cylinder` and `blackboard_cube`, and logs the results.
![Practica-2-Ejercicio_1-Windows_-Mac_-Linux-Unity-2022 3 48f1_-_DX11_-2024-10-10-21-25-08](https://github.com/user-attachments/assets/cfb9cd73-6eda-4583-9784-8d7bb26c183e)

### `ObjectMover.cs`

This script moves an object between three different positions whenever the player presses the `Space` key.

- **How it works**:
  - The object cycles through three positions (relative to its original position) every time the `Space` key is pressed.
![Practica-2-Ejercicio_1-Windows_-Mac_-Linux-Unity-2022 3 48f1_-_DX11_-2024-10-10-21-25-57](https://github.com/user-attachments/assets/ce97d24c-af28-401b-b12a-7d4853f9a342)

### `ObjPos.cs`

This script logs the position of the object to the console when the scene starts.

- **How it works**:
  - It retrieves and prints the position of the object when the scene starts.
![Practica-2-Ejercicio_1-Windows_-Mac_-Linux-Unity-2022 3 48f1_-_DX11_-2024-10-10-21-23-51](https://github.com/user-attachments/assets/79f72ba2-3116-433e-ac11-eb8e45ba5b4d)

### `SphereControl.cs`

This script finds the closest and farthest spheres with the tag `type2` relative to a cube, increases the height of the closest sphere, and changes the color of the farthest one when the `Space` key is pressed.

- **How it works**:
  - The script identifies the nearest and farthest spheres from the cube.
  - It increases the height of the closest sphere on startup and changes the color of the farthest sphere when `Space` is pressed.
![Practica-2-Ejercicio_1-Windows_-Mac_-Linux-Unity-2022 3 48f1_-_DX11_-2024-10-10-21-36-04](https://github.com/user-attachments/assets/85feb934-91a8-4018-bbe0-d683bdfb636c)

### `Vector3Op.cs`

This script performs operations on two `Vector3` vectors, including calculating magnitudes, angles, distances, and comparing the height (`y` component) between them.

- **How it works**:
  - The magnitudes of both vectors are calculated and logged.
  - The angle between the two vectors (in degrees) and the distance between them is calculated and logged.
  - The script compares the `y` component of both vectors and logs which one is higher.
![Practica-2-Ejercicio_1-Windows_-Mac_-Linux-Unity-2022 3 48f1_-_DX11_-2024-10-10-21-22-50](https://github.com/user-attachments/assets/629a8083-5fc5-497c-be2f-033887ad5b92)

## Requirements

- Unity 2020.3 or higher.
- 3D objects (cube, sphere, cylinder, etc.) set up in the scene.
- Attach these scripts to the corresponding objects in the Unity editor.

