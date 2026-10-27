using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taxicontroller : MonoBehaviour
{
    public float speed = 0f;          
    public float maxSpeed = 20f;      
    public float brakingPower = 10f;  
    public float turnSpeed = 50f;     
    

    private int shiftPressCount = 0; 
    private bool shiftPressed = false;
    private const int repairPressCount = 5;  
    private const int breakdownPressCount = 10;
    public AudioSource audioSource;
    public AudioClip revers;

    private void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.loop = true;
    }


    void Update()
    {
        if (speed<0)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.clip = revers;
                audioSource.Play();
            }
        }
        else if (speed>=0)
        {
            audioSource.Stop();
        }
    

        if (Input.GetKey(KeyCode.W))
        {
            if (speed < maxSpeed)
            {
                speed += 5f * Time.deltaTime;
            }
        }
        else
        {
            
            if (speed > 0)
            {
                speed -= 2f * Time.deltaTime;

                
                if (speed < 0)
                {
                    speed = 0;
                }
            }
        }
        if (Input.GetKey(KeyCode.Space))
        {
            if (speed > 0)
            {
                speed -= brakingPower * Time.deltaTime;

               
                if (speed < 0)
                {
                    speed = 0;
                }
            }
        }//----------------------------------------------------------fowrard ----------------------------------------------------
        if (Input.GetKey(KeyCode.S))
        {

            speed -= 5f * Time.deltaTime;

        }
        else
        {
            
            if (speed < 0)
            {
                speed += 2f * Time.deltaTime;

                
                if (speed > 0)
                {
                    speed = 0;
                }
            }
        }

        

        if (Input.GetKey(KeyCode.Space))
        {
            if (speed < 0)
            {
                    {
                        speed += brakingPower * Time.deltaTime;

                        if (speed > 0)
                        {
                            speed = 0;
                        }
                    }
                
            }
        }
        //---------------------------------------------------back-------------------------------------------------------------
            
            if (Input.GetKey(KeyCode.LeftShift))
            {
                if (!shiftPressed)
                {
                    shiftPressed = true; 
                    maxSpeed += 10f;
                   
                }
            }
            else
            {
                
                if (shiftPressed)
                {
                    maxSpeed -= 10; 
                    shiftPressed = false; 
                    
                }
            }
           
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                shiftPressCount++;

                
                if (shiftPressCount >= repairPressCount && shiftPressCount < breakdownPressCount)
                {
                    Debug.Log("The car needs to be repaired!");

                }

                if (shiftPressCount >= breakdownPressCount)
                {
                    Debug.Log("The car has broken down! It is now stopped.");

                    maxSpeed = 10;
                    speed = 0; 
                }
            }

            
            transform.position += transform.right * speed * Time.deltaTime;

            
            if (speed > 0) 
            {
                float turnInput = Input.GetAxis("Horizontal");
                if (turnInput != 0)
                {
                    float turn = turnInput * turnSpeed * Time.deltaTime;
                    transform.Rotate(0, turn, 0);
                }
            }if (speed < 0) 
            {
                float turnInput = Input.GetAxis("Horizontal");
                if (turnInput != 0)
                {
                    float turn = turnInput * turnSpeed * Time.deltaTime;
                    transform.Rotate(0, turn, 0);

                }
            }

        if (Input.GetKey(KeyCode.R)) {
            gameObject.transform.position = new Vector3(-499.2f, 9.5f, 10.02f);
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
            speed = 0;
        }

        }
    


        private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RepairShop")) 
        {
           
                    Debug.Log("Car is being repaired...");
                   
                    shiftPressCount = 0; 
                   
                    maxSpeed = 20;
                   
                    Debug.Log("Car has been repaired");
            
        }
    }


}
