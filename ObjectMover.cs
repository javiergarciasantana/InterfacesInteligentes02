// ObjectMover.cs
// AUTOR: Javier Garcia Santana
// FECHA: 08/10/2024
// EMAIL: alu0101391663@ull.edu.es
// VERSION: 1.0
// ASIGNATURA: Interfaces Inteligentes
// PRÁCTICA Nº: 2

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMover : MonoBehaviour
{
  // Object to move reference
  public GameObject object_to_move;

  // Three vectors representing the relative positions given by user
  public Vector3 relative_pos_1;
  public Vector3 relative_pos_2;
  public Vector3 relative_pos_3;

  // Object's original position
  private Vector3 original_pos;

  // Variable to know at which relative position are we
  private int current_pos_index = 0;

  void Start()
  {
    // Save subject's original position
    if (object_to_move != null)
    {
      original_pos = object_to_move.transform.position;
    }
    else
    {
      Debug.LogError("Object to move not assigned.");
    }
  }

  void Update()
  {
    // Verify spacebar actuation
    if (Input.GetKeyDown(KeyCode.Space))
    {
      MoveObjectToNextPosition();
    }
  }

  void MoveObjectToNextPosition()
  {
    // Change object to next position
    switch (current_pos_index)
    {
      case 0:
        object_to_move.transform.position = originalPosition + relative_pos_1;
        current_pos_index = 1;
        break;
      case 1:
        object_to_move.transform.position = originalPosition + relative_pos_2;
        current_pos_index = 2;
        break;
      case 2:
        object_to_move.transform.position = originalPosition + relative_pos_3;
        current_pos_index = 0; // Go back to the start position
        break;
    }
  }
}
