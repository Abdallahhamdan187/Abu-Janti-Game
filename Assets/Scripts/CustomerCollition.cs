using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerCollition : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.CompareTag("Character"))
        {
            Destroy(collision.gameObject); 
            
        }
    }
}
