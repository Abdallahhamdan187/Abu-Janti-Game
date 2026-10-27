
using UnityEngine;

using TMPro;


public class uimanager3 : MonoBehaviour
{
    [SerializeField] TMP_Text speedtxt;
    [SerializeField] TMP_Text monneytxt;
    [SerializeField] TMP_Text insttxxt;
  
    private Taxicontroller taxi;
    private OnCollitionCharacter taximoney;
    private OnCollitionCharacter2 taximoney2;
    private OnCollitionCharacter3 taximoney3;
    void Start()
    {
        taxi=FindAnyObjectByType<Taxicontroller>();
        taximoney= FindAnyObjectByType<OnCollitionCharacter>();
        taximoney2= FindAnyObjectByType<OnCollitionCharacter2>();
        taximoney3= FindAnyObjectByType<OnCollitionCharacter3>();
        updateui();
    }

    // Update is called once per frame
   public void Update()
    {
        
        updatespeed();
        updatemoney();
    }

    void updatemoney()
    {
        float totalmoney = taximoney.money + taximoney2.money2 +taximoney3.money3;
        monneytxt.text = $"Money: {totalmoney:F1} JD";
    }

    void updatespeed()
    {
        speedtxt.text = $"Speed: {taxi.speed:F1}";
    }

    public void SetInstructions(string instructions)
    {
        insttxxt.text = instructions;
    }

    void updateui()
    {
        updatemoney();
        updatespeed();
        SetInstructions("Press P to get the customer, / to walk to the car, and . to leave the car.");
    }
}