using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DestroyObject : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
       
       
    }
    private void FixedUpdate()
    {
     
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        Destroy(collision.gameObject);
       

    }
}
