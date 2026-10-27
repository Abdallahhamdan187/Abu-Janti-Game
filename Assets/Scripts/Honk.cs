using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Honk : MonoBehaviour
{
    public AudioClip honk;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.loop = true;
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKey(KeyCode.F))
        {
            if (!audioSource.isPlaying)
            {
                audioSource.clip = honk;
                audioSource.Play();
            }
        }
        else if (Input.GetKeyUp(KeyCode.F))
        {
            audioSource.Stop();
        }
    }
}
