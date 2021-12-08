using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public float scoreValue = 0;
    public Text score;

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Mask"))
        {
            Pickup(other);
        }

        void Pickup(Collider player)
        {
            scoreValue += 1;

            Destroy(other.gameObject);
            
            UpdateUI();
        }
    }

    void UpdateUI()
    {
        score.text = "Masks Collected: " + scoreValue.ToString("0");
    }
}
