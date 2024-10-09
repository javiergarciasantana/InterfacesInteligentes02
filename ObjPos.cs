// ObjPos.cs
// AUTOR: Javier Garcia Santana
// FECHA: 08/10/2024
// EMAIL: alu0101391663@ull.edu.es
// VERSION: 1.0
// ASIGNATURA: Interfaces Inteligentes
// PRÁCTICA Nº: 2

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjPos : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
    Transform obj = GetComponent<Transform>();
    Debug.Log("Object " + obj.name + " is at: " + obj.position);
      
  }

  // Update is called once per frame
  void Update()
  {
      
  }
}
