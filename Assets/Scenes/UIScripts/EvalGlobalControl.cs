using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EvalGlobalControl : MonoBehaviour
{
    public GameObject GameManager;
    public TMP_Text scoreadd, scoremin, scoremulti, scorediv, scorepercentadd, scorepercentmin, scorepercentmulyi, scorepercentdiv;

    public float scradd;
    public float scrsub;

    public float stage1add;
    public float stage1sub;
    //stage 2
    public float scradd2;
    public float scrmulti2;
    public float scrsub2;

    public float stage2multi;
    public float stage2sub;
    public float stage2add;
    //stage 3
    public float scradd3;
    public float scrsub3;
    public float scrmulti3;
    public float scrdiv3;

    public float stage3sub;
    public float stage3add;
    public float stage3div;
    public float stage3multi;

    void Start()
    {
        scradd = PlayerPrefs.GetFloat("addcount");
        scrsub = PlayerPrefs.GetFloat("subcount");

        stage1add = PlayerPrefs.GetFloat("s1killedadd");
        stage1sub = PlayerPrefs.GetFloat("s1killedsub");
        //stage 2
        scradd2 = PlayerPrefs.GetFloat("addcounts2");
        scrmulti2 = PlayerPrefs.GetFloat("multicounts2");
        scrsub2 = PlayerPrefs.GetFloat("subcounts2");

        stage2multi = PlayerPrefs.GetFloat("s2killedmulti");
        stage2sub = PlayerPrefs.GetFloat("s2killedsub");
        stage2add = PlayerPrefs.GetFloat("s2killedadd");
        //stage 3
        scradd3 = PlayerPrefs.GetFloat("addcounts3");
        scrsub3 = PlayerPrefs.GetFloat("subcounts3");
        scrmulti3 = PlayerPrefs.GetFloat("multicounts3");
        scrdiv3 = PlayerPrefs.GetFloat("divcounts3");

        stage3sub = PlayerPrefs.GetFloat("s3killedsub");
        stage3add = PlayerPrefs.GetFloat("s3killedadd");
        stage3div = PlayerPrefs.GetFloat("s3killeddiv");
        stage3multi = PlayerPrefs.GetFloat("s3killedmulti");
    }

    void Update()
    {
        scradd = PlayerPrefs.GetFloat("addcount");
        scrsub = PlayerPrefs.GetFloat("subcount");

        stage1add = PlayerPrefs.GetFloat("s1killedadd");
        stage1sub = PlayerPrefs.GetFloat("s1killedsub");
        //stage 2
        scradd2 = PlayerPrefs.GetFloat("addcounts2");
        scrmulti2 = PlayerPrefs.GetFloat("multicounts2");
        scrsub2 = PlayerPrefs.GetFloat("subcounts2");

        stage2multi = PlayerPrefs.GetFloat("s2killedmulti");
        stage2sub = PlayerPrefs.GetFloat("s2killedsub");
        stage2add = PlayerPrefs.GetFloat("s2killedadd");
        //stage 3
        scradd3 = PlayerPrefs.GetFloat("addcounts3");
        scrsub3 = PlayerPrefs.GetFloat("subcounts3");
        scrmulti3 = PlayerPrefs.GetFloat("multicounts3");
        scrdiv3 = PlayerPrefs.GetFloat("divcounts3");

        stage3sub = PlayerPrefs.GetFloat("s3killedsub");
        stage3add = PlayerPrefs.GetFloat("s3killedadd");
        stage3div = PlayerPrefs.GetFloat("s3killeddiv");
        stage3multi = PlayerPrefs.GetFloat("s3killedmulti");
    }

    public void Eval()
    {
        //stage 1

        float stage1 = stage1add + stage1sub;
        float stage2 = stage2multi + stage2sub + stage2add;
        float stage3 = stage3add + stage3sub + stage3div + stage3multi;

        //stage 1 L1-L3
        if (GameManager.GetComponent<ScoreManager>().levelname == "lvl3star")
        {

            if (scrsub == 0)
            {
                scoremin.text = "-";
                scorepercentmin.text = "-";
                Debug.Log("NO SUB");
            }
            else
            {
                scoremin.text = scrsub.ToString() + "/" + stage1sub;
                float percentforsub = Mathf.Round((scrsub / stage1sub) * 100);
                scorepercentmin.text = percentforsub.ToString() + "%";
            }

            if (scradd == 0)
            {
                scoreadd.text = "-";
                scorepercentadd.text = "-";
                Debug.Log("NO ADD");
            }
            else
            {
                scoreadd.text = scradd.ToString() + "/" + stage1add;
                float percentforadd = Mathf.Round((scradd / stage1add) * 100);
                scorepercentadd.text = percentforadd.ToString() + "%";
            }
            scoremulti.text = "-";
            scorepercentmulyi.text = "-";
            scorediv.text = "-";
            scorepercentdiv.text = "-";
        }
        //stage 2
        if (GameManager.GetComponent<ScoreManager>().levelname == "lvl6star")
        {
            if (scradd2 == 0)
            {
                scoreadd.text = "-";
                scorepercentadd.text = "-";
            }
            else
            {
                scoreadd.text = scradd2.ToString() + "/" + stage2add;
                float percentforadd = Mathf.Round((scradd2 / stage2add) * 100);
                scorepercentadd.text = percentforadd.ToString() + "%";
            }

            if (scrsub2 == 0)
            {
                scoremin.text = "-";
                scorepercentmin.text = "-";
            }
            else
            {
                scoremin.text = scrsub2.ToString() + "/" + stage2sub;
                float percentforsub = Mathf.Round((scrsub2 / stage2sub) * 100);
                scorepercentmin.text = percentforsub.ToString() + "%";
            }

            if (scrmulti2 == 0)
            {
                scoremulti.text = "-";
                scorepercentmulyi.text = "-";
            }
            else
            {
                scoremulti.text = scrmulti2.ToString() + "/" + stage2multi;
                float percentformulti = Mathf.Round((scrmulti2 / stage2multi) * 100);
                scorepercentmulyi.text = percentformulti.ToString() + "%";
            }
            scorediv.text = "-";
            scorepercentdiv.text = "-";
        }
        //stage 3
        if (GameManager.GetComponent<ScoreManager>().levelname == "lvl9star")
        {
            if (scradd3 == 0)
            {
                scoreadd.text = "-";
                scorepercentadd.text = "-";
            }
            else
            {
                scoreadd.text = scradd3.ToString() + "/" + stage3add;
                float percentforadd = Mathf.Round((scradd3 / stage3add) * 100);
                scorepercentadd.text = percentforadd.ToString() + "%";
            }

            if (scrsub3 == 0)
            {
                scoremin.text = "-";
                scorepercentmin.text = "-";
            }
            else
            {
                scoremin.text = scrsub3.ToString() + "/" + stage3sub;
                float percentforsub = Mathf.Round((scrsub3 / stage3sub) * 100);
                scorepercentmin.text = percentforsub.ToString() + "%";
            }

            if (scrmulti3 == 0)
            {
                scoremulti.text = "-";
                scorepercentmulyi.text = "-";
            }
            else
            {
                scoremulti.text = scrmulti3.ToString() + "/" + stage3multi;
                float percentformulti = Mathf.Round((scrmulti3 / stage3multi) * 100);
                scorepercentmulyi.text = percentformulti.ToString() + "%";
            }

            if (scrdiv3 == 0)
            {
                scorediv.text = "-";
                scorepercentdiv.text = "-";
            }
            else
            {
                scorediv.text = scrdiv3.ToString() + "/" + stage3div;
                float percentfordiv = Mathf.Round((scrdiv3 / stage3div) * 100);
                scorepercentdiv.text = percentfordiv.ToString() + "%";
            }
        }
    }
}
