    
using UnityEngine;


public class Deliveringlevle3 : MonoBehaviour
{

    public GameObject characterPrefab;
    public GameObject characternolight;

    public GameObject characterPrefab2;
    public GameObject characternolight2;

    public GameObject characterPrefab3;
    public GameObject characternolight3;

    private GameObject activeCharacter; 

    public Transform exitPoint;
    public Transform destination;
    public Transform destination2;
    public Transform destination3;
    public Transform taxi;

    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public Transform spawnPoint3;
  

    
    public float characterSpeed = 2f;

 
    private bool outcar = false;
   
   

    public uimanager3 uiManager;
    public OnCollitionCharacter delvered1;
    public OnCollitionCharacter2 delvered2;
    public OnCollitionCharacter3 delvered3;
    public LevelManager3 levelManager;

    public bool seccared = false;
    public bool thrcared = false;


    private void Start()
    {

       
        uiManager = FindObjectOfType<uimanager3>();
        delvered1 = FindFirstObjectByType<OnCollitionCharacter>();
        delvered2=FindAnyObjectByType<OnCollitionCharacter2>(); 
        delvered3=FindAnyObjectByType<OnCollitionCharacter3>();

        levelManager =FindAnyObjectByType<LevelManager3>();

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


    public void SpawnCharacter()
    {
        if (levelManager.cusdeliverd==0)
        {

            activeCharacter = Instantiate(characterPrefab, spawnPoint1.position, spawnPoint1.rotation);

            uiManager.SetInstructions("Press (/) to make the customer walk to the car. and search for big laser with particles this is your destination");

        }
        else if (levelManager.cusdeliverd == 1)
        {

            activeCharacter = Instantiate(characterPrefab2, spawnPoint2.position, spawnPoint2.rotation);

            uiManager.SetInstructions("Press (/) to make the customer walk to the car. and search for big laser with particles this is your destination");

        } else if (levelManager.cusdeliverd == 2) {

            activeCharacter = Instantiate(characterPrefab3, spawnPoint3.position, spawnPoint3.rotation);

            uiManager.SetInstructions("Press (/) to make the customer walk to the car. and search for big laser with particles this is your destination");
        }
        outcar = false;
    }
    void MoveToCar()
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
        if (delvered2.deleverd2==true) {
            thrcared = true;
        }
        else {
            thrcared = false;
        }
    }
    void ExitCar()
    {

        if (levelManager.cusdeliverd == 0)
        {
            activeCharacter = Instantiate(characternolight, exitPoint.position, destination.rotation);

            outcar = true;
        }
        else if (levelManager.cusdeliverd == 1)
        {
            activeCharacter = Instantiate(characternolight2, exitPoint.position, exitPoint.rotation);
            outcar = true;

        }
        else if (levelManager.cusdeliverd == 2) {
            activeCharacter = Instantiate(characternolight3, exitPoint.position, exitPoint.rotation);
            outcar = true;
        }
       
    }
    
    void WalkToDestination()
    {
        if (levelManager.cusdeliverd == 0)
        {
            activeCharacter.transform.position = Vector3.MoveTowards(activeCharacter.transform.position, destination.position, characterSpeed * Time.deltaTime);

            if (delvered1.deleverd)
            {

                outcar = false;
                uiManager.SetInstructions("First customer delivered! Press (P) to spawn the second customer.");

                Destroy(activeCharacter);
            }
        }
        else if (levelManager.cusdeliverd == 1)
        {

            activeCharacter.transform.position = Vector3.MoveTowards(activeCharacter.transform.position, destination2.position, characterSpeed * Time.deltaTime);

            
            if (delvered2.deleverd2)
            {

                outcar = false;
                uiManager.SetInstructions("Second customer delivered.Press (P) to spawn the second customer.");
                Destroy(activeCharacter);
            }
        }
        else if (levelManager.cusdeliverd == 2) {

            activeCharacter.transform.position = Vector3.MoveTowards(activeCharacter.transform.position, destination3.position, characterSpeed * Time.deltaTime);


            if (delvered3.deleverd3)
            {

                outcar = false;
                uiManager.SetInstructions("Thrid customer delivered! Level complete.Game Finished");
                Destroy(activeCharacter);
            }
        }

    }            
}               




 


