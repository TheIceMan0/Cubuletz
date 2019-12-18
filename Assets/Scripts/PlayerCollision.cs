using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour {

    public int bani=0;
	public PlayerMovement movement;     // A reference to our PlayerMovement script
   
    // This function runs when we hit another object.
    // We get information about the collision and call it "collisionInfo".
    void OnCollisionEnter (Collision collisionInfo)
	{
		// We check if the object we collided with has a tag called "Obstacle".
		if (collisionInfo.collider.tag == "Obstacle")
		{
            
			movement.enabled = false;   // Disable the players movement.
			FindObjectOfType<GameManager>().EndGame();
		}
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            bani++;
            Data.banuti++;
        }
    }

}
