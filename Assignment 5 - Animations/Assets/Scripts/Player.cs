﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public Animator anim;
    public Rigidbody rbody;
    //public ParticleSystem sparks;

    private float inputH;
    private float inputV;
    private bool run;
    private bool jump;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rbody = GetComponent<Rigidbody>();
        run = false;
        jump = false;
    }

    //private void OnTriggerEnter(Collider other)
   // {
       // if (other.tag == "Collectable")
        //{
            //CollectText.collected += 1;
          //  sparks.Play();
        //    Destroy(other);
       //}
       
    //}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            anim.Play("WAIT01", -1, 0f);
        }

        if (Input.GetKeyDown("2"))
        {
            anim.Play("WAIT02", -1, 0f);
        }

        if (Input.GetKeyDown("3"))
        {
            anim.Play("WAIT03", -1, 0f);
        }

        if (Input.GetKeyDown("4"))
        {
            anim.Play("WAIT04", -1, 0f);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            run = true;
        }
        else
        {
            run = false;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            jump = true;
        }
        else
        {
            jump = false;
        }

        if (CollectText.collected == 5)
        {
            SceneManager.LoadScene("Menu");
        }

        inputH = Input.GetAxis("Horizontal");
        inputV = Input.GetAxis("Vertical");

        anim.SetFloat("inputH", inputH);
        anim.SetFloat("inputV", inputV);
        anim.SetBool("run", run);
        anim.SetBool("jump", jump);

        float moveX = inputH*150f*Time.deltaTime;
        float moveZ = inputV*210f*Time.deltaTime;

        if(moveZ <= 0f)
        {
            moveX = 0f;
        }
        else if (run)
        {
            moveX *= 3f;
            moveZ *= 3f;
        }

        rbody.velocity = new Vector3(moveX, 0f, moveZ);
    }
}
