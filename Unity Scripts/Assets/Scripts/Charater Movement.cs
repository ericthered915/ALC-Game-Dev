using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaterMovement : MonoBehaviour {

    // Player Movement Variables
    public int MoveSpeed;
    public float JumpHeight;

    //Player grounded variables
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;

	// Use this for initialization
	void Start () {
		
	}


    private void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle.(groundCheck.position, groundCheckRadius, whatIsGround);
    }

    // Update is called once per frame
    void Update () {
    // This code makes ghe charater jump
    if (Input.GetKeyDown)(KeyCode.Space)&& grounded) { Jump(); }
	}
}

public void Jump()
{
    GetComponent<Rigidbody2D>().velocity = new Vector2(GetCompondent<Rigidbody2D>().velocity.x, JumpHeight);
}
}
