using UnityEngine;
using UnityEngine.Android;


public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    private float forwardForce = 1200;
    private float sidewaysForce = 60;
    private float x;
    private float width;
    private float height;


    private void Start()
    {
        width = (float)Screen.width / 2.0f;
        height = (float)Screen.height / 2.0f;
    }

    void FixedUpdate()
    {

        x = Input.GetAxis("Horizontal");

        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Move the cube if the screen has the finger moving.
            if (touch.phase == TouchPhase.Began)
            {
                Vector2 pos = touch.position;
                pos.x = (pos.x - width) / width;
                rb.AddForce(sidewaysForce * Time.deltaTime * pos.x *2.25f, 0, 0, ForceMode.VelocityChange);

            }

        }
        else
            rb.AddForce(sidewaysForce * Time.deltaTime * x * 1.25f, 0, 0, ForceMode.VelocityChange);
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        //Debug.Log(x.ToString() + " " + stg.ToString());
    }
}

