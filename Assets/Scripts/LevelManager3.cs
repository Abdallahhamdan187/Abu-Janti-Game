using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager3 : MonoBehaviour
{

    private int totalcus = 3;
    public int cusdeliverd = 0;
    public OnCollitionCharacter character;
    public OnCollitionCharacter2 character2;
    public OnCollitionCharacter3 character3;
    private void Start()
    {
       
        character = FindAnyObjectByType<OnCollitionCharacter>();
        character2 = FindAnyObjectByType<OnCollitionCharacter2>();
        character3 = FindAnyObjectByType<OnCollitionCharacter3>();
    }
    // Update is called once per frame
    void Update()
    {
        if (character.deleverd == true)
        {
           
            cusdeliverd=1;

            Debug.Log("deleverd1");

            if (character2.deleverd2 == true)
            {
                Debug.Log("deleverd2");
                cusdeliverd=2;
                
                if (character3.deleverd3 == true) {
                    cusdeliverd=3;
                    Debug.Log("deleverd3");

                    if (cusdeliverd >= totalcus)
                    {

                        StartCoroutine(delaynext(5f));

                    } 
                }

            }

        }
    }
            public IEnumerator delaynext(float delay)
            {
            
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

        
        
    

