using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
  public float moveSpeed;
  private bool canMove;
  
  private Rigidbody2D enemyBody; 
  
  void Start() {
    enemyBody = GetComponent<Rigidbody2D>();
  }
  
  void Update() {
    if(canMove) {
       
    }
  }
}
