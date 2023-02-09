using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public Transform teleportTarget;
    public GameObject Player;
    public float timeLeft;
    public GameObject Porte;
    private bool x = false;
    
    
    void OnTriggerEnter(Collider other){
    
        Player.transform.position = teleportTarget.transform.position;
        Debug.Log("Teleport_Check");
        x = true;
    }
    
    
    void Update(){
    
    if(x==true){
    activationPorte();
    
    }
    
    }
    
    void activationPorte(){
    
    timeLeft -= Time.deltaTime;
    Debug.Log("TimeStart");
    
    if(timeLeft < 0){
    Debug.Log("Time<0");
    Porte.SetActive(true);
    
    }
    
    }
    
}
