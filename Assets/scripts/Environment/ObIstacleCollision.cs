using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObIstacleCollision : MonoBehaviour
{    
    public GameObject thePlayer;
    public GameObject charModel;
    public AudioSource cruchFX;
    public GameObject levelControl;
    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent<PlayerMove1>().enabled = false;
        charModel.GetComponent<Animator>().Play("Stumble Backwards");
        levelControl.GetComponent<LEVELDis>().enabled= false;
        cruchFX.Play();
        levelControl.GetComponent<EndRunSequese>().enabled = true;
    }
}
