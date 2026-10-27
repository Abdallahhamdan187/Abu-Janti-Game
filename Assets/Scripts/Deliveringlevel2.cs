
using UnityEngine;


public class Deliveringlevle2 : MonoBehaviour
{

    public GameObject characterPrefab;
    public GameObject characternolight;
    public GameObject characterPrefab2;
    public GameObject characternolight2;
    private GameObject activeCharacter;

    public Transform exitPoint;
    public Transform destination;
    public Transform destination2;
    public Transform taxi;

    public Transform spawnPoint1;
    public Transform spawnPoint2;
  

    
    public float characterSpeed = 2f;

 
    private bool outcar = false;
    private bool deliveredfirst = false;
   

    public uimanager2 uiManager;
    public OnCollitionCharacter delvered1;

    public bool seccared = false;


    private void Start()
    {

       
        uiManager = FindObjectOfType<uimanager2>();
        delvered1 = FindFirstObjectByType<OnCollitionCharacter>();

        uiManager.SetInstructions("Press (P) to have a customer.");
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.P) && activeCharacter == null)
        {
            SpawnCharacter();
            

        }
        if (Input.GetKey(KeyCode.Slash) && activeCharacter != null)
        {
            
            MoveToCar();
            
        }
        if (Input.GetKeyDown(KeyCode.Period) && !outcar )
        {
            ExitCar();

        }
        
        if (activeCharacter != null && outcar)
        {
            WalkToDestination();
        }
    }


    public void SpawnCharacter()//
    {
        if (!deliveredfirst)
        {
           
            activeCharacter = Instantiate(characterPrefab, spawnPoint1.position, spawnPoint1.rotation);
            
            uiManager.SetInstructions("Press (/) to make the customer walk to the car. and search for big laser with particles this is your destination");
           
        }
        else if (deliveredfirst) 
        {
        
            activeCharacter = Instantiate(characterPrefab2, spawnPoint2.position, spawnPoint2.rotation);
           
            uiManager.SetInstructions("Press (/) to make the customer walk to the car. and search for big laser with particles this is your destination");
            
        }
        outcar = false;
    }
    void MoveToCar()//
    {
        activeCharacter.transform.position = Vector3.MoveTowards(activeCharacter.transform.position,taxi.position,
        characterSpeed * Time.deltaTime);
      
        uiManager.SetInstructions("Press (.) to make the customer leave the car.");
        if (delvered1.deleverd == true)
        {
            seccared = true;
        }
        else {
            seccared = false;
        }
    }
    void ExitCar()//
    {
        
        if (!deliveredfirst)
        {
            activeCharacter = Instantiate(characternolight, exitPoint.position, destination.rotation);

            outcar = true;
        }
        else {
            activeCharacter = Instantiate(characternolight2, exitPoint.position, exitPoint.rotation);
            outcar = true;
        }
       
    }
    
    void WalkToDestination()
    {
        if (!deliveredfirst)
        {
            activeCharacter.transform.position = Vector3.MoveTowards(activeCharacter.transform.position, destination.position, characterSpeed * Time.deltaTime);

            if (delvered1.deleverd)
            {
                deliveredfirst = true; 
                outcar = false;
                uiManager.SetInstructions("First customer delivered! Press (P) to spawn the second customer.");
                
                Destroy(activeCharacter);
            }
        }
        else  
            {

                activeCharacter.transform.position = Vector3.MoveTowards(activeCharacter.transform.position, destination2.position, characterSpeed * Time.deltaTime);


                if (activeCharacter.transform.position==destination2.position)
                {
                    
                    outcar = false;
                    uiManager.SetInstructions("Second customer delivered! Level complete.Loading level three");
                    Destroy(activeCharacter);
                }
        }

    }            
}               




 


