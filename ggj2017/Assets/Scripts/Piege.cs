using UnityEngine;
using System.Collections;

public class Piege : MonoBehaviour
{
    //public Collider coll;
    public GameObject porte;
    public Rigidbody2D rb;

    void Start()
    {
        porte = GameObject.FindGameObjectWithTag("porte");
        rb = porte.GetComponent<Rigidbody2D>();
        Debug.Log("start");
 
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
            Debug.Log("Player");

        }

        Debug.Log("triggered");
    }

}