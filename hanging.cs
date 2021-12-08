using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hanging : MonoBehaviour
{
   void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(3);
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
