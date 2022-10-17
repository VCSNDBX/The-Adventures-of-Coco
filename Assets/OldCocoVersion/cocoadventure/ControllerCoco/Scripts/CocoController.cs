using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CocoController : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Walk();
    }
    void Walk() {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        WalkAnimation(x,y);
        transform.Translate(x*Time.deltaTime, 0,y*Time.deltaTime);

    }
    void WalkAnimation(float x,float y) {
        anim.SetFloat("horizontal",x);
        anim.SetFloat("vertical", y);
    }
}
