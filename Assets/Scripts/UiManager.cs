
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UiManager : MonoBehaviour
{
    [SerializeField] TMP_Text speedtxt;
    [SerializeField] TMP_Text monneytxt;
    [SerializeField] TMP_Text insttxxt;

        
    
    
    
    private Taxicontroller taxi;
    private OnCollitionCharacter taximoney;
    
    void Start()
    {
        taxi=FindAnyObjectByType<Taxicontroller>();
        taximoney= FindAnyObjectByType<OnCollitionCharacter>();
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
     
        UpdateSpeedUI();
        UpdateMoneyUI();
    }

    void UpdateMoneyUI()
    {
       
        monneytxt.text = $"Money: {taximoney.money:F1} JD";
    }

    void UpdateSpeedUI()
    {
        speedtxt.text = $"Speed: {taxi.speed:F1}";
    }

    public void SetInstructions(string instructions)
    {
        insttxxt.text = instructions;
    }

    void UpdateUI()
    {
        UpdateMoneyUI();
        UpdateSpeedUI();
        SetInstructions("Press P to get the customer, / to walk to the car, and . to leave the car.");
    }
}