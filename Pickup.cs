using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {
  public LevelManager levelManager;
  public int pointValue;
  
  void Start() {
    
  }
  
  void onTriggerEnter2D(Collision2D other) {
    if(other.name == "Player") {
      levelManager.AddToScore(pointValue);
      Destroy(this.gameObject);    
    }
  }
}
