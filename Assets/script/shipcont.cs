using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipcont : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject ship;
    public float rotationSpeed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey("w"))
        {
            rb.velocity -= transform.forward * 10 * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            // Rotate the ship to the left
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            // Rotate the ship to the right
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.velocity -= transform.forward * -1 * 10 * Time.deltaTime;
        }
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        //rb.velocity -= transform.forward * 0 * Time.deltaTime;
        
        //rb.velocity -= transform.forward * 0 * Time.deltaTime;
        if(collision.gameObject.tag == "Wall")
        {
            Debug.Log("Entered collision with " + collision.gameObject.tag);
            rb.velocity -= Vector3.zero;
            rb.angularVelocity -= Vector3.zero;
        }
    }
    
    /*
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Wall")
        {
            Debug.Log("Entered collision with " + other.gameObject.tag);
            //rb.velocity -= transform.forward * 0 * Time.deltaTime;
            rb.velocity -= Vector3.zero;
            rb.angularVelocity -= Vector3.zero;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Wall")
        {
            Debug.Log("Stay collision with " + other.gameObject.tag);
            //rb.velocity -= transform.forward * 0 * Time.deltaTime;
            //rb.velocity -= Vector3.zero;
            //rb.angularVelocity -= Vector3.zero;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Wall")
        {
            Debug.Log("Exit collision with " + other.gameObject.tag);
            //rb.velocity -= transform.forward * 0 * Time.deltaTime;
            //rb.velocity -= Vector3.zero;
            //rb.angularVelocity -= Vector3.zero;
        }

    }
    */

}
