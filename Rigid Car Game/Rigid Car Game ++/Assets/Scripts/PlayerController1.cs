using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour {

    [SerializeField] private float moveSpeed;
    private float horizontalInput;

    private void Update() {
        //move forward

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * horizontalInput);
    }
}
