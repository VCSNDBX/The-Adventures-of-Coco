using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CocoAnimController : MonoBehaviour
{
    static Animator anim;
    public float speed = 2.0f;
    public float rotationSpeed = 75.0f;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("vertical")*speed;
        float rotation = Input.GetAxis("horizontal") * speed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.Translate(0,0, translation);
        transform.Rotate(0, rotation, 0);

        if (translation != 0)
        {
            anim.SetBool("IsWalking", true);
        }
        else
        {
            anim.SetBool("IsWalking", false);
        }
    }
}
