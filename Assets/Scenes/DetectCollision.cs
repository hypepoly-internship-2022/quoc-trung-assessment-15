using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    ParticleSystem particleSystemX;

    void Start()
    {
        particleSystemX = GetComponent<ParticleSystem>();
    }

    void OnParticleCollision(GameObject other)
    {
        if (other.gameObject.CompareTag("Dirt"))
        {     
            other.gameObject.GetComponent<Rigidbody>().useGravity = true;
            Destroy(other.gameObject,0.4f);
            
        }
            
    }
}
