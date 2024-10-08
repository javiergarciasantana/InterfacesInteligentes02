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
