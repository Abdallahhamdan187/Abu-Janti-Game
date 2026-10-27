using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollitionCharacter3 : MonoBehaviour
{
   
    public float money3;
    private AudioSource moneysound;
    public AudioClip moneyclip;
    private float earnedMoney;
   
    public bool deleverd3=false;
    

    // Start is called before the first frame update
    void Start()
    {
        moneysound = GetComponent<AudioSource>();
          
    }

    // Update is called once per frame
    
    void Update()
    {
        
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
            if (collision.gameObject.CompareTag("Character4"))
        {
            earned3();
            deleverd3 = true;
            Debug.Log("Money earned: " + money3);
            moneysound.PlayOneShot(moneyclip);
            
        }
        
       
    }
    public void earned3() {
         earnedMoney = Random.Range(2, 10);
        money3 += earnedMoney;
    }

    
    

}





