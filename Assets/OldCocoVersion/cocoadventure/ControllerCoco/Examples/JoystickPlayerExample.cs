using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    float speed,jumpforce;
    public VariableJoystick variableJoystick;
    public Rigidbody rb;
    public Animator anim;
    public bool isairbourne,movementenabled;

    private void Start()
    {
        speed = 0.1f;
        jumpforce = 0;
    }

    public void FixedUpdate()
    {
        if (movementenabled==true)
        {
            Movement();
        }
    }
    public void Movement()
    {
        Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        transform.Translate(variableJoystick.Horizontal * speed, jumpforce, variableJoystick.Vertical * speed);
        MovementAnimation(variableJoystick.Horizontal, variableJoystick.Vertical);
    }
    public void MovementAnimation(float x,float y)
    {
        anim.SetFloat("horizontal", x);
        anim.SetFloat("vertical", y);
    }
    public void Jump()
    {
        if (isairbourne==false)
        {
            anim.Play("Jump");
            StartCoroutine(JumpDelay());
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        isairbourne = false;
    }
    private void OnCollisionExit(Collision collision)
    {
        isairbourne = true;
    }
    IEnumerator JumpDelay() {
        jumpforce = .3f;
        yield return new WaitForSeconds(.3f);
        jumpforce = 0;
    }
}