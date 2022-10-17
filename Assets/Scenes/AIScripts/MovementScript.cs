using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MovementScript : MonoBehaviour
{
    public float movementspeed;
    private GameObject player;
    private bool isquestiongenerated;
    public GameObject questions;
    public bool isinrange;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(isinrange){
            FollowPlayer(true);
        }
    }
    public void FollowPlayer(bool enable){
        if(enable==true){
            transform.position = Vector3.MoveTowards(transform.position,player.transform.position, movementspeed*Time.deltaTime);
            transform.LookAt(player.transform.position);
        }
    }
    void Attack(){
        if(!isquestiongenerated){
            questions.SetActive(true);
            isquestiongenerated=true;
            Destroy(this);
        }
    }
    void OnCollisionEnter(Collision col){
        if(col.gameObject.tag=="Player"){
            Attack();
        }
    }
}
