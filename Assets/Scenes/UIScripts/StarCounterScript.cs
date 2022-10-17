using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StarCounterScript : MonoBehaviour
{
    public float numberofstar;
    public string level;
    public Image[] stars;
    public Button stagentobeunlocked;
    // Start is called before the first frame update
    void Start()
    {
        numberofstar = PlayerPrefs.GetFloat(level);
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.H)){
        Debug.Log(PlayerPrefs.GetFloat(level));
        }
        switch (numberofstar)
        {
            case 0:
                break;
            case 1:
                stars[0].color = new Color(255,255,255,1);
                stagentobeunlocked.interactable = true;
                break;
            case 2:
                stars[0].color = new Color(255, 255, 255, 1);
                stars[1].color = new Color(255, 255, 255, 1);
                stagentobeunlocked.interactable = true;
                break;
            case 3:
                stars[0].color = new Color(255, 255, 255, 1);
                stars[1].color = new Color(255, 255, 255, 1);
                stars[2].color = new Color(255, 255, 255, 1);
                //if (stagentobeunlocked!=null)
                //{
                    stagentobeunlocked.interactable = true;
                //}
                break;
        }
    }
}
