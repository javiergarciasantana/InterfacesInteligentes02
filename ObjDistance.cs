// ObjDistance.cs
// AUTOR: Javier Garcia Santana
// FECHA: 08/10/2024
// EMAIL: alu0101391663@ull.edu.es
// VERSION: 1.0
// ASIGNATURA: Interfaces Inteligentes
// PRÁCTICA Nº: 2

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjDistance : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
    Transform sphere = GetComponent<Transform>();
    
    GameObject cylinderObject = GameObject.FindWithTag("magenta_cylinder");
    Transform cylinder = cylinderObject.GetComponent<Transform>();
    
    GameObject cubeObject = GameObject.FindWithTag("blackboard_cube");
    Transform cube = cubeObject.GetComponent<Transform>();

    float distanceBetweenVectors = Vector3.Distance(sphere.position, cylinder.position);
    
    Debug.Log("Distance between " + sphere.name + " & " + cylinder.name + ": " + distanceBetweenVectors);
  
    distanceBetweenVectors = Vector3.Distance(sphere.position, cube.position);
    
    Debug.Log("Distance between " + sphere.name + " & " + cube.name + ": " + distanceBetweenVectors);

  }

  // Update is called once per frame
  void Update()
  {
        
  }
}
