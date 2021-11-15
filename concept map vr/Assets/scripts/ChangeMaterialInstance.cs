using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterialInstance : MonoBehaviour
{
    [SerializeField] private Renderer myobject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myobject.material.color = Color.black;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            myobject.material.color = Color.red;
        }
    }
}
