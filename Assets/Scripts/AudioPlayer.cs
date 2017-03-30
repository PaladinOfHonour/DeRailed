﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public List<AudioClip> clipList = new List<AudioClip>();
    public List<AudioSource> sourceList = new List<AudioSource>();

    public AudioClip clip;

    public AudioSettings MyAudioSettings;

    /// <summary>
    /// Gets Called before Start: useful for referencing scripts
    /// </summary>
    public void Awake()
    {
    }

    /// <summary>
    /// Gets Called before first Update Loop: useful for initializing fields
    /// </summary>
    void Start()
    {
        //AddAudio("source", true, true, 1f, clip);
        //Play("source");
    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    /// <param name="loop"></param>
    /// <param name="playAwake"></param>
    /// <param name="vol"></param>
    /// <param name="clip"></param>
    public void AddAudio(string name, bool loop, bool playAwake, float vol, AudioClip clip)
    {
        if (FindSource(name) != null)
        {
            Debug.Log("Method: AddAudio quit due to the given name not being unique."); //logs error
            return;                                                                     //checks wether the primary key: name is unique
        }

        AudioSource newAudio = gameObject.AddComponent<AudioSource>();

        newAudio.name = name;
        newAudio.loop = loop;
        newAudio.playOnAwake = playAwake;
        newAudio.volume = vol;
        newAudio.clip = clip;

        sourceList.Add(newAudio);
        if (FindClip(clip) == null) clipList.Add(clip);

        return;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sourceName"></param>
    public void Play(string sourceName)
    {
        FindSource(sourceName).Play();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sourceName"></param>
    public void Stop(string sourceName)
    {
        FindSource(sourceName).Stop();
    }

    /// <summary>
    /// Overwrites
    /// </summary>
    /// <param name="sourceName"></param>
    /// <param name="clip"></param>
    public void AddClip(string sourceName, AudioClip clip)
    {
        FindSource(sourceName).clip = clip;
        clipList.Add(clip);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sourceName"></param>
    /// <returns></returns>
    public AudioSource FindSource(string sourceName)
    {
        if (sourceList.Count <= 0) return null;

        foreach (AudioSource s in sourceList)
        {
            if (s == null) return null;
            if (s.name.Equals(sourceName))
            {
                return s;
            }
        }
        return null;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="clipName"></param>
    /// <returns></returns>
    public AudioClip FindClip(string clipName)
    {
        if (clipList.Count <= 0) return null;

        foreach (AudioClip c in clipList)
        {
            if (c == null) return null;
            if (c.name.Equals(clipName))
            {
                return c;
            }
        }
        return null;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="clip"></param>
    /// <returns></returns>
    public AudioClip FindClip(AudioClip clip)
    {
        if (clipList.Count <= 0) return null;

        foreach (AudioClip c in clipList)
        {
            if (c == null) return null;
            if (clip.Equals(clip)) return c;
        }
        return null;
    }
}
