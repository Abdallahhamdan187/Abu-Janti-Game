
using Unity.VisualScripting;
using UnityEngine;

public class Delivering : MonoBehaviour
{

    public GameObject characterPrefab;
    public GameObject characternolight;
    private GameObject activeCharacter;

    public Transform exitPoint;
    public Transform destination;
    public Transform taxi;

    public Transform spawnPoint1;
   
  

    
    public float characterSpeed = 2f;

    private bool InCar = false;
    private bool outcar = false;
    bool spawned = false;
    bool cared = false;
   

    public UiManager uiManager;
    public OnCollitionCharacter character;
    


    private void Start()
    {
        
       
        uiManager = FindObjectOfType<UiManager>();
        character = FindObjectOfType<OnCollitionCharacter>();

        uiManager.SetInstructions("Press (P) to have a customer.");
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.P) && activeCharacter == null)
        {
            SpawnCharacter();
            spawned = true;


        }
        if (Input.GetKey(KeyCode.Slash) && activeCharacter != null && !InCar)
        {
            MoveToCar();
            cared = true;
        }
        if (Input.GetKeyDown(KeyCode.Period) && !outcar && spawned && cared)
        {
            ExitCar();

        }
        
        if (activeCharacter != null && outcar)
        {
            WalkToDestination();
        }
    }

   
    public void SpawnCharacter()
    {
        
        
            activeCharacter = Instantiate(characterPrefab, spawnPoint1.position, spawnPoint1.rotation);
            outcar = false;
            uiManager.SetInstructions("Press (/) to make the customer walk to the car. and search for big laser with particals this is your destination");
        
       
    }
    void MoveToCar()
    {
        activeCharacter.transform.position = Vector3.MoveTowards(activeCharacter.transform.position,taxi.position,
        characterSpeed * Time.deltaTime);
       
        uiManager.SetInstructions("Press (.) to make the customer leave the car.");

    }
    void ExitCar()
    {
        activeCharacter = Instantiate(characternolight, exitPoint.position, destination.rotation);
        outcar = true;

    }
    
    void WalkToDestination()
    {
        if (destination != null)
        {
            activeCharacter.transform.position = Vector3.MoveTowards(activeCharacter.transform.position, destination.position, characterSpeed * Time.deltaTime);
           
            if (character.deleverd) {
                uiManager.SetInstructions("First customer delivered! Level complete.Loading level two");
            }
        }            
    }
}               




 


