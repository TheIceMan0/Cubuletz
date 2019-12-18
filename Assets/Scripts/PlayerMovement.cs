using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;

	private float forwardForce = 1200;
	private float sidewaysForce = 60;
    private float x;
    

    void FixedUpdate ()
	{
        x = Input.GetAxis("Horizontal");
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        rb.AddForce(sidewaysForce * Time.deltaTime*x*2, 0, 0, ForceMode.VelocityChange);
        
        if (rb.position.y < -1f)
		{
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}

