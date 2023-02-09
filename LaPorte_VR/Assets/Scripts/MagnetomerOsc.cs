using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetomerOsc : MonoBehaviour
{
    public OSC osc;
    private float x;
    //private float previousX;
    //private LowPassFilter filter = new LowPassFilter(0.1f);
    
    void Start(){
        osc.SetAddressHandler("/magneticfield", OnReceiveMagneticFiled);
        
    }
    

    void OnReceiveMagneticFiled(OscMessage message)
    {
        float x = message.GetFloat(2);
        
    
        

        Vector3 rot = transform.localEulerAngles;
        rot.y = ((x + 12) / 30) * 110;
        transform.localEulerAngles = rot;
    
        
       
        
    }
    
}
