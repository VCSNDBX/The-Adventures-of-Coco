using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public GameObject cocoImg, cocowalkImg, brownieImg, pinkieImg, greenieImg, mathImg;
    public Text dialogueText;

    private Queue<string> sentences;

    private void Awake()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        //nameText.text = dialogue.name;
        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DisplayNextSentence();
        }
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 12)
        {
           FindObjectOfType<DialogueSound>().Play("1");
        }
        if (sentences.Count == 11)
        {
            FindObjectOfType<DialogueSound>().Stop("1");
            FindObjectOfType<DialogueSound>().Play("11");
        }
        if (sentences.Count == 10)
        {
            FindObjectOfType<DialogueSound>().Stop("11");
            cocoImg.SetActive(true);
            brownieImg.SetActive(true);
            pinkieImg.SetActive(true);
            greenieImg.SetActive(true);
            FindObjectOfType<DialogueSound>().Play("2");
        }
        if (sentences.Count == 9)
        {
            FindObjectOfType<DialogueSound>().Stop("2");
            FindObjectOfType<DialogueSound>().Play("3");
        }
            if (sentences.Count == 8)
        {
            FindObjectOfType<DialogueSound>().Stop("3");
            cocoImg.SetActive(false);
            brownieImg.SetActive(true);
            pinkieImg.SetActive(false);
            greenieImg.SetActive(false);
            FindObjectOfType<DialogueSound>().Play("4");
        }

        if (sentences.Count == 7)
        {
            FindObjectOfType<DialogueSound>().Stop("4");
            cocoImg.SetActive(false);
            //brownieImg.SetActive(true);
            pinkieImg.SetActive(true);
            greenieImg.SetActive(true);
            FindObjectOfType<DialogueSound>().Play("5");
        }

        if (sentences.Count == 6)
        {
            FindObjectOfType<DialogueSound>().Stop("5");
            cocowalkImg.SetActive(true);
            brownieImg.SetActive(false);
            pinkieImg.SetActive(false);
            greenieImg.SetActive(false);
            FindObjectOfType<DialogueSound>().Play("6");
        }

        if (sentences.Count == 5)
        {
            FindObjectOfType<DialogueSound>().Stop("6");
            cocowalkImg.SetActive(false);
            brownieImg.SetActive(true);
            pinkieImg.SetActive(true);
            greenieImg.SetActive(true);
            FindObjectOfType<DialogueSound>().Play("7");
        }
        if (sentences.Count == 4)
        {
            cocoImg.SetActive(true);
            cocowalkImg.SetActive(false);
            brownieImg.SetActive(false);
            pinkieImg.SetActive(false);
            greenieImg.SetActive(false);
        }
        if (sentences.Count == 3)
        {
            FindObjectOfType<DialogueSound>().Stop("7");
            mathImg.SetActive(true);
            cocoImg.SetActive(false);
            cocowalkImg.SetActive(false);
            brownieImg.SetActive(false);
            pinkieImg.SetActive(false);
            greenieImg.SetActive(false);
            FindObjectOfType<DialogueSound>().Play("8");
        }

        if (sentences.Count == 2)
        {
            //FindObjectOfType<DialogueSound>().Stop("8");
            //mathImg.SetActive(true);
            //cocoImg.SetActive(false);
            //cocowalkImg.SetActive(false);
            //brownieImg.SetActive(false);
            //pinkieImg.SetActive(false);
            //greenieImg.SetActive(false);
            FindObjectOfType<DialogueSound>().Play("9");
        }

        if (sentences.Count == 1)
        {
            FindObjectOfType<DialogueSound>().Stop("9");
            FindObjectOfType<DialogueSound>().Play("10");
        }

        if (sentences.Count == 0)
        {
            FindObjectOfType<DialogueSound>().Stop("10");
            EndDialog();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));

    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    public void EndDialog()
    {
        PlayerPrefs.SetFloat("isDialogdone", 1);
        SceneManager.LoadScene("StageSelection");
    }
}
