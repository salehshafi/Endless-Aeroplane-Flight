using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateZ : MonoBehaviour
{
    public float speed = 10;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z + (Time.deltaTime * speed));
    }
}
