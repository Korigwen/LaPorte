using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotation : MonoBehaviour
{

    public GameObject Character;
    public GameObject Porte;
    private float constante;
    private float x;
    private float y;
    private float z;
    private float r;
    private float a;
    private float b;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        constante = Porte.transform.position.z - z;
    //Get Character Pos'
       x = Character.transform.position.x;
       y = Character.transform.position.y;
       z = Character.transform.position.z;
    //Get Porte Pos'
    
      
    
    //Variables pour la rotation de la camera  
       a = (Porte.transform.position.z - z)/constante; //ESSAYER INVERSER PORTE/CHARACter
       b = (Porte.transform.position.x - x) / constante;
       this.transform.localEulerAngles = new Vector3(a,b*10,0);
    }
}
    