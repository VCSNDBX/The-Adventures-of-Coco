using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CameraBossHolderScript : MonoBehaviour
{
    public GameObject questions;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowQuestions(){
        questions.SetActive(true);
    }
    public void ShowObject(GameObject go){
        go.SetActive(true);
        questions.SetActive(false);
    }
}
