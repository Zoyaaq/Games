using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class falldown : MonoBehaviour
{
    AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    public GameObject trap;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Instantiate(trap, transform.position, transform.rotation);

            if (!audio.isPlaying)
            {
                audio.Play();
            }

            Invoke("SwitchScene", 0.7f);
        }
    }
    private void SwitchScene()
    {
        SceneManager.LoadScene(3);
        Cursor.lockState = CursorLockMode.None;
    }

}
