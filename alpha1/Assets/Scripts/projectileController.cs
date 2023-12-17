using UnityEngine;
using TMPro;

public class projectileController : MonoBehaviour
{
    public float speed = 10f;
    public float gunDmg = 30f;
    public float zombieHealth = 100f;
    private float score = 0f;
    public TextMeshProUGUI scoreText;

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    // OnTriggerEnter is called when the GameObject collides with another GameObject
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy"))

        {

            // Reduce the zombie's health by the gun's damage
            zombieHealth -= gunDmg;

            if (zombieHealth <= 0)
            {
                Destroy(other.gameObject); // Destroy the enemy when its health drops to or below zero
                // You might want to add some additional functionality here such as score increment or effects.

                 UpdateScore(2);                
            }
        }
    }

    void Start() {

      //  UpdateScore(0);

    }

    public void UpdateScore(int scoreToAdd)
    {

        score = score +scoreToAdd ;
        scoreText.text = "Score: " + score;

    }

}
