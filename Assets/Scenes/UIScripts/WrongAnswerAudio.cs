using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class WrongAnswerAudio
{
    public string name;
    public AudioClip clip;

    [HideInInspector]
    public AudioSource source;
}
