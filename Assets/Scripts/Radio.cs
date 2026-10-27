using UnityEngine;

public class Radio : MonoBehaviour
{
    public AudioSource radioAudioSource;   
    public AudioClip[] songs;             
    private bool isRadioOn = false;       
    private int currentSongIndex = 0;     

    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.RightBracket))  
        {
            if (!isRadioOn)  
            {
                PlayRadio();
            }
            else
            {
                ChangeSong();  
            }
        }

        
        if (Input.GetKeyDown(KeyCode.LeftBracket)) 
        {
            if (isRadioOn) 
            {
                StopRadio();
            }
        }
    }


    void PlayRadio()
    {
        if (songs.Length == 0) return;

        isRadioOn = true;
        radioAudioSource.PlayOneShot(songs[currentSongIndex]);
    }

    void ChangeSong()
    {
        if (songs.Length == 0) return;

        currentSongIndex++;
        if (currentSongIndex >= songs.Length)
        {
            currentSongIndex = 0;
        }

        radioAudioSource.Stop();
        radioAudioSource.PlayOneShot(songs[currentSongIndex]);
    }


   void StopRadio()
    {
        radioAudioSource.Stop();  
        isRadioOn = false;      
    }
}
