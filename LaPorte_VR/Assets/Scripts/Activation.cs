using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Activation : MonoBehaviour
{

public GameObject Porte;
public GameObject E_Porte;

    bool check = false;
    bool button_Switch = false;

   

    // Update is called once per frame
    void Update()
    {
        
    if (Input.GetKeyDown(KeyCode.E) && button_Switch == true)
        {
            
            Porte.transform.Rotate(0f,-45f,0f);
            
        }
        
        if (Input.GetKeyDown(KeyCode.R) && button_Switch == true)
        {
            
            Porte.transform.Rotate(0f,45f,0f);
            
        }
        //Porte.transform.Rotate(90f,0f,0f);
    }
    
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player" && check == false)
        {
            
            E_Porte.SetActive(true);
            button_Switch = true;
            
            
            
        } 
        
        
    
}
}
