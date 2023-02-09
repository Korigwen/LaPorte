using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWorld : MonoBehaviour
{


public GameObject Monde;

    bool check = false;
    bool checkBack = false;
    
 
    
    void delay(){
    
    if(checkBack == true){
    check = true;
    }
    
    }
    
    void delayBack(){
    
    if(checkBack == false){
    check = false;
    }
    
    }
    
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && check == false)
        {
            
            Monde.SetActive(true);
            checkBack = true;
            Invoke("delay",2.5f);
            
            
        }
        if(other.gameObject.tag == "Player" && check == true)
        {
            
            Monde.SetActive(false);
            checkBack = false;
            Invoke("delayBack",2.5f);
            
            
            
        } 
    
    
}
}
