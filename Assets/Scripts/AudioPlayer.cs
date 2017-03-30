using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public List<AudioClip> clipList;
    public List<AudioSource> sourceList;

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
    public void AddAudio(string name, bool loop, bool playAwake, float vol, AudioClip clip = null)
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
        clipList.Add(clip);
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
    private AudioSource FindSource(string sourceName)
    {
        foreach (AudioSource s in sourceList)
        {
            if (s.name == sourceName) return s;
        }
        return null;
    }
}
