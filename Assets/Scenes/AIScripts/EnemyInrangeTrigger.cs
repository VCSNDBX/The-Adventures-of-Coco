using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInrangeTrigger : MonoBehaviour
{
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag=="Player"){
            enemy.GetComponent<MovementScript>().isinrange=true;
        }
    }
}
