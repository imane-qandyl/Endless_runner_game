using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableControl : MonoBehaviour
{
    public static int coinCount;
    public GameObject coinCountDisplay;
    public GameObject coinEnDisplay;
    // Update is called once per frame
    void Update()
    {
        coinCountDisplay.GetComponent<Text>().text=""+coinCount;
        coinEnDisplay.GetComponent<Text>().text=""+coinCount;
    }
}
