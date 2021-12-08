using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public GameObject player;
    public GameObject menuCamera;
    public GameObject menuPanel;
   
    void Start()
    {
        menuCamera.SetActive(false);
        menuPanel.SetActive(false);
        player.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
    }
     void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            menuCamera.SetActive(true);
            menuPanel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            player.SetActive(false);
        }
    }

    public void StartGame()
    {
        menuCamera.SetActive(false);
        menuPanel.SetActive(false);
        player.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    
}
