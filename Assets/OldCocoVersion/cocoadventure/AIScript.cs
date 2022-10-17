using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIScript : MonoBehaviour
{
    public float attackdistance, detectiondistance,restrictiondistance,speed;
    private GameObject player,gamemanager;
    public bool isinrange,isalive,islastenemy;
    private Animator anim;
    public Quaternion deathrotation;
    // Start is called before the first frame update
    void Start()
    {
        gamemanager = GameObject.Find("GameManager");
        deathrotation = transform.rotation;
        anim = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (islastenemy==true&&isalive==false)
        {
            //star
        }
        if (Vector3.Distance(transform.position,player.transform.position) <= attackdistance)
        {
            isinrange=true;
        }
        if (Vector3.Distance(transform.position, player.transform.position) >= detectiondistance)
        {
            isinrange = false;
        }
        if (Vector3.Distance(transform.position, player.transform.position) <= restrictiondistance)
        {
            //if (gamemanager.GetComponent<PowerUpsManager>().powerupactivated==false)
            //{
            //    gamemanager.GetComponent<GenerateQuestionScript>().GenerateQuestion();
            //}
            isinrange = false;
        }
        if (isinrange==true&&isalive==true)
        {
            PlayerInRange();
        }
    }
    public void PlayerInRange()
    {
        gamemanager.GetComponent<GenerateQuestionScript>().enemynearby = gameObject;
        transform.LookAt(player.transform.position);
        transform.position = Vector3.MoveTowards(transform.position,player.transform.position,speed*Time.deltaTime);
    }
    public void Death()
    {
        anim.Play("AIDeathAnimation");
        isalive = false;
        transform.rotation = deathrotation;
        StartCoroutine(DeathDelay());
    }
    IEnumerator DeathDelay()
    {
        yield return new WaitForSeconds(1f);
        gamemanager.GetComponent<GenerateQuestionScript>().aquestionisgenerated = false;
        Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //if (gamemanager.GetComponent<PowerUpsManager>().powerupactivated==true&& gamemanager.GetComponent<PowerUpsManager>().powerupstype==2)
            //{
            //    Death();
            //}
        }
    }
}
