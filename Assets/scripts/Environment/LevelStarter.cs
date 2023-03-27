using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    public GameObject countDown3;
    public GameObject countDown2;
    public GameObject countDown1;
    public GameObject countDownGo;
    public GameObject fadeIn;
    public AudioSource goFX;
    public AudioSource l1FX;
    public AudioSource l2FX;
    public AudioSource l3FX;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountSequence());
    }
    IEnumerator CountSequence()
    {
        yield return new WaitForSeconds(1.5f);
        countDown3.SetActive(true);
        l3FX.Play();
        yield return new WaitForSeconds(1);
        countDown2.SetActive(true);
        l2FX.Play();
        yield return new WaitForSeconds(1);
        countDown1.SetActive(true);
        l1FX.Play();
        yield return new WaitForSeconds(1);
        countDownGo.SetActive(true);
        goFX.Play();
        PlayerMove1.canMove = true;
    }
}
