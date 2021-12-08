using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spikestrap : MonoBehaviour
{
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public GameObject trap;
     void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            trap.GetComponent<Animation>().Play("spike");
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
            Invoke("SwitchScene", 0.5f);
        }
    }
    private void SwitchScene()
    {
        SceneManager.LoadScene(3);
        Cursor.lockState = CursorLockMode.None;
    }
}
