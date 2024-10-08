using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMover : MonoBehaviour
{
  // Referencia al objeto que se va a mover (puede ser un cubo, esfera, etc.)
  public GameObject objectToMove;

  // Tres vectores que representan las posiciones de desplazamiento relativas
  public Vector3 positionOffset1;
  public Vector3 positionOffset2;
  public Vector3 positionOffset3;

  // Almacena la posición original del objeto
  private Vector3 originalPosition;

  // Variable para llevar un control de la posición actual
  private int currentPositionIndex = 0;

  void Start()
  {
    // Guarda la posición original del objeto que se va a mover
    if (objectToMove != null)
    {
      originalPosition = objectToMove.transform.position;
    }
    else
    {
      Debug.LogError("Object to move not assigned.");
    }
  }

  void Update()
  {
    // Verifica si se ha presionado la barra espaciadora
    if (Input.GetKeyDown(KeyCode.Space))
    {
      MoveObjectToNextPosition();
    }
  }

  void MoveObjectToNextPosition()
  {
    // Cambia la posición del objeto a la siguiente posición
    switch (currentPositionIndex)
    {
      case 0:
        objectToMove.transform.position = originalPosition + positionOffset1;
        currentPositionIndex = 1;
        break;
      case 1:
        objectToMove.transform.position = originalPosition + positionOffset2;
        currentPositionIndex = 2;
        break;
      case 2:
        objectToMove.transform.position = originalPosition + positionOffset3;
        currentPositionIndex = 0; // Vuelve al inicio
        break;
    }
  }
}
