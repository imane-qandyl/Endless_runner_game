using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leveiBoundary : MonoBehaviour
{
    public static float leftSide = -3.3f;
    public static float rightSide = 3.3f;
    public float internaLeft;
    public float internaRight;
    // Update is called once per frame
    void Update()
    {
        internaLeft = leftSide;
        internaRight = rightSide;
    }
}
