using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollitionCharacter2 : MonoBehaviour
{
   
    public float money2;
    private AudioSource moneysound;
    public AudioClip moneyclip;
    private float earnedMoney;
   
    public bool deleverd2=false;
    

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
        
            if (collision.gameObject.CompareTag("Character2"))
        {
            earned2();
            deleverd2 = true;
            Debug.Log("Money earned: " + money2);
            moneysound.PlayOneShot(moneyclip);
            
        }
        
       
    }
    public void earned2() {
         earnedMoney = Random.Range(2, 10);
        money2 += earnedMoney;
    }

    
    

}





