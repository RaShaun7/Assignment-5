using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator animator;
    private bool Open;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    

    // Start is called before the first frame update
    void Start()
    {
        Open = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && CollectText.collected > 3)
        {
            Open = true;
            Debug.Log("hi");
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Open = false;
            Debug.Log("bye");
        }

    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("Open", Open);
    }
}
