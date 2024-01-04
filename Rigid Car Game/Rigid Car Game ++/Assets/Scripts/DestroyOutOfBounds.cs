using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour {

    //when player falls he will disappear and get a game over screen
    private void Update() {
        if (transform.position.y <= -5)
        {
            Destroy(gameObject);
            //trigger game over
        }
    }
}
