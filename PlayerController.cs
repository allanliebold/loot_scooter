using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
  public Rigidbody2D playerBody;
  
  public float moveSpeed;
  
  public Transform groundCheck;
  public float groundCheckRadius;
  public LayerMask ground;
  public bool isGrounded;
  
  void Start() {
    playerBody = GetComponent<Rigidbody2D> (); 
  }
  
  void Update() {
    isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, ground);
    moveHorizontal = Input.GetAxisRaw("Horizontal");
    moveVertical = Input.GetAxisRaw("Vertical");
    
    if(moveHorizontal > 0f && isGrounded) {
      playerBody.velocity = new Vector2(moveSpeed, playerBody.velocity.y);  
    } else if(moveHorizontal < 0f && isGrounded) {
      playerBody.velocity = new Vector2(-moveSpeed, playerBody.velocity.y);
    } else {
      playerBody.velocity = new Vector2(0f, playerBody.velocity.y); 
    }
  }
}
