using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    //void Start()
    //{
    //    //rb.useGravity = false ;
    //    rb.AddForce(0,200,500);
    //}
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Update is called once per frame
    void Update()
   {
        rb.AddForce(0,0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce* Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
        else if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime + 1);
        }
        else if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime - 1);
        }
        else
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }  
        
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}

         
