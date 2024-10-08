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
