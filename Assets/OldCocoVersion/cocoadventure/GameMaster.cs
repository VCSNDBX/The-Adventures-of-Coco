using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public GameObject StarPanel;
    public GenerateQuestionScript gqs;
    private int index;
    public GameObject[] stars;
    // Start is called before the first frame update
    void Start()
    {
        gqs = GetComponent<GenerateQuestionScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Enemy").Length==0)
        {
            StarPanel.SetActive(true);
            CheckStar();
        }
        
    }
    public void CheckStar()
    {
        switch (gqs.numberofenemies)
        {
            case 3:
                if (gqs.All_TimeLeft[0] >= 25 && gqs.All_TimeLeft[1] >= 25 && gqs.All_TimeLeft[2] >= 25)
                {
                    Debug.Log("3star");
                    stars[0].SetActive(true);
                    stars[1].SetActive(true);
                    stars[2].SetActive(true);
                }
                else
                {
                    if (gqs.All_TimeLeft[0] >= 15 && gqs.All_TimeLeft[1] >= 15 && gqs.All_TimeLeft[2] >= 15)
                    {
                        Debug.Log("2star");
                        stars[0].SetActive(true);
                        stars[1].SetActive(true);

                    }
                    else
                    {
                        Debug.Log("1star");
                        stars[0].SetActive(true);
                    }
                }
                break;
            case 4:
                if (gqs.All_TimeLeft[0] >= 25 && gqs.All_TimeLeft[1] >= 25 && gqs.All_TimeLeft[2] >= 25&& gqs.All_TimeLeft[3] >= 25)
                {
                    Debug.Log("3star");
                    stars[0].SetActive(true);
                    stars[1].SetActive(true);
                    stars[2].SetActive(true);
                }
                else
                {
                    if (gqs.All_TimeLeft[0] >= 15 && gqs.All_TimeLeft[1] >= 15 && gqs.All_TimeLeft[2] >= 15 && gqs.All_TimeLeft[3] >= 15)
                    {
                        Debug.Log("2star");
                        stars[0].SetActive(true);
                        stars[1].SetActive(true);

                    }
                    else
                    {
                        Debug.Log("1star");
                        stars[0].SetActive(true);
                    }
                }
                break;
            case 5:
                if (gqs.All_TimeLeft[0] >= 25 && gqs.All_TimeLeft[1] >= 25 && gqs.All_TimeLeft[2] >= 25 && gqs.All_TimeLeft[3] >= 25&& gqs.All_TimeLeft[4] >= 25)
                {
                    Debug.Log("3star");
                    stars[0].SetActive(true);
                    stars[1].SetActive(true);
                    stars[2].SetActive(true);
                }
                else
                {
                    if (gqs.All_TimeLeft[0] >= 15 && gqs.All_TimeLeft[1] >= 15 && gqs.All_TimeLeft[2] >= 15 && gqs.All_TimeLeft[3] >= 15 && gqs.All_TimeLeft[4] >= 15)
                    {
                        Debug.Log("2star");
                        stars[0].SetActive(true);
                        stars[1].SetActive(true);

                    }
                    else
                    {
                        Debug.Log("1star");
                        stars[0].SetActive(true);
                    }
                }
                break;
            case 6:
                if (gqs.All_TimeLeft[0] >= 25 && gqs.All_TimeLeft[1] >= 25 && gqs.All_TimeLeft[2] >= 25 && gqs.All_TimeLeft[3] >= 25 && gqs.All_TimeLeft[4] >= 25 && gqs.All_TimeLeft[5] >= 25)
                {
                    Debug.Log("3star");
                    stars[0].SetActive(true);
                    stars[1].SetActive(true);
                    stars[2].SetActive(true);
                }
                else
                {
                    if (gqs.All_TimeLeft[0] >= 15 && gqs.All_TimeLeft[1] >= 15 && gqs.All_TimeLeft[2] >= 15 && gqs.All_TimeLeft[3] >= 15 && gqs.All_TimeLeft[4] >= 15 && gqs.All_TimeLeft[5] >= 15)
                    {
                        Debug.Log("2star");
                        stars[0].SetActive(true);
                        stars[1].SetActive(true);

                    }
                    else
                    {
                        Debug.Log("1star");
                        stars[0].SetActive(true);
                    }
                }
                break;
        }
    }
}
