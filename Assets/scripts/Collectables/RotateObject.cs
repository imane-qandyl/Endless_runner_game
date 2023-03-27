using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public int rotateObject=1;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,rotateObject,0,Space.World);
    }
}
