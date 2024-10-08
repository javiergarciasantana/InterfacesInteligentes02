using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3Op : MonoBehaviour
{
  public Vector3 vector1;
  public Vector3 vector2;

  [SerializeField] private float magnitude_vector1;
  [SerializeField] private float magnitude_vector2;
  [SerializeField] private float angle_between_vectors;
  [SerializeField] private float distance_between_vectors;
  [SerializeField] private string higher_vector_msg;

  void Start()
  {
    // Calculate vectors' magnitudes
    magnitude_vector1 = vector1.magnitude;
    magnitude_vector2 = vector2.magnitude;

    // Magnitude printing
    Debug.Log("Magnitude of vector1: " + magnitude_vector1);
    Debug.Log("Magnitude dofe vector2: " + magnitude_vector2);

    // Calculate anlge between vectors(in degrees)
    angle_between_vectors = Vector3.Angle(vector1, vector2);

    // Angle printing
    Debug.Log("Angle between vector1 & vector2: " + angle_between_vectors + " degrees");

    // Calculate the distance between vectors
    distance_between_vectors = Vector3.Distance(vector1, vector2);

    // Distance printing
    Debug.Log("Distance between vector1 & vector2: " + distance_between_vectors);

    // Compare 'y' component between vectors
    if (vector1.y > vector2.y)
    {
      higher_vector_msg = "Vector1 is higher.";
    }
    else if (vector1.y < vector2.y)
    {
      higher_vector_msg = "Vector2 is higher.";
    }
    else
    {
      higher_vector_msg = "Both vectors at the same height.";
    }

    // Message printing
    Debug.Log(higher_vector_msg);
  }

  // Update is called once per frame
  void Update()
  {
      
  }
}
