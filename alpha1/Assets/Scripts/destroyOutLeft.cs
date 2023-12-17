using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOutLeft : MonoBehaviour
{

          public float destroyPositionX = 10f; // X position at which the GameObject gets destroyed
// Check if the GameObject's X position is less than the destroy position
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   
        if (transform.position.x > destroyPositionX)
        {
            Destroy(gameObject); // Destroy the GameObject when it goes past the specified X position
        }
    }
}
