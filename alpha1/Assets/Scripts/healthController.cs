using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthController : MonoBehaviour
{

    public float health = 100f;
    public float zombieDmg = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          if(health <= 0.0f)
         {
            Destroy(gameObject);
         }
    }
   void OnTriggerEnter()
    {
        health = health-zombieDmg;
    }
}
