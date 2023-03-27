using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDetector : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            Time.timeScale = 0;
            Debug.Log("Game Over");
        }
    }
}
