using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MonsterQuestionManager : MonoBehaviour
{
    public TMP_Text questiontext;
    public List<Transform> allquestions;
    public string operation;
    public int questionidtoshow;
    public GameObject ResultPanel;
    public bool powerupactivated;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child in transform){
            if(child!=null&&child.tag=="Question"){
                allquestions.Add(child);
            }
        }
        ShowQuestion();
    }

    public void FreezeTime()
    {
        powerupactivated = true;
    }

    public void FreezeTimeOff()
    {
        powerupactivated = false;
    }

    public void PowerUpsEffect()
    {
        FreezeTime();
    }

    public void ShowQuestion(){
        if (allquestions.Count > 0)
        {
            questionidtoshow = Random.Range(0, allquestions.Count);
            allquestions[questionidtoshow].gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RemoveQuestion(GameObject question){
        allquestions.Remove(question.transform);
        ResultPanel.SetActive(true);
        Destroy(question);
    }
}
