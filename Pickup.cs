using UnityEngine;
using System.Collections;

public GameObject levelManager;

public class Pickup : MonoBehaviour {
  void onTriggerEnter2D(Collision2D other) {
    if(other.name == "Player) {
      Destroy(this.gameObject);    
    }
  }
}
