using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    [Range(1, 10)]
    public float jumpVelocity;
    public LayerMask groundLayers;
    public SphereCollider col;



    bool jumpRequest;

     void Start()
    {
        col = GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetButtonDown("Jump"))//isGrounded() &&
        {
            jumpRequest = true;
        }
    }

    

    void FixedUpdate()
    {
        if (jumpRequest)
        {
            //GetComponent<Rigidbody>().velocity += Vector3.up * jumpVelocity; (old jump)
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpVelocity, ForceMode.Impulse);
            jumpRequest = false;


        }
    }

    //public bool isGrounded()
    //{
    //    Physics.CheckCapsule
    //    (col.bounds.center, new Vector3(col.bounds.center.x, col.bounds.min.y, col.bounds.center.z), col.radius * .9f, groundLayers);
    //    return false;
    //}
}
