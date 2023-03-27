using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove1 : MonoBehaviour
{   
    public float moveSpeed=3;
    public float leftRightSpeed=4;
    static public bool canMove=false;
    // Update is called once per frame
    void Update()
    {   
        transform.Translate(Vector3.forward*Time.deltaTime*moveSpeed,Space.World);
        if (canMove==true)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                if (this.gameObject.transform.position.x > leveiBoundary.leftSide)
                {
                    transform.Translate(Vector3.left*Time.deltaTime*leftRightSpeed);
                }
            }
            if (Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.RightArrow))
            {
                if (this.gameObject.transform.position.x < leveiBoundary.rightSide)
                {
                    transform.Translate(Vector3.left*Time.deltaTime*leftRightSpeed*-1);
                }
            }    
        }

    }
}
