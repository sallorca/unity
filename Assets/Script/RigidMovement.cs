using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidMovement : MonoBehaviour
{
    public float speedMovement = 5;
    public float jumpForce = 10;
    public float groundDetectionDistance = 1;
    public Rigidbody rB;
    public LayerMask groundLayer;
    // Start is called before the first frame update
    void Start()
    {
       rB = GetComponent<Rigidbody>(); 
    }
    private void FixedUpdate()
    {
        Movement();
        if (Input.GetAxisRaw("Jump") == 1 && Physics.Raycast(transform.position,Vector3.down, groundDetectionDistance, groundLayer))
            Jump();
    }

    public void Movement()
    {
        Vector3 movVector = new Vector3(Input.GetAxisRaw("Horizontal") * speedMovement * Time.fixedDeltaTime, rB.velocity.y, Input.GetAxisRaw("Vertical") * speedMovement * Time.fixedDeltaTime);
        if(Physics.Raycast(transform.position,Vector3.down, groundDetectionDistance, groundLayer))
            rB.velocity = movVector;
    }
    public void Jump() => rB.AddForce(Vector3.up * jumpForce * Time.fixedDeltaTime, ForceMode.Impulse);
    // Update is called once per frame
    void Update()
    {
        
    }
}
