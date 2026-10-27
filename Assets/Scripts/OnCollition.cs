
using UnityEngine;

public class OnCollition : MonoBehaviour
{
    
    
     

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
          
        }
        else if (!gameObject.CompareTag("Player"))
        {
           
            Destroy(gameObject);
        }
        
    }

   
   
        
    
}
