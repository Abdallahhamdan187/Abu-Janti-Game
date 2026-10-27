using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager2 : MonoBehaviour
{

    private int totalcus = 2;
    private int cusdeliverd = 0;
    public OnCollitionCharacter character;
    public OnCollitionCharacter2 character2;
    private void Start()
    {
        character2 = FindAnyObjectByType<OnCollitionCharacter2>();
        character = FindAnyObjectByType<OnCollitionCharacter>();

    }
    // Update is called once per frame
    void Update()
    {
        if (character.deleverd == true)
        {
            Debug.Log("deleverd1");
            cusdeliverd++;

            if (character2.deleverd2 == true)
            {
                Debug.Log("deleverd2");
                cusdeliverd++;

                if (cusdeliverd >= totalcus)
                {

                    StartCoroutine(delaynext(5f));

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

        
        
    

