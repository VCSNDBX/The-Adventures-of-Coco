using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathDaemonVanish : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Vanishcount());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Vanishcount(){
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
}
