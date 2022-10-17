using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StageSelectionManager : MonoBehaviour
{
    public GameObject tutorialpanel;
    public GameObject tutalertpanel;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetFloat("istutorialdone") == 0)
        {
            tutorialpanel.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            PlayerPrefs.SetFloat("lvl1star",3);
            PlayerPrefs.SetFloat("lvl2star",3);
            PlayerPrefs.SetFloat("lvl3star",3);
            PlayerPrefs.SetFloat("lvl4star",3);
            PlayerPrefs.SetFloat("lvl5star",3);
            PlayerPrefs.SetFloat("lvl6star",3);
            PlayerPrefs.SetFloat("lvl7star",3);
            PlayerPrefs.SetFloat("lvl8star",3);
            PlayerPrefs.SetFloat("lvl9star",3);

        }
    }
    public void Tutorialclicked()
    {
        tutorialpanel.SetActive(false);
        tutalertpanel.SetActive(true);
        //PlayerPrefs.SetFloat("istutorialdone", 1);
        //Debug.Log("Tutorial set to " + 1);
    }

    public void TutorialSkip()
    {
        PlayerPrefs.SetFloat("istutorialdone", 1);
        tutalertpanel.SetActive(false);
    }
    
    public void TutorialStart()
    {
        SceneManager.LoadScene("Tutorial");
    }

    void OnAwake()
    {
    }

}
