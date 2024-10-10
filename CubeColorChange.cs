// CubeColorChange.cs
// AUTOR: Javier Garcia Santana
// FECHA: 08/10/2024
// EMAIL: alu0101391663@ull.edu.es
// VERSION: 1.0
// ASIGNATURA: Interfaces Inteligentes
// PRÁCTICA Nº: 2

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColorChange : MonoBehaviour
{
  private Color color_vector;

  // Start is called before the first frame update
  void Start()
  {
    color_vector =  new Color(Random.value, Random.value, Random.value);
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.C))
    {
      ChangeColor();
    }
  }

  void ChangeColor() {
    
    int random_index = Random.Range(0, 3); // 0: R, 1: G, 2: B
    float new_value = Random.value; // New random value between 0.0 y 1.0

    if (random_index == 0) color_vector.r = new_value;
    else if (random_index == 1) color_vector.g = new_value;
    else color_vector.b = new_value;

    Material obj_material = GetComponent<Renderer>().material;
    if (obj_material != null)
    {
      obj_material.color = color_vector;
    }
  }
}

