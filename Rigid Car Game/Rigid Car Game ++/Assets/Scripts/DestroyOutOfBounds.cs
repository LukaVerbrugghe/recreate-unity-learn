using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    private float destroyY = -5;

    private void Update()
    {
        if (transform.position.y < destroyY)
        {
            Object.Destroy(this.gameObject);
        }
    }
}
