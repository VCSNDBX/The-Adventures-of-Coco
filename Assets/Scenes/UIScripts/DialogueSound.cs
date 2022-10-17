using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class DialogueSound : MonoBehaviour
{
    public DialogueAudio[] sounds;
    void Awake()
    {
        foreach(DialogueAudio s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
        }
    }

    public void PlayVoice(int vi)
    {
        if (vi == 1)
        {
            Play("1");
        }
    }
    public void Play(string name)
    {
        DialogueAudio s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }

    public void Stop(string name)
    {
        DialogueAudio s = Array.Find(sounds, sound => sound.name == name);
        s.source.Stop();
    }
}
