using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractScript : MonoBehaviour
{
    public float Interactdistance = 10f;
    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit, Interactdistance))
            {
                if (hit.collider.CompareTag("Door"))
                {
                    hit.collider.transform.GetComponent<DoorScript>().ChangeDoorState();
                }
            }


        }
    }
}
