using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerStatusScript : MonoBehaviour
{
    public Image[] Hearts;
    public float healthpoints;
    public GameObject question, gameover;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator DeathDelay()
    {
        GetComponent<JoystickPlayerExample>().movementenabled = false;
        GetComponent<Animator>().Play("death");
        question.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        gameover.SetActive(true);
    }

    public void ShowQuestion(){
        question.SetActive(true);
    }
    public void Attack(){
        GetComponent<Animator>().Play("cocoattack");
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
                        StartCoroutine(DeathDelay());
                    }
                }
                else
                {
                }
            }
        }
    }
}
