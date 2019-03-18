using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementCollision : MonoBehaviour
{

    Rigidbody rigidbody;
    [SerializeField]
    float speed = 10;
    [SerializeField]
    float height = 1;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Collectable")
        {
            CollectText.collected += 1;
            Destroy(other);
        }

        if (other.tag == "Room1")
        {
            CameraControl.CameraMode = 1;
            Debug.Log("hi");
        }

        if (other.tag == "Room2")
        {
            CameraControl.CameraMode = 2;
            Debug.Log("bye");
        }


        if (other.tag == "Room3")
        {
            CameraControl.CameraMode = 3;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 
                           Input.GetKey(KeyCode.Space) ? height : 0, Input.GetAxis("Vertical"));
        rigidbody.MovePosition(transform.position + movement * Time.deltaTime * speed);
    }
}
