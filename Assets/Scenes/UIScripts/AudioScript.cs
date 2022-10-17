using UnityEngine.Audio;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public Sound[] sound;
    public float volume;
    public GameObject audioSource;
    bool soundToggle = true;
    public GameObject enable, disable, check, uncheck;
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
    
    public void OnVolume()
    {
        soundToggle = !soundToggle;
        if (soundToggle)
        {
            //audioSource.SetActive(true);
            //audioSource.mute = true;
            enable.SetActive(true);
            check.SetActive(true);
            disable.SetActive(false);
            uncheck.SetActive(false);
            AudioListener.volume = 1.0f;
        }
        else
        {
            disable.SetActive(true);
            uncheck.SetActive(true);
            enable.SetActive(false);
            check.SetActive(false);
            //audioSource.mute = false;
            AudioListener.volume = 0.0f;
        }
    }
}
