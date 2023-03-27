using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LEVELDis : MonoBehaviour
{
    public GameObject disDisplay;
    public GameObject disEnDisplay;
    public int disRun;
    public bool addingDis=false;
    public float disDeplay=0.1f;
    void Update()
    {
        if(addingDis==false)
        {
            addingDis=true;
            StartCoroutine(AddingDis());
        }
    }
    IEnumerator AddingDis()
    {
        disRun+=1;
        disDisplay.GetComponent<Text>().text=""+disRun;
        disEnDisplay.GetComponent<Text>().text=""+disRun;
        yield return new WaitForSeconds(disDeplay);
        addingDis=false;
    }
}
