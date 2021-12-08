using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Virus : MonoBehaviour
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

            Destroy(other.gameObject);

            SceneManager.LoadScene(3);
        }
    }
}