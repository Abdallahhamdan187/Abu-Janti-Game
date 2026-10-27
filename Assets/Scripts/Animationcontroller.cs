
using UnityEngine;

public class Animationcontroller : MonoBehaviour
{
  
     Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        ani = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Slash)|| Input.GetKey(KeyCode.Period)) {

            ani.SetBool("IsWalking", true);
        }
        else {

            ani.SetBool("IsWalking", false);
        }
        
    }
    
}
