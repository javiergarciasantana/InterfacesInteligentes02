// NamePrinter.cs
// AUTOR: Javier Garcia Santana
// FECHA: 08/10/2024
// EMAIL: alu0101391663@ull.edu.es
// VERSION: 1.0
// ASIGNATURA: Interfaces Inteligentes
// PRÁCTICA Nº: 2

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NamePrinter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      Object obj = GetComponent<Object>();
      Debug.Log("Hi, I am a " + obj.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
