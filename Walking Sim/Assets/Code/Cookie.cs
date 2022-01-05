using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookie : MonoBehaviour
{
    int speed = 30;

    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0, Space.World);
    }
}
