using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereParticles : MonoBehaviour
{
    public ParticleSystem sparky;
   // [SerializeField]




    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            CollectText.collected += 1;
            sparky.transform.position = this.gameObject.transform.position;
            sparky.Play();
            Destroy(this.gameObject);
        }

    }


}
