using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResultScript : MonoBehaviour
{
    public TMP_Text Resulttext;
    public GameObject QuestionPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowResult(string result){
        Resulttext.text = result;
    }
    public void HideGo(){
        GetComponentInParent<MonsterQuestionManager>().ShowQuestion();
        QuestionPanel.SetActive(false);
        gameObject.SetActive(false);
    }
}
