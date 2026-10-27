using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollitionCharacter : MonoBehaviour
{
    public float money;
    
    private AudioSource moneysound;
    public AudioClip moneyclip;
    private float earnedMoney;
    public bool deleverd=false;
    
    

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
        if (collision.gameObject.CompareTag("Character4")|| collision.gameObject.CompareTag("Character2"))
        {
            earned();
            deleverd = true;
            Debug.Log("Money earned: " + money);
            moneysound.PlayOneShot(moneyclip);
            
        }
    }
   
    public void earned() {
         earnedMoney = Random.Range(2, 10);
            money += earnedMoney;
    } 
    
    
    

}





