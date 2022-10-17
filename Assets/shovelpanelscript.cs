using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class shovelpanelscript : MonoBehaviour
{
    public TMP_Text shovelpanelcaptiontext, closebtntxt;
    public GameObject[] allshovels;
    public GameObject closebtn, nextbtn, GameManager;

    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ShovelAlert();
    }

    public void ShovelAlert(){
        if (GameManager.GetComponent<ScoreManager>().monsterleft > 0)
        {
            if (GameObject.FindGameObjectsWithTag("goldenshovel") != null)
            {
                allshovels = GameObject.FindGameObjectsWithTag("goldenshovel");
                //Debug.Log(allshovels.Length);
                closebtn.SetActive(true);
                nextbtn.SetActive(false);
                closebtntxt.GetComponentInChildren<TMP_Text>().text = "Okay";
                shovelpanelcaptiontext.text = "There are still ".ToUpper() + allshovels.Length.ToString() + " Shovels and ".ToUpper() + GameManager.GetComponent<ScoreManager>().monsterleft + " Monsters left.".ToUpper();
            }
            if (allshovels.Length <= 0)
            {
                //Debug.Log("noshovelsleft");
                closebtn.SetActive(false);
                nextbtn.SetActive(true);
                shovelpanelcaptiontext.text = "There are no shovels left. Proceed to next level?".ToUpper();
            }
        }
        else if (GameManager.GetComponent<ScoreManager>().monsterleft == 0)
        {
            if (GameObject.FindGameObjectsWithTag("goldenshovel") != null)
            {
                allshovels = GameObject.FindGameObjectsWithTag("goldenshovel");
                //Debug.Log(allshovels.Length);
                closebtn.SetActive(true);
                nextbtn.SetActive(true);
                shovelpanelcaptiontext.text = "There are still ".ToUpper() + allshovels.Length.ToString() + " Shovels left.".ToUpper();
            }
            if (allshovels.Length <= 0)
            {
                //Debug.Log("noshovelsleft");
                closebtn.SetActive(false);
                nextbtn.SetActive(true);
                shovelpanelcaptiontext.text = "There are no shovels left. Proceed to next level?".ToUpper();
            }
        } 
        else
        {
            if (GameObject.FindGameObjectsWithTag("goldenshovel") != null)
            {
                allshovels = GameObject.FindGameObjectsWithTag("goldenshovel");
                //Debug.Log(allshovels.Length);
                closebtn.SetActive(true);
                nextbtn.SetActive(false);
                closebtntxt.GetComponentInChildren<TMP_Text>().text = "Okay";
                shovelpanelcaptiontext.text = "There are still ".ToUpper() + allshovels.Length.ToString() + " Shovels and ".ToUpper() + GameManager.GetComponent<ScoreManager>().monsterleft + " Monsters left.".ToUpper();
            }
            if (allshovels.Length <= 0)
            {
                //Debug.Log("noshovelsleft");
                closebtn.SetActive(false);
                nextbtn.SetActive(true);
                shovelpanelcaptiontext.text = "There are no shovels left. Proceed to next level?".ToUpper();
            }
        }
        GameManager.GetComponentInParent<ScoreManager>().monsterpanel.text = "Monster Left: " + GameManager.GetComponent<ScoreManager>().monsterleft + "\n Shovel Left: " + allshovels.Length.ToString();
    }

}
