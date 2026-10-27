using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerapos : MonoBehaviour
{
    public Transform target; 
    public Vector3 offset;   

    void LateUpdate()
    {
        

        
        transform.position = target.position + target.rotation * offset;

       
        transform.rotation = target.rotation;

      
        transform.LookAt(target);
    }
}
