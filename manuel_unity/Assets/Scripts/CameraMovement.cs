using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    void Update()
    {
        if (GameCommon.isAlive) {
            transform.Translate(2 * Time.deltaTime, 0, 0);
        }

    }
}
