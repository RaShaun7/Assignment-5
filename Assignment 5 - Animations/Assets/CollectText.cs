using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectText : MonoBehaviour
{
    public GameObject collectText;
    public static int collected;

    // Start is called before the first frame update
    void Start()
    {
        collected = 0;
    }

    // Update is called once per frame
    void Update()
    {
        collectText.GetComponent<Text>().text = "Spheres: " + collected + "/5"; 
    }
}
