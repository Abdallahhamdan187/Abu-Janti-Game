using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Finished : MonoBehaviour
{
    [SerializeField] Button Home;
    [SerializeField] Slider volume;
    [SerializeField] private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        volume.value= audioSource.volume;
        volume.onValueChanged.AddListener(slidersound);
    }

    // Update is called once per frame
    public void pressthebutton()
    {

        SceneManager.LoadScene("Home");
    }
    public void slidersound(float value) {

        audioSource.volume = value;

    }
    public void levelone() {
        SceneManager.LoadScene("Level1");
    }
}
