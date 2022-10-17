using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheatSheet : MonoBehaviour
{

    public TMPro.TMP_Dropdown stage, level, star;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CompleteAllStage()
    {
        PlayerPrefs.SetFloat("lvl1star", 3);
        PlayerPrefs.SetFloat("lvl2star", 3);
        PlayerPrefs.SetFloat("lvl3star", 3);
        PlayerPrefs.SetFloat("lvl4star", 3);
        PlayerPrefs.SetFloat("lvl5star", 3);
        PlayerPrefs.SetFloat("lvl6star", 3);
        PlayerPrefs.SetFloat("lvl7star", 3);
        PlayerPrefs.SetFloat("lvl8star", 3);
        PlayerPrefs.SetFloat("lvl9star", 3);
    }
    public void SubmitCheat()
    {
        // Stage 1
        if (stage.captionText.text == "Stage 1")
        {
            // Level 1
            if (level.captionText.text == "Level 1" && star.captionText.text == "Star 1")
            {
                PlayerPrefs.SetFloat("lvl1star", 1);
            }
            if (level.captionText.text == "Level 1" && star.captionText.text == "Star 2")
            {
                PlayerPrefs.SetFloat("lvl1star", 2);
            }
            if (level.captionText.text == "Level 1" && star.captionText.text == "Star 3")
            {
                PlayerPrefs.SetFloat("lvl1star", 3);
            }
            // Level 2
            if (level.captionText.text == "Level 2" && star.captionText.text == "Star 1")
            {
                PlayerPrefs.SetFloat("lvl2star", 1);
            }
            if (level.captionText.text == "Level 2" && star.captionText.text == "Star 2")
            {
                PlayerPrefs.SetFloat("lvl2star", 2);
            }
            if (level.captionText.text == "Level 2" && star.captionText.text == "Star 3")
            {
                PlayerPrefs.SetFloat("lvl2star", 3);
            }
            // Level 3
            if (level.captionText.text == "Level 3" && star.captionText.text == "Star 1")
            {
                PlayerPrefs.SetFloat("lvl3star", 1);
            }
            if (level.captionText.text == "Level 3" && star.captionText.text == "Star 2")
            {
                PlayerPrefs.SetFloat("lvl3star", 2);
            }
            if (level.captionText.text == "Level 3" && star.captionText.text == "Star 3")
            {
                PlayerPrefs.SetFloat("lvl3star", 3);
            }

        }
        // Stage 2
        if (stage.captionText.text == "Stage 2")
        {
            // Level 1
            if (level.captionText.text == "Level 1" && star.captionText.text == "Star 1")
            {
                PlayerPrefs.SetFloat("lvl4star", 1);
            }
            if (level.captionText.text == "Level 1" && star.captionText.text == "Star 2")
            {
                PlayerPrefs.SetFloat("lvl4star", 2);
            }
            if (level.captionText.text == "Level 1" && star.captionText.text == "Star 3")
            {
                PlayerPrefs.SetFloat("lvl4star", 3);
            }
            // Level 2
            if (level.captionText.text == "Level 2" && star.captionText.text == "Star 1")
            {
                PlayerPrefs.SetFloat("lvl5star", 1);
            }
            if (level.captionText.text == "Level 2" && star.captionText.text == "Star 2")
            {
                PlayerPrefs.SetFloat("lvl5star", 2);
            }
            if (level.captionText.text == "Level 2" && star.captionText.text == "Star 3")
            {
                PlayerPrefs.SetFloat("lvl5star", 3);
            }
            // Level 3
            if (level.captionText.text == "Level 3" && star.captionText.text == "Star 1")
            {
                PlayerPrefs.SetFloat("lvl6star", 1);
            }
            if (level.captionText.text == "Level 3" && star.captionText.text == "Star 2")
            {
                PlayerPrefs.SetFloat("lvl6star", 2);
            }
            if (level.captionText.text == "Level 3" && star.captionText.text == "Star 3")
            {
                PlayerPrefs.SetFloat("lvl6star", 3);
            }
        }
        // Stage 3
        if (stage.captionText.text == "Stage 3")
        {
            // Level 1
            if (level.captionText.text == "Level 1" && star.captionText.text == "Star 1")
            {
                PlayerPrefs.SetFloat("lvl7star", 1);
            }
            if (level.captionText.text == "Level 1" && star.captionText.text == "Star 2")
            {
                PlayerPrefs.SetFloat("lvl7star", 2);
            }
            if (level.captionText.text == "Level 1" && star.captionText.text == "Star 3")
            {
                PlayerPrefs.SetFloat("lvl7star", 3);
            }
            // Level 2
            if (level.captionText.text == "Level 2" && star.captionText.text == "Star 1")
            {
                PlayerPrefs.SetFloat("lvl8star", 1);
            }
            if (level.captionText.text == "Level 2" && star.captionText.text == "Star 2")
            {
                PlayerPrefs.SetFloat("lvl8star", 2);
            }
            if (level.captionText.text == "Level 2" && star.captionText.text == "Star 3")
            {
                PlayerPrefs.SetFloat("lvl8star", 3);
            }
            // Level 3
            if (level.captionText.text == "Level 3" && star.captionText.text == "Star 1")
            {
                PlayerPrefs.SetFloat("lvl9star", 1);
            }
            if (level.captionText.text == "Level 3" && star.captionText.text == "Star 2")
            {
                PlayerPrefs.SetFloat("lvl9star", 2);
            }
            if (level.captionText.text == "Level 3" && star.captionText.text == "Star 3")
            {
                PlayerPrefs.SetFloat("lvl9star", 3);
            }
        }
        Debug.Log(stage.captionText.text + " " + level.captionText.text + " Added " + star.captionText.text);
    }
}
