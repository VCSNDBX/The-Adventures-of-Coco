using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MathDaemonStatusScript : MonoBehaviour
{
    private string health;
    public Image[] Hearts;
    public GameObject evalpanel, EvalManager;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("MathDaemonHP",6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(float damage)
    {
        if (Hearts[2].fillAmount>0)
        {
            Hearts[2].fillAmount -= damage;
        }
        else
        {
            if (Hearts[1].fillAmount > 0)
            {
                Hearts[1].fillAmount -= damage;
            }
            else
            {
                if (Hearts[0].fillAmount>0)
                {
                    Hearts[0].fillAmount -= damage;
                    if (Hearts[0].fillAmount==0)
                    {
                        PlayerPrefs.SetFloat("lvl9star",3);
                        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                        EvalManager.GetComponent<EvalGlobalControl>().Eval();
                        evalpanel.SetActive(true);
                    }
                }
                else
                {
                }
            }
        }
    }
}
