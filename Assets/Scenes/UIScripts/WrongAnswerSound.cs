using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WrongAnswerSound : MonoBehaviour
{
    public WrongAnswerAudio[] sounds;
    void Awake()
    {
        foreach (WrongAnswerAudio s in sounds)
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
        WrongAnswerAudio s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }

    public void Stop(string name)
    {
        WrongAnswerAudio s = Array.Find(sounds, sound => sound.name == name);
        s.source.Stop();
    }
}
