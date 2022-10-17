using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shovelscript : MonoBehaviour
{
    private GameObject GameManager;
    public int shovelamount;
    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag=="CocoRig")
        {
            //GameManager.GetComponent<PowerUpsManager>().AddShovel(shovelamount);
            Destroy(gameObject);
        }
    }
}
