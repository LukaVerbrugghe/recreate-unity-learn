using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    private float verrticalInput;
    private float horizontalInput;
    [SerializeField] private float rotationSpeed;

    private void Update()
    {

        //move forward/backwards
        verrticalInput = Input.GetAxis("Vertical2");
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * verrticalInput);

        //move left/right
        horizontalInput = Input.GetAxis("Horizontal2");
        transform.Rotate(Vector3.up, Time.deltaTime * horizontalInput * rotationSpeed);
    }
}
