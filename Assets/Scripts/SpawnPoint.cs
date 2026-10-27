using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] GameObject[] charec;
 
   
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", 2f, 4f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void spawn() { 

        int randomindex=Random.Range(0, charec.Length);
        Instantiate(charec[randomindex],transform.position,transform.rotation);
    
    }
}
