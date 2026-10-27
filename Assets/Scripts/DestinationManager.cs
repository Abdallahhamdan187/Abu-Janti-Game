
using UnityEngine;

public class DestinationManager : MonoBehaviour
{
   
    public Transform car;
    public GameObject currentcapsule; 
    public GameObject currentcapsule2;
    public GameObject currentcapsule3;
    private LevelManager3 levelManager;
    private OnCollitionCharacter character;
    private OnCollitionCharacter2 character2;
    private Deliveringlevle3 del;
    

    private bool firstdeliverd = false;
    private bool secdeliverd = false;
    void Start()
    {

        character = FindAnyObjectByType<OnCollitionCharacter>();
        character2 = FindAnyObjectByType<OnCollitionCharacter2>();
        levelManager = FindAnyObjectByType<LevelManager3>();
        del= FindAnyObjectByType<Deliveringlevle3>();

        if (currentcapsule !=null) {
            currentcapsule.SetActive(false);
        }
        if (currentcapsule2 != null)
        {

            currentcapsule2.SetActive(false);
        }if (currentcapsule3 != null)
        {

            currentcapsule3.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Slash) && currentcapsule != null&& !firstdeliverd)
        {
            currentcapsule.SetActive(true);
        }

        if (character !=null&&character.deleverd&&! firstdeliverd) {
            firstdeliverd = true;
        }

        if (firstdeliverd  && Input.GetKeyDown(KeyCode.Slash)&& currentcapsule2 != null)
        {
            currentcapsule2.SetActive(true);       
        }

        if (character2 != null && character2.deleverd2 && !secdeliverd)
        {
            secdeliverd = true;
        }

        if (secdeliverd&&Input.GetKeyDown(KeyCode.Slash)) 
        {
            currentcapsule3.SetActive(true);
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (currentcapsule != null)
        {
            currentcapsule.SetActive(false);
        }
        if (currentcapsule2 != null)
        {
            currentcapsule2.SetActive(false);
        }
        if (currentcapsule3 != null)
        {
            currentcapsule3.SetActive(false);
        }
    }
}
