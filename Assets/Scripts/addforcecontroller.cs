using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addforcecontroller : MonoBehaviour
{
    public float thrust = 1.0f;
    public Rigidbody2D rb;
    public float rotationSpeed = 100.0f;
    


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        
       


    }


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, -Input.GetAxis("Horizontal") * rotationSpeed);
        
        
    }

    void FixedUpdate()
    {
        rb.AddForce(transform.up * thrust * Input.GetAxis("Vertical"));
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"));

        {
            //Debug.Log("You hit an Enemy");
            Destroy(other.gameObject);
        }

    }


}




