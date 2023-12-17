using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieController : MonoBehaviour
{
    public float speed = 0f;
    public float health = 100f;
    public float bulletDmg = 10f;
    //public gameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         transform.Translate(Vector3.right * speed * Time.deltaTime);

         if(health <= 0.0f)
         {
            Destroy(gameObject);
         }

    }


void OnTriggerEnter(Collider other)
{
    health = (health-bulletDmg);
   // Destroy(other.gameObject);
   // Destroy(gameObject);
}

}


