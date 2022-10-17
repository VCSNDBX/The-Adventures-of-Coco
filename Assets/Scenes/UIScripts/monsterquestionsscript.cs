using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class monsterquestionsscript : MonoBehaviour
{
    public float TimeLeft;
    public GameObject[] choices;
    public int rightanswer;
    public TMP_Text timertext;
    public bool iscorrectlyanswered;
    public GameObject[] questions, EnemyAI;
    public ResultScript resultScript;
    public GameObject GameManager, gquestion, gover, indic, indic2, indic3;
    private GameObject player;
    MonsterQuestionManager mqm;
    public List<int> randomnumbers = new List<int>();
    int rand;

    // New Question Genarator
    int minVal, maxVal;
    int num1, num2, div;
    string plus, minus, divide, multiply, alloperation;
    string generatequestion;
    public int ranswer, rranswer;
    public TMP_Text questiontext;
    int randoperation;
    public int WrongAnswer;

    // FOR EVAAAAAAAAAAAAAAAAAAAAAAAAAAAL
    public bool isaddition, issubtraction, ismultiplication, isdivision;
    void Start()
    {
        mqm = GetComponentInParent<MonsterQuestionManager>();
        player = GameObject.FindGameObjectWithTag("Player");
        EnemyAI = GameObject.FindGameObjectsWithTag("Enemy");
        if (GameManager.GetComponent<ScoreManager>().stagelevel == "easy")
        {
            minVal = 1;
            maxVal = 5;
        }
        if (GameManager.GetComponent<ScoreManager>().stagelevel == "mid")
        {
            minVal = 1;
            maxVal = 10;
        }
        if (GameManager.GetComponent<ScoreManager>().stagelevel == "hard")
        {
            minVal = 1;
            maxVal = 10;
        }

        randomnumbers = new List<int>(new int[maxVal]);
        for (int j = 1; j < maxVal; j++)
        {
            rand = Random.Range(minVal, maxVal);
            while (randomnumbers.Contains(rand))
            {
                rand = Random.Range(minVal, maxVal);
            }
            randomnumbers[j] = rand;
        }

        iscorrectlyanswered =false;
        WrongAnswer = 0;
        TimeLeft = 60;
        GenerateQuestion();
    }
    
    public void GenerateQuestion()
    {
        num1 = Random.Range(minVal, maxVal);
        num2 = Random.Range(minVal, maxVal);

        if (mqm.operation == "plus")
        {
            Debug.Log("Showing Addition Question");
            generatequestion = num1.ToString() + " + " + num2.ToString() + " = ?";
            ranswer = num1 + num2;
            GameManager.GetComponent<ScoreManager>().isaddition = true;
            Debug.Log("Question: " + generatequestion);
            Debug.Log("Answer: " + ranswer);
        }
        else if (mqm.operation == "minus")
        {
            Debug.Log("Showing Subtraction Question");
            if (num1 > num2)
            {
                generatequestion = num1.ToString() + " - " + num2.ToString() + " = ?";
                ranswer = num1 - num2;
            } else
            {
                generatequestion = num2.ToString() + " - " + num1.ToString() + " = ?";
                ranswer = num2 - num1;
            }
            Debug.Log("Question: " + generatequestion);
            Debug.Log("Answer: " + ranswer);
        }
        else if (mqm.operation == "multiply")
        {
            Debug.Log("Showing Multiplication Question");
            generatequestion = num1.ToString() + " X " + num2.ToString() + " = ?";
            ranswer = num1 * num2;
            GameManager.GetComponent<ScoreManager>().ismultiplication = true;
            Debug.Log("Question: " + generatequestion);
            Debug.Log("Answer: " + ranswer);
        }
        else if (mqm.operation == "divide")
        {
            Debug.Log("Showing Division Question");
            switch (div = Random.Range(1, 5))
            {
                case 1:
                    generatequestion = "2 ÷ 2 = ?";
                    ranswer = 1;
                    break;
                case 2:
                    generatequestion = "6 ÷ 2 = ?";
                    ranswer = 3;
                    break;
                case 3:
                    generatequestion = "8 ÷ 2 = ?";
                    ranswer = 4;
                    break;
                case 4:
                    generatequestion = "4 ÷ 4 = ?";
                    ranswer = 1;
                    break;
            }
            GameManager.GetComponent<ScoreManager>().isdivision = true;
            Debug.Log("Question: " + generatequestion);
            Debug.Log("Answer: " + ranswer);
        }
        else if (mqm.operation == "plusminus")
        {
            Debug.Log("Showing Addition and Subtraction Question");
            switch (randoperation = Random.Range(1, 3))
            {
                case 1:
                    Debug.Log("Addition");
                    generatequestion = num1.ToString() + " + " + num2.ToString() + " = ?";
                    ranswer = num1 + num2;
                    GameManager.GetComponent<ScoreManager>().isaddition = true;
                    break;
                case 2:
                    Debug.Log("Subtraction");
                    if (num1 > num2)
                    {
                        generatequestion = num1.ToString() + " - " + num2.ToString() + " = ?";
                        ranswer = num1 - num2;
                    }
                    else
                    {
                        generatequestion = num2.ToString() + " - " + num1.ToString() + " = ?";
                        ranswer = num2 - num1;
                    }
                    GameManager.GetComponent<ScoreManager>().issubtraction = true;
                    break;
            }
            Debug.Log("Question: " + generatequestion);
            Debug.Log("Answer: " + ranswer);
        }
        else if (mqm.operation == "alloperation")
        {
            Debug.Log("Showing Addition and Subtraction Question");
            switch (randoperation = Random.Range(1, 5))
            {
                case 1:
                    Debug.Log("Addition");
                    generatequestion = num1.ToString() + " + " + num2.ToString() + " = ?";
                    ranswer = num1 + num2;
                    GameManager.GetComponent<ScoreManager>().isaddition = true;
                    break;
                case 2:
                    Debug.Log("Subtraction");
                    if (num1 > num2)
                    {
                        generatequestion = num1.ToString() + " - " + num2.ToString() + " = ?";
                        ranswer = num1 - num2;
                    }
                    else
                    {
                        generatequestion = num2.ToString() + " - " + num1.ToString() + " = ?";
                        ranswer = num2 - num1;
                    }
                    GameManager.GetComponent<ScoreManager>().issubtraction = true;
                    break;
                case 3:
                    Debug.Log("Multiplication");
                    generatequestion = num1.ToString() + " X " + num2.ToString() + " = ?";
                    ranswer = num1 * num2;
                    GameManager.GetComponent<ScoreManager>().ismultiplication = true;
                    break;
                case 4:
                    Debug.Log("Division");
                    switch (div = Random.Range(1, 5))
                    {
                        case 1:
                            generatequestion = "2 ÷ 2 = ?";
                            ranswer = 1;
                            break;
                        case 2:
                            generatequestion = "6 ÷ 2 = ?";
                            ranswer = 2;
                            break;
                        case 3:
                            generatequestion = "8 ÷ 2 = ?";
                            ranswer = 4;
                            break;
                        case 4:
                            generatequestion = "4 ÷ 4 = ?";
                            ranswer = 1;
                            break;
                    }
                    GameManager.GetComponent<ScoreManager>().isdivision = true;
                    break;
            }
            Debug.Log("Question: " + generatequestion);
            Debug.Log("Answer: " + ranswer);
        }

        resultScript = GetComponentInParent<MonsterQuestionManager>().ResultPanel.GetComponent<ResultScript>();
        questiontext.text = generatequestion;
        rranswer = Random.Range(0, 3);
        switch (rranswer)
        {
            case 0:
                choices[0].GetComponent<ChoicesScript>().choicetext.text = ranswer.ToString();
                FixedRandomChoice(choices[0], choices[1], choices[2]);
                break;
            case 1:
                choices[1].GetComponent<ChoicesScript>().choicetext.text = ranswer.ToString();
                FixedRandomChoice(choices[1], choices[0], choices[2]);
                break;
            case 2:
                choices[2].GetComponent<ChoicesScript>().choicetext.text = ranswer.ToString();
                FixedRandomChoice(choices[2], choices[1], choices[0]);
                break;
        }
        foreach (GameObject choice in choices)
        {
            choice.GetComponent<ChoicesScript>().CheckChoice();
        }

    }

    void FixedRandomChoice(GameObject rranswer, GameObject choice,GameObject choice1){
        Randomize(choice);
        foreach(int n in randomnumbers){
            if(choice1.GetComponent<ChoicesScript>().choicetext.text=="0"){
                if(choice.GetComponent<ChoicesScript>().choicetext.text!=n.ToString()&& rranswer.GetComponent<ChoicesScript>().choicetext.text!=n.ToString()){
                choice1.GetComponent<ChoicesScript>().choicetext.text=n.ToString();
            }
            }
        }

    }
    void Randomize(GameObject choice){
        choice.GetComponent<ChoicesScript>().choicetext.text= Random.Range(minVal, maxVal).ToString();
        if(choice.GetComponent<ChoicesScript>().choicetext.text==ranswer.ToString()){
            Randomize(choice);
        }
    }
    public void DecideTheResult(){
        if (TimeLeft>=40){
            resultScript.ShowResult("Wow! Good Job!");
            GameManager.GetComponent<ScoreManager>().AddScore(3);
            FindObjectOfType<WrongAnswerSound>().Play("Excellent!");
        }
        else if(TimeLeft>=20)
        {
            resultScript.ShowResult("Very Good!");
            GameManager.GetComponent<ScoreManager>().AddScore(2);
            FindObjectOfType<WrongAnswerSound>().Play("Very Good!");
        }
        else{
            resultScript.ShowResult("Good!");
            GameManager.GetComponent<ScoreManager>().AddScore(1);
            FindObjectOfType<WrongAnswerSound>().Play("Good!");
        }
    }

    public void WrongResult()
    {
        string[] sad = new string[] { "Let's try that again!", "So close! Try again!", "You can do it, try another question!", "Nice try! You can do it!", "It's okay! Try again!", "Let's go for gold, try again!" };
        System.Random random = new System.Random();
        int useSad = random.Next(sad.Length);
        string pickSad = sad[useSad];
        resultScript.ShowResult(pickSad);
        GameManager.GetComponent<ScoreManager>().WrongAnswer(0);
        FindObjectOfType<WrongAnswerSound>().Play(pickSad);
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeLeft < 0)
        {
            gquestion.SetActive(false);
            gover.SetActive(true);
        }
        
        if (iscorrectlyanswered==false)
        {
            if (TimeLeft > 0)
            {
                //if (mqm.powerupactivated == true)
                //{
                //    timertext.text = "Freeze Time";
                //    Debug.Log("Time Stop");
                //}
                //else
                //{
                    TimeLeft -= Time.deltaTime;
                    timertext.text = (Mathf.Round(TimeLeft)).ToString();
                    Debug.Log("Time Started");
                //}
            }

            if (TimeLeft<30&&TimeLeft>10){
                timertext.color = new Color(255,165,0,1);
            }else{
                if(TimeLeft<=10){
                    timertext.color = new Color(255,0,0,1);
                }
            }
        } else {
            foreach(GameObject enemy in EnemyAI){
                if(Vector3.Distance(enemy.transform.position,player.transform.position)<3){
                    player.GetComponent<JoystickPlayerExample>().movementenabled = false;
                    enemy.GetComponent<Animator>().Play("AIDeathAnimation");
                    enemy.GetComponent<Rigidbody>().isKinematic=true;
                    enemy.GetComponent<BoxCollider>().enabled=false;
                    Destroy(enemy.gameObject);
                    Debug.Log(enemy.name);
                    if (enemy.name == "ai2")
                    {
                        Destroy(indic.gameObject);
                    }
                    else if (enemy.name == "ai2 (1)")
                    {
                        Destroy(indic2.gameObject);
                    }
                    else if (enemy.name == "ai2 (2)")
                    {
                        Destroy(indic3.gameObject);
                    }
                }
            }
            GetComponentInParent<MonsterQuestionManager>().RemoveQuestion(gameObject);
            player.GetComponent<JoystickPlayerExample>().movementenabled = true;
        }

        
    }
}
