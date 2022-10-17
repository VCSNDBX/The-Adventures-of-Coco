using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ChoicesScript : MonoBehaviour
{
    public TMP_Text choicetext;
    public bool istherightanswer;
    public GameObject GameManager;
    PlayerStatusScript playerStatusScript;
    MathDaemonStatusScript mathStatusScript;
    // Start is called before the first frame update
    void Start()
    {
        playerStatusScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStatusScript>();
        mathStatusScript = GameObject.FindGameObjectWithTag("MathDaemon").GetComponentInParent<MathDaemonStatusScript>();
    }
    public void CheckChoice(){
        int.TryParse(choicetext.text, out GetComponentInParent<monsterquestionsscript>().rranswer);
        if (GetComponentInParent<monsterquestionsscript>().rranswer == GetComponentInParent<monsterquestionsscript>().ranswer)
        {
            istherightanswer = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void RightAnswerClicked(){
        if(istherightanswer==true){
            GetComponentInParent<monsterquestionsscript>().iscorrectlyanswered=true;
            GetComponentInParent<monsterquestionsscript>().DecideTheResult();
            if (GameManager.GetComponent<ScoreManager>().levelname == "lvl9star")
            {
                mathStatusScript.TakeDamage(0.5f);
            }
        }
        else{
            //GetComponentInParent<monsterquestionsscript>().TimeLeft-=1;
            GetComponentInParent<monsterquestionsscript>().iscorrectlyanswered = true;
            GetComponentInParent<monsterquestionsscript>().WrongResult();
            if (GameManager.GetComponent<ScoreManager>().levelname == "lvl9star")
            {
                playerStatusScript.TakeDamage(0.5f);
            }
        }
    }
}
