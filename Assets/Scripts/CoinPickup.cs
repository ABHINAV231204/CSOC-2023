using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    
    
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                Destroy(gameObject);
                GameObject.Find("AudioManager").GetComponent<soundManager>().playCoinPickup();
        }
        }
 }
