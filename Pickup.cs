using UnityEngine;
using System.Collections;

public GameObject levelManager;
public int pointValue;

public class Pickup : MonoBehaviour {
  void onTriggerEnter2D(Collision2D other) {
    if(other.name == "Player) {
      levelManager.AddToScore(pointValue);
      Destroy(this.gameObject);    
    }
  }
}
