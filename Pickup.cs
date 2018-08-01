using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {
  void onTriggerEnter2D(Collision2D other) {
    if(other.name == "Player) {
      Destroy(this.gameObject);    
    }
  }
}
