using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraControl : MonoBehaviour {

    public GameObject Camera1st;
    public GameObject Camera3rd;
    public GameObject Camera5th;
    public GameObject SpotLight;
    
    public static int CameraMode;
    public int Switch;

    // Start is called before the first frame update
    void Start()
    {
        CameraMode = 1;
        Switch = 0;
    }

    


    // Update is called once per frame
    void Update()
    {
        if(CameraMode == 1)
        {
            Camera1st.SetActive(true);
            Camera3rd.SetActive(false);
            Camera5th.SetActive(false);
        }

        if (CameraMode == 2)
        {
            Camera1st.SetActive(false);
            Camera3rd.SetActive(true);
            Camera5th.SetActive(false);
        }

        if (CameraMode == 3)
        {
            Camera1st.SetActive(false);
            Camera3rd.SetActive(false);
            Camera5th.SetActive(true);
        }

        if (Switch == 0)
        {
            SpotLight.SetActive(false);
        }

        if (Switch == 1)
        {
            SpotLight.SetActive(true);
        }

        if (Input.GetKeyUp(KeyCode.F) && Switch == 0)
        {
            
                Switch = 1;
                Debug.Log("hi");
            

         
        }

        if (Input.GetKeyUp(KeyCode.G) && Switch == 1)
        {
            
                Switch = 0;
                Debug.Log("bye");
            
        }


    }
}
