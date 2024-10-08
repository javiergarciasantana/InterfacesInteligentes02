using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color_3d : MonoBehaviour
{

  [SerializeField]
  private int frames_to_wait = 120;
  private int frame_counter = 0;
  private Color color_vector;

  // Start is called before the first frame update
  void Start()
  {
    color_vector =  new Color(Random.value, Random.value, Random.value);
    Renderer renderer = GetComponent<Renderer>();
    if (renderer != null)
    {
      renderer.material.color = color_vector;
    }  
  }

  // Update is called once per frame
  void Update()
  {
    frame_counter++;

    if (frame_counter >= frames_to_wait)
    {
      int random_index = Random.Range(0, 3); // 0: R, 1: G, 2: B
      float new_value = Random.value; // New random value between 0.0 y 1.0

      if (random_index == 0) color_vector.r = new_value;
      else if (random_index == 1) color_vector.g = new_value;
      else color_vector.b = new_value;

      Renderer renderer = GetComponent<Renderer>();
      if (renderer != null)
      {
        renderer.material.color = color_vector;
      }
      // Restar the counter
      frame_counter = 0;
    }
  }
}
