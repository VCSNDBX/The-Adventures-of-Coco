using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutortialTrigger : MonoBehaviour
{
    public Tutortial tutorial;

    public void TriggerTutortial()
    {
        FindObjectOfType<TutorialManager>().StartTutortial(tutorial);
    }

    private void Start()
    {
        TriggerTutortial();
    }
}
