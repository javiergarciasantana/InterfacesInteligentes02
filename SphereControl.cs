// SphereControl.cs
// AUTOR: Javier Garcia Santana
// FECHA: 08/10/2024
// EMAIL: alu0101391663@ull.edu.es
// VERSION: 1.0
// ASIGNATURA: Interfaces Inteligentes
// PRÁCTICA Nº: 2

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControl : MonoBehaviour
{
 public GameObject cubo; // Referencia al cubo desde el Editor de Unity
  public float incrementoAltura = 1.0f; // Valor para incrementar la altura de la esfera más cercana

  private GameObject esferaCercana;
  private GameObject esferaLejana;

  void Start()
  {
    // Buscar todas las esferas de tipo 2 (con el tag "Tipo2")
    GameObject[] esferasTipo2 = GameObject.FindGameObjectsWithTag("type2");

    if (esferasTipo2.Length == 0)
    {
      Debug.LogWarning("No se encontraron esferas de tipo 2.");
      return;
    }

    // Encontrar la esfera más cercana y la más lejana al cubo
    esferaCercana = esferasTipo2[0];
    esferaLejana = esferasTipo2[0];

    float distanciaMin = Vector3.Distance(cubo.transform.position, esferasTipo2[0].transform.position);
    float distanciaMax = distanciaMin;

    foreach (GameObject esfera in esferasTipo2)
    {
      float distancia = Vector3.Distance(cubo.transform.position, esfera.transform.position);

      // Determinar la esfera más cercana
      if (distancia < distanciaMin)
      {
        distanciaMin = distancia;
        esferaCercana = esfera;
      }

      // Determinar la esfera más lejana
      if (distancia > distanciaMax)
      {
        distanciaMax = distancia;
        esferaLejana = esfera;
      }
    }

    // Incrementar la altura de la esfera más cercana
    AumentarAlturaEsfera(esferaCercana);
  }

  void Update() 
  {
    if (Input.GetKeyDown(KeyCode.Space))
    {
      CambiarColorEsfera(esferaLejana);
    }
  }

  // Método para aumentar la altura de una esfera
  void AumentarAlturaEsfera(GameObject esfera)
  {
    Vector3 nuevaPosicion = esfera.transform.position;
    nuevaPosicion.y += incrementoAltura; // Incrementa la altura (eje Y)
    esfera.transform.position = nuevaPosicion;
  }

  // Método para cambiar el color de una esfera
  void CambiarColorEsfera(GameObject esfera)
  {
    Renderer renderer = esfera.GetComponent<Renderer>();
    if (renderer != null)
    {
      renderer.material.color = Random.ColorHSV(); // Cambiar a un color aleatorio
    }
  }
}
