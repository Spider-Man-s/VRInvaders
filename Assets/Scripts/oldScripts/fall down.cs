using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class falldown : MonoBehaviour
{
    private Rigidbody rb;
    private bool fall = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("projectile"))
        {
            rb.useGravity = true;
            fall = true;
        }
    }

    void Update()
    {
        if (rb.GetComponent<Rigidbody>() != null)
        {
            if (fall)
            {
                rb.useGravity = true;
            }
        }
    }
}