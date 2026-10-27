using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    private int totalcus = 1;
    private int cusdeliverd = 0;
    public OnCollitionCharacter character;
    private void Start()
    {
        character = FindAnyObjectByType<OnCollitionCharacter>();

    }
    // Update is called once per frame
    void Update()
    {
        if (character.deleverd == true) {

            cusdeliverd++;
            character.deleverd = false;
            if (cusdeliverd >= totalcus)
            {

                StartCoroutine(delaynext(5f));

            }
            else {
                FindObjectOfType<Delivering>().SpawnCharacter();

            } 
        } 
        }
    public IEnumerator delaynext(float delay)
    {

        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

        
        
    

