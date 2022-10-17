using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour
{
    public Text TutorialText;
    public GameObject apple, banana, marble, marble2, carrots;
    public GameObject addTxt, equalsTxt, basicaddtext, basicsubtext, basicmultitext, basicdivtext;
    public GameObject congratsTxt, teacherImg, teacherImg2, teacherImg3;

    private Queue<string> sentutortials;

    private void Awake()
    {
        sentutortials = new Queue<string>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DisplayNextTutorial();
        }
    }

    public void StartTutortial(Tutortial tutorial)
    {
        sentutortials.Clear();

        foreach (string sentutorial in tutorial.sentutortials)
        {
            sentutortials.Enqueue(sentutorial);
        }

        DisplayNextTutorial();
    }

    public void DisplayNextTutorial()
    {
        if (sentutortials.Count == 13)
        {
            FindObjectOfType<DialogueSound>().Play("first");
        }
        if (sentutortials.Count == 12)
        {
            FindObjectOfType<DialogueSound>().Stop("first");
            FindObjectOfType<DialogueSound>().Play("second");
        }
        if (sentutortials.Count == 11)
        {
            FindObjectOfType<DialogueSound>().Stop("second");
            teacherImg.SetActive(false);
            teacherImg2.SetActive(true);
            basicaddtext.SetActive(true);
            FindObjectOfType<DialogueSound>().Play("addition");
        }

        if (sentutortials.Count == 10)
        {
            FindObjectOfType<DialogueSound>().Stop("addition");
            teacherImg3.SetActive(true);
            teacherImg2.SetActive(false);
            basicaddtext.SetActive(false);
            addTxt.SetActive(true);
            equalsTxt.SetActive(true);
            apple.SetActive(true);
            FindObjectOfType<DialogueSound>().Play("applex");
        }

        if (sentutortials.Count == 9)
        {
            FindObjectOfType<DialogueSound>().Stop("applex");
            teacherImg3.SetActive(false);
            teacherImg2.SetActive(true);
            addTxt.SetActive(false);
            equalsTxt.SetActive(false);
            apple.SetActive(false);
            FindObjectOfType<DialogueSound>().Play("subtraction");
        }

        if (sentutortials.Count == 8)
        {
            // Subtraction
            FindObjectOfType<DialogueSound>().Stop("subtraction");
            basicsubtext.SetActive(true);
            teacherImg.SetActive(true);
            teacherImg2.SetActive(false);
            FindObjectOfType<DialogueSound>().Play("submean");
        }

        if (sentutortials.Count == 7)
        {
            // Subtraction
            FindObjectOfType<DialogueSound>().Stop("submean");
            basicsubtext.SetActive(false);
            teacherImg3.SetActive(true);
            teacherImg.SetActive(false);
            banana.SetActive(true);
            FindObjectOfType<DialogueSound>().Play("subex");
        }

        if (sentutortials.Count == 6)
        {
            // Multi
            FindObjectOfType<DialogueSound>().Stop("subex");
            teacherImg.SetActive(true);
            teacherImg3.SetActive(false);
            banana.SetActive(false);
            FindObjectOfType<DialogueSound>().Play("multi");
        }

        if (sentutortials.Count == 5)
        {
            // Multi
            FindObjectOfType<DialogueSound>().Stop("multi");
            basicmultitext.SetActive(true);
            teacherImg2.SetActive(true);
            teacherImg.SetActive(false);
            FindObjectOfType<DialogueSound>().Play("multimean");
        }

        if (sentutortials.Count == 4)
        {
            // Multi
            FindObjectOfType<DialogueSound>().Stop("multimean");
            basicmultitext.SetActive(false);
            //teacherImg3.SetActive(true);
            //teacherImg2.SetActive(false);
            //marble.SetActive(true);
            //basicdivtext.SetActive(true);
            teacherImg3.SetActive(true);
            teacherImg2.SetActive(false);
            marble2.SetActive(true);
            FindObjectOfType<DialogueSound>().Play("multiex");
            //StartCoroutine(Wait(3.0f));

        }

        if (sentutortials.Count == 3)
        {
            // Div
            FindObjectOfType<DialogueSound>().Stop("multiex");
            basicdivtext.SetActive(true);
            teacherImg.SetActive(true);
            teacherImg3.SetActive(false);
            marble2.SetActive(false);
            FindObjectOfType<DialogueSound>().Play("div");

        }

        if (sentutortials.Count == 2)
        {
            FindObjectOfType<DialogueSound>().Stop("div");
            basicdivtext.SetActive(false);
            teacherImg2.SetActive(true);
            teacherImg.SetActive(false);
            carrots.SetActive(true);
            FindObjectOfType<DialogueSound>().Play("divex");
        }

        if (sentutortials.Count == 1)
        {
            // End Congrats
            teacherImg.SetActive(true);
            teacherImg2.SetActive(false);
            carrots.SetActive(false);
            congratsTxt.SetActive(true);
        }

        if (sentutortials.Count == 0)
        {
            EndTutorial();
            return;
        }

        string tutorial = sentutortials.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeTutorial(tutorial));
        
    }

    IEnumerator TypeTutorial(string tutorial)
    {
        TutorialText.text = "";
        foreach(char letter in tutorial.ToCharArray())
        {
            TutorialText.text += letter;
            yield return null;
        }
    }

    IEnumerator Wait(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Debug.Log("Waiting is Over");
        teacherImg.SetActive(true);
        teacherImg3.SetActive(false);
        marble2.SetActive(true);
        marble.SetActive(false);
    }

    public void EndTutorial()
    {
        PlayerPrefs.SetFloat("istutorialdone", 1);
        SceneManager.LoadScene("StageSelection");
    }
}
