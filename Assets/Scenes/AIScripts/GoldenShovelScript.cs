using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GoldenShovelScript : MonoBehaviour
{
    public TMP_Text numberofshoveltext;
    public GameObject shovelpanel, timer, poweractive;
    private GameObject player;
    public MonsterQuestionManager mqm;
    GameObject[] allshovels;
    
    // Start is called before the first frame update
    void Start()
    {
        numberofshoveltext.text = PlayerPrefs.GetFloat("numberofshovel").ToString();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag=="Player")
        {
            PlayerPrefs.SetFloat("numberofshovel", PlayerPrefs.GetFloat("numberofshovel") + 10);
            numberofshoveltext.text = PlayerPrefs.GetFloat("numberofshovel").ToString();
            if (PlayerPrefs.GetFloat("numberofshovel") >= 50)
            {
                PlayerPrefs.SetFloat("numberofshovel", PlayerPrefs.GetFloat("numberofshovel") - 50);
                numberofshoveltext.text = PlayerPrefs.GetFloat("numberofshovel").ToString();
                //mqm.FreezeTime(); 
                Destroy(gameObject);
                //poweractive.SetActive(true);
                //timer.SetActive(true);
                //Debug.Log("ACTIVATED " + PlayerPrefs.GetFloat("numberofshovel").ToString());
            } else
            {
                
                shovelpanel.SetActive(true);
                Destroy(gameObject);
                Debug.Log("ADDED " + PlayerPrefs.GetFloat("numberofshovel").ToString());
            }
        }
    }
}
