using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour {

    [SerializeField] private float moveSpeed;
    private float verrticalInput;
    private float horizontalInput;
    [SerializeField] private float rotationSpeed;

    private void Update() {

        //move forward/backwards
        verrticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * verrticalInput);

        //move left/right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, Time.deltaTime * horizontalInput * rotationSpeed);
    }
}
