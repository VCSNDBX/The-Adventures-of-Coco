using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public float score;
    public Image numberofstarsimg;
    private Animator animator;
    public string levelname;
    public string stagelevel;
    public int monsterleft;
    public GameObject shovelpanel, timer, shownextlevel, evalpanel, EvalManager;
    public TMP_Text monsterpanel;
    public TMP_Text levelpanel;
    public MonsterQuestionManager mqm;
    public GameObject[] allshovels;

    public float timespent;
    public float stage1, stage2, stage3;
    public float levelcomplete;
    public float addcount, subcount, multicount, divcount;
    public bool isstageomplete;
    public bool isaddition, issubtraction, ismultiplication, isdivision;

    void Start()
    {
        levelcomplete = PlayerPrefs.GetFloat("leveldone");
        isstageomplete = false;
        /*if (levelcomplete == 3)
        {
            //Destroy(GameObject.Find("GlobalControl"));
            isstageomplete = true;
        }*/

        allshovels = GameObject.FindGameObjectsWithTag("goldenshovel");
        animator = numberofstarsimg.gameObject.GetComponentInParent<Animator>();
        monsterleft = 3;
        monsterpanel.text = "Monster Left: " + monsterleft; // + "\n Shovel Left: " + allshovels.Length.ToString()
        StageCheck();
    }

    // Update is called once per frame
    void Update()
    {
        levelcomplete = PlayerPrefs.GetFloat("leveldone");
        //stage1 = PlayerPrefs.GetFloat("s1killed");
        //stage2 = PlayerPrefs.GetFloat("s2killed");
        //stage3 = PlayerPrefs.GetFloat("s3killed");
        if (levelname == "lvl1star" || levelname == "lvl2star" || levelname == "lvl3star")
        {
            addcount = PlayerPrefs.GetFloat("addcount");
            subcount = PlayerPrefs.GetFloat("subcount");
        }
        if (levelname == "lvl4star" || levelname == "lvl5star" || levelname == "lvl6star")
        {
            addcount = PlayerPrefs.GetFloat("addcounts2");
            subcount = PlayerPrefs.GetFloat("subcounts2");
            multicount = PlayerPrefs.GetFloat("multicounts2");
        }
        if (levelname == "lvl7star" || levelname == "lvl8star" || levelname == "lvl9star")
        {
            addcount = PlayerPrefs.GetFloat("addcounts3");
            subcount = PlayerPrefs.GetFloat("subcounts3");
            multicount = PlayerPrefs.GetFloat("multicounts3");
            divcount = PlayerPrefs.GetFloat("divcounts3");
        }


        if (Input.GetKeyDown(KeyCode.H)) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }

    void StageCheck()
    {
        //Stage 1
        if (levelname == "lvl1star")
        {
            levelpanel.text = "Level 1";
        }
        else if (levelname == "lvl2star")
        {
            levelpanel.text = "Level 2";
        }
        else if (levelname == "lvl3star")
        {
            levelpanel.text = "Level 3";
        }
        //Stage 2
        else if (levelname == "lvl4star")
        {
            levelpanel.text = "Level 1";
        }
        else if (levelname == "lvl5star")
        {
            levelpanel.text = "Level 2";
        }
        else if (levelname == "lvl6star")
        {
            levelpanel.text = "Level 3";
        }
        //Stage 3
        else if (levelname == "lvl7star")
        {
            levelpanel.text = "Level 1";
        }
        else if (levelname == "lvl8star")
        {
            levelpanel.text = "Level 2";
        }
    }

    public void AddScore(float points)
    {
        score += points;
        monsterleft--;

        if (isstageomplete == true)
        {
            PlayerPrefs.SetFloat("leveldone", PlayerPrefs.GetFloat("leveldone"));
            /*PlayerPrefs.SetFloat("s1killedadd", 0);
            PlayerPrefs.SetFloat("addcount", 0);
            PlayerPrefs.SetFloat("s1killedsub", 0);
            PlayerPrefs.SetFloat("subcount", 0);*/
        }
        else
        {
            if (levelname == "lvl1star")
            {
                if (isaddition)
                {
                    Debug.Log(isaddition);
                    PlayerPrefs.SetFloat("s1killedadd", PlayerPrefs.GetFloat("s1killedadd") + 1);
                    PlayerPrefs.SetFloat("addcount", PlayerPrefs.GetFloat("addcount") + 1);
                    isaddition = false;
                    Debug.Log(isaddition);
                }
            }

            if (levelname == "lvl2star")
            {
                if (isaddition)
                {
                    PlayerPrefs.SetFloat("s1killedadd", PlayerPrefs.GetFloat("s1killedadd") + 1);
                    PlayerPrefs.SetFloat("addcount", PlayerPrefs.GetFloat("addcount") + 1);
                    isaddition = false;
                } 
            }

            if (levelname == "lvl3star")
            {
                if (isaddition)
                {
                    PlayerPrefs.SetFloat("s1killedadd", PlayerPrefs.GetFloat("s1killedadd") + 1);
                    PlayerPrefs.SetFloat("addcount", PlayerPrefs.GetFloat("addcount") + 1);
                    isaddition = false;
                }
                else if (issubtraction)
                {
                    PlayerPrefs.SetFloat("s1killedsub", PlayerPrefs.GetFloat("s1killedsub") + 1);
                    PlayerPrefs.SetFloat("subcount", PlayerPrefs.GetFloat("subcount") + 1);
                    issubtraction = false;
                }
            }
            //Stage 2
            if (levelname == "lvl4star")
            {
                if (issubtraction)
                {
                    PlayerPrefs.SetFloat("s2killedsub", PlayerPrefs.GetFloat("s2killedsub") + 1);
                    PlayerPrefs.SetFloat("subcounts2", PlayerPrefs.GetFloat("subcounts2") + 1);
                    issubtraction = false;
                }
            }

            if (levelname == "lvl5star")
            {
                if (isaddition)
                {
                    PlayerPrefs.SetFloat("s2killedadd", PlayerPrefs.GetFloat("s2killedadd") + 1);
                    PlayerPrefs.SetFloat("addcounts2", PlayerPrefs.GetFloat("addcounts2") + 1);
                    isaddition = false;
                }

                else if (issubtraction)
                {
                    PlayerPrefs.SetFloat("s2killedsub", PlayerPrefs.GetFloat("s2killedsub") + 1);
                    PlayerPrefs.SetFloat("subcounts2", PlayerPrefs.GetFloat("subcounts2") + 1);
                    issubtraction = false;
                }
            }
            if (levelname == "lvl6star")
            {
                if (ismultiplication)
                {
                    PlayerPrefs.SetFloat("s2killedmulti", PlayerPrefs.GetFloat("s2killedmulti") + 1);
                    PlayerPrefs.SetFloat("multicounts2", PlayerPrefs.GetFloat("multicounts2") + 1);
                    ismultiplication = false;
                }
            }
            //Stage 3
            if (levelname == "lvl7star")
            {
                if (ismultiplication)
                {
                    PlayerPrefs.SetFloat("s3killedmulti", PlayerPrefs.GetFloat("s3killedmulti") + 1);
                    PlayerPrefs.SetFloat("multicounts3", PlayerPrefs.GetFloat("multicounts3") + 1);
                    ismultiplication = false;
                }
            }
            if (levelname == "lvl8star")
            {
                if (isdivision)
                {
                    PlayerPrefs.SetFloat("s3killeddiv", PlayerPrefs.GetFloat("s3killeddiv") + 1);
                    PlayerPrefs.SetFloat("divcounts3", PlayerPrefs.GetFloat("divcounts3") + 1);
                    isdivision = false;
                }
            }
            if (levelname == "lvl9star")
            {
                if (isaddition)
                {
                    PlayerPrefs.SetFloat("s3killedadd", PlayerPrefs.GetFloat("s3killedadd") + 1);
                    PlayerPrefs.SetFloat("addcounts3", PlayerPrefs.GetFloat("addcounts3") + 1);
                    isaddition = false;
                }

                else if (issubtraction)
                {
                    PlayerPrefs.SetFloat("s3killedsub", PlayerPrefs.GetFloat("s3killedsub") + 1);
                    PlayerPrefs.SetFloat("subcounts3", PlayerPrefs.GetFloat("subcounts3") + 1);
                    issubtraction = false;
                }

                else if (ismultiplication)
                {
                    PlayerPrefs.SetFloat("s3killedmulti", PlayerPrefs.GetFloat("s3killedmulti") + 1);
                    PlayerPrefs.SetFloat("multicounts3", PlayerPrefs.GetFloat("multicounts3") + 1);
                    ismultiplication = false;
                }

                else if (isdivision)
                {
                    PlayerPrefs.SetFloat("s3killeddiv", PlayerPrefs.GetFloat("s3killeddiv") + 1);
                    PlayerPrefs.SetFloat("divcounts3", PlayerPrefs.GetFloat("divcounts3") + 1);
                    isdivision = false;
                }
            }
        }
        if (score > 9) {
            score = 9;
            
        }
        if (PlayerPrefs.GetFloat(levelname) != 3) {
            PlayerPrefs.SetFloat(levelname, score / 3);
        }
    }

    public void WrongAnswer(float points)
    {
        score += points;
        monsterleft--;
        if (levelname == "lvl1star")
        {
            if (isaddition)
            {
                PlayerPrefs.SetFloat("s1killedadd", PlayerPrefs.GetFloat("s1killedadd") + 1);
                isaddition = false;
            }
        }
        else if (levelname == "lvl2star")
        {
            if (isaddition)
            {
                PlayerPrefs.SetFloat("s1killedadd", PlayerPrefs.GetFloat("s1killedadd") + 1);
                isaddition = false;
            }
        }
        else if (levelname == "lvl3star")
        {
            if (isaddition)
            {
                PlayerPrefs.SetFloat("s1killedadd", PlayerPrefs.GetFloat("s1killedadd") + 1);
                isaddition = false;
            }
            else if (issubtraction)
            {
                PlayerPrefs.SetFloat("s1killedsub", PlayerPrefs.GetFloat("s1killedsub") + 1);
                issubtraction = false;
            }
        }
        //Stage 2
        else if (levelname == "lvl4star")
        {
            if (issubtraction)
            {
                PlayerPrefs.SetFloat("s2killedsub", PlayerPrefs.GetFloat("s2killedsub") + 1);
                issubtraction = false;
            }
        }
        else if (levelname == "lvl5star")
        {
            if (isaddition)
            {
                PlayerPrefs.SetFloat("s2killedadd", PlayerPrefs.GetFloat("s2killedadd") + 1);
                isaddition = false;
            }
            else if (issubtraction)
            {
                PlayerPrefs.SetFloat("s2killedsub", PlayerPrefs.GetFloat("s2killedsub") + 1);
                issubtraction = false;
            }
        }
        else if (levelname == "lvl6star")
        {
            if (ismultiplication)
            {
                PlayerPrefs.SetFloat("s2killedmulti", PlayerPrefs.GetFloat("s2killedmulti") + 1);
                ismultiplication = false;
            }
        }
        //Stage 3
        else if (levelname == "lvl7star")
        {
            if (ismultiplication)
            {
                PlayerPrefs.SetFloat("s3killedmulti", PlayerPrefs.GetFloat("s3killedmulti") + 1);
                ismultiplication = false;
            }
        }
        else if (levelname == "lvl8star")
        {
            if (isdivision)
            {
                PlayerPrefs.SetFloat("s3killeddiv", PlayerPrefs.GetFloat("s3killeddiv") + 1);
                isdivision = false;
            }
        }
        else if (levelname == "lvl9star")
        {
            if (isaddition)
            {
                PlayerPrefs.SetFloat("s3killedadd", PlayerPrefs.GetFloat("s3killedadd") + 1);
                isaddition = false;
            }
            else if (issubtraction)
            {
                PlayerPrefs.SetFloat("s3killedsub", PlayerPrefs.GetFloat("s3killedsub") + 1);
                issubtraction = false;
            }
            else if (ismultiplication)
            {
                PlayerPrefs.SetFloat("s3killedmulti", PlayerPrefs.GetFloat("s3killedmulti") + 1);
                ismultiplication = false;
            }
            else if (isdivision)
            {
                PlayerPrefs.SetFloat("s3killeddiv", PlayerPrefs.GetFloat("s3killeddiv") + 1);
                isdivision = false;
            }
        }
        if (score > 9)
        {
            score = 9;
        }
        if (PlayerPrefs.GetFloat(levelname) != 3)
        {
            PlayerPrefs.SetFloat(levelname, score / 3);
        }
    }

    public void StageSelect()
    {
        SceneManager.LoadScene("StageSelection");
    }

    public void NextStageNow()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void HideGameobject(GameObject go) {
        go.SetActive(false);
    }
    public void UpdateScoreUI()
    {
        numberofstarsimg.fillAmount = score / 9;
        animator.SetTrigger("addstarsign");
        allshovels = GameObject.FindGameObjectsWithTag("goldenshovel");
        monsterpanel.text = "Monster Left: " + monsterleft; //+ "\n Shovel Left: " + allshovels.Length.ToString()
        Debug.Log(monsterleft);
        NextLevel();
    }


    public void NextLevel()
    {
        if (monsterleft <= 0)
        {
            // Proceed to next level?
            Debug.Log("Next Level");
            monsterpanel.text = "Monster Left: " + monsterleft; //+ "\n Shovel Left: " + allshovels.Length.ToString()
            shownextlevel.SetActive(true);
        }
    }

    public void LoadScene() {
        if (levelname == "lvl3star")
        {
            PlayerPrefs.SetFloat("leveldone", 3);
            shownextlevel.SetActive(false);
            EvalManager.GetComponent<EvalGlobalControl>().Eval();
            evalpanel.SetActive(true);
        }

        else if (levelname == "lvl6star")
        {
            PlayerPrefs.SetFloat("leveldone", 6);
            shownextlevel.SetActive(false);
            EvalManager.GetComponent<EvalGlobalControl>().Eval();
            evalpanel.SetActive(true);
        }

        else if (levelname == "lvl9star")
        {
            PlayerPrefs.SetFloat("leveldone", 9);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    public void ShowQuestion(GameObject go) {
        go.SetActive(true);
    }

    public void ShowOptions(GameObject op)
    {
        op.SetActive(true);
    }

    public void ResetGame(){
        if (levelname == "lvl1star")
        {
            PlayerPrefs.SetFloat("s1killed", 0);
        }
        else if (levelname == "lvl2star")
        {
            PlayerPrefs.SetFloat("s1killed", 0);
        }
        else if (levelname == "lvl3star")
        {
            PlayerPrefs.SetFloat("s1killed", 0);
        }
        //Stage 2
        else if (levelname == "lvl4star")
        {
            PlayerPrefs.SetFloat("s1killed", 0);
        }
        else if (levelname == "lvl5star")
        {
            PlayerPrefs.SetFloat("s1killed", 0);
        }
        else if (levelname == "lvl6star")
        {
            PlayerPrefs.SetFloat("s1killed", 0);
        }
        //Stage 3
        else if (levelname == "lvl7star")
        {
            PlayerPrefs.SetFloat("s1killed", 0);
        }
        else if (levelname == "lvl8star")
        {

            PlayerPrefs.SetFloat("s1killed", 0);
        }
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
