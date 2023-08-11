using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputField : MonoBehaviour
{
    public string input;
    public GameObject sleepPanel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadStringInput(string s)
    {
        input = s;
       
        if(s=="Abhinav")
        {
            sleepPanel.SetActive(false);
            Time.timeScale = 1f;
        }

    }
}
