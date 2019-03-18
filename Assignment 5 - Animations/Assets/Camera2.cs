using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2 : MonoBehaviour
{

    public Transform Player;
    public Transform Camera3rd;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Camera3rd.position = new Vector3(Player.position.x, Camera3rd.position.y, Camera3rd.position.z);
    }
}
