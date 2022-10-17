using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GenerateQuestionScript : MonoBehaviour
{
    private int QuestionNo,inputanswer, timeleftindex;
    public string[] questions,answers;
    public GameObject QuestionPanel,player,enemynearby,StarDisplayPanel;
    public TMP_Text Questiontext,timetext;
    public bool aquestionisgenerated;
    public GameObject[] choices;
    public float TimeLimit;
    public float[] All_TimeLeft;
    public int numberofenemies,numberofquestions;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void ChoicesClick(int answer)
    {
        inputanswer = answer;
    }
    public void AnswerButton()
    {
        if (inputanswer.ToString()==answers[QuestionNo])
        {
            if (All_TimeLeft[timeleftindex]==0)
            {
                All_TimeLeft[timeleftindex] = TimeLimit;
            }
            else
            {
                timeleftindex += 1;
                All_TimeLeft[timeleftindex] = TimeLimit;
            }
            QuestionPanel.SetActive(false);
            choices[QuestionNo].SetActive(false);
            enemynearby.GetComponent<AIScript>().Death();
        }
        else
        {
            player.GetComponent<PlayerStatusScript>().TakeDamage(1);
        }
    }
    public void QuestionTimeLimit()
    {
    }
    public void TimeLimitDuration()
    {
        TimeLimit -= 1*Time.deltaTime;
        timetext.text = Mathf.Round(TimeLimit).ToString();
        if (TimeLimit<=0)
        {
            player.GetComponent<PlayerStatusScript>().TakeDamage(1);
            QuestionPanel.SetActive(false);
        }
    }
    public void GenerateQuestion()
    {
        TimeLimitDuration();
        if (aquestionisgenerated==false)
        {
            TimeLimit = 30;
            QuestionPanel.SetActive(true);
            QuestionNo = Random.Range(0,numberofquestions);
            choices[QuestionNo].SetActive(true);
            Questiontext.text = questions[QuestionNo];
            aquestionisgenerated = true;
        }
    }
}
