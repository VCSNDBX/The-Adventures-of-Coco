 using UnityEngine;
 using System.Collections;
 using UnityEngine.UI;
 using UnityEngine.Events;
 using UnityEngine.EventSystems;
 public class CharacterRotateController : MonoBehaviour
 {
 
    public bool isRacePressed = false;
    public bool isbrakePressed = false;
    public string buttondirection;
    public float enable,sensitivity;
    private Animator animator;
    public VariableJoystick variableJoystick;
    
     void Start () {
         animator = GetComponent<Animator>();
     }
    public void RotateCamera()
    {
        Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        applyrotation(variableJoystick.Horizontal);
        transform.Rotate(0,animator.GetFloat("horizontalrot")*sensitivity*Time.deltaTime,0);
    }
    void applyrotation(float x){
        animator.SetFloat("horizontalrot",x);
    }
     void Update () {
            RotateCamera();
     }
 }