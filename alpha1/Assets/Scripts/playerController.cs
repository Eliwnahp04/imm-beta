using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float speed = 1.0f;
    public float spawnOffset = -1f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Calculate spawn position slightly in front of the player (-1 on the X-axis)
            Vector3 spawnPosition = transform.position - transform.right * spawnOffset;

            // Instantiate the projectile at the calculated spawn position
            Instantiate(projectilePrefab, spawnPosition, transform.rotation);
        }

        // Get user input for movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement direction based on user input
        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput) * speed * Time.deltaTime;

        // Apply movement to the player's position
        transform.Translate(movement);
    }

    // OnTriggerEnter is called when the GameObject collides with another GameObject
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy"))
        {
            Destroy(gameObject); // Destroy the player when colliding with an enemy
            // You might want to add some additional functionality here such as game over logic or effects.
        }
    }

}
