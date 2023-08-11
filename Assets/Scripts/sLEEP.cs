using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sLEEP : MonoBehaviour
{
    public GameObject sleepPanel;
    
    void Start()
    {
        StartCoroutine(Sleep());
    }

    IEnumerator Sleep()
    {
        yield return new WaitForSeconds(10f);
        sleepPanel.SetActive(true);
        Time.timeScale = 0f;
    }
   
}
