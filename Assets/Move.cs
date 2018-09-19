using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    public float moveSpeed;
    public float jumpForce;
    private Rigidbody theRB;
    public KeyCode left;
    public KeyCode right;
    public KeyCode jump;
    //most of this stuff is for later 
    public KeyCode throwWeapon;
    public Transform groundCheckpoint;
  // public bool isGrounded;
 //  public float groundCheckRadius;
  // public LayerMask whatIsGround;

	// Use this for initialization
	void Start () {
        jumpForce = 10;
        theRB = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        
        // isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, gorundCheckRadius, whatIsGround);
        if(Input.GetKey(left)){
            theRB.velocity = new Vector3(-moveSpeed, theRB.velocity.y);

        }else if(Input.GetKey(right)){
            theRB.velocity = new Vector3(moveSpeed, theRB.velocity.y);

        }else{
            theRB.velocity = new Vector3(0, theRB.velocity.y);

        }
        if(Input.GetKeyDown(jump)){
            theRB.velocity = new Vector3(theRB.velocity.x, jumpForce);

        }
    }
}
