using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    
    [SerializeField] TextMeshProUGUI completedText;
    [SerializeField] ParticleSystem congrateParticleSystem;
    [SerializeField] GameObject parent;
    int numberOfChild;
    bool isCompleted;

    void Start()
    {
       
    }

    
    void Update()
    {
        if(isCompleted == false)
        {
            Debug.Log(numberOfChild);
            UpdateChildCount();
        }
        
    }
    public void Completed()
    {
        congrateParticleSystem.Play();
        completedText.gameObject.SetActive(true);
    }
    void UpdateChildCount()
    {
        numberOfChild = parent.transform.childCount;
        if (numberOfChild == 0)
        {     
            Completed();
            isCompleted = true;
        }
    }
}
