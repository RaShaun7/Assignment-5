using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera3 : MonoBehaviour
{

    public Transform Player;
    public Transform Camera5th;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Camera5th.LookAt(Player);
    }
}
