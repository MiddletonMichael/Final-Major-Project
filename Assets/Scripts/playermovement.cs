using UnityEngine;

public class playermovement : MonoBehaviour {

    // This is a reference to the component called "rb"
    public Rigidbody rb;

    public float forwardForce = 2000f; 
    public float sidewaysForce = 500f;

    // Marked this as "Fixed"Update beceause i am using it to mess with physics
    void FixedUpdate()
    {
        // add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        
        // adding sideway forces to a key and d key
        if ( Input.GetKey ("d") ) 
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
        if ( Input.GetKey ("a") ) 
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
