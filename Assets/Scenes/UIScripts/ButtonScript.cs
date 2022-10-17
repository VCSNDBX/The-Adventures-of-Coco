using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public GameObject mainPanel;
    public GameObject settingsPanel, cheatPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void ResetStage()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetFloat("istutorialdone", 0);
        PlayerPrefs.SetFloat("isDialogdone", 0);
        SceneManager.LoadScene("Dialogue");
        Debug.Log("Restore all data to 0");
        /*if(Input.GetKey(KeyCode.F)){
            PlayerPrefs.DeleteAll();
        }*/
    }

    public void Settings()
    {
        mainPanel.SetActive(false);
        settingsPanel.SetActive(true);
        cheatPanel.SetActive(false);
    }

    public void BackToMain()
    {
        mainPanel.SetActive(true);
        settingsPanel.SetActive(false);
        cheatPanel.SetActive(false);
    }

    public void CheatMenu()
    {
        mainPanel.SetActive(false);
        settingsPanel.SetActive(false);
        cheatPanel.SetActive(true);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ShowImage(Image imagetoshow)
    {
        imagetoshow.gameObject.SetActive(true);
    }
    public void HideImage(Image imagetohide)
    {
        imagetohide.gameObject.SetActive(false);
    }

    public void Quit(){
        Application.Quit();
    }
    public void ChangeScene()
    {
        if (PlayerPrefs.GetFloat("isDialogdone") == 1)
        {
            SceneManager.LoadScene("StageSelection");
        } else
        {
            SceneManager.LoadScene("Dialogue");
        }
    }

    public void SelectScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

}
