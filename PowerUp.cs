using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUp : MonoBehaviour
{
    public GameObject pickEffect;
 
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            Pickup(other);
        }

        void Pickup(Collider player)
        {
            Instantiate(pickEffect, transform.position, transform.rotation);
            
        }

    }
    
}
