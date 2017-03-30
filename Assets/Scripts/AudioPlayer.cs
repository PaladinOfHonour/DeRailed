using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// handles audio-sources and provides accesibility to audio from other scripts
/// </summary>
public class AudioPlayer : MonoBehaviour
{
    public List<AudioClip> clipList = new List<AudioClip>();
    public List<AudioSource> sourceList = new List<AudioSource>();

    //public AudioClip clip;

    public AudioSettings MyAudioSettings;   //Allows for Customized Audio settings

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
    /// Adds an AudioSource to the sourceList, whilst setting its properties
    /// </summary>
    /// <param name="name">Primary Key; is used to find Sources in the list</param>
    /// <param name="loop">Sets wether or not the audioclip loops</param>
    /// <param name="playAwake">Sets wether or not the audioclip should play as soon as it's loaded in</param>
    /// <param name="vol">Sets the volume of the audio-source; 0~1 </param>
    /// <param name="clip">Gives the audioclip that the audio-source ought to play</param>
    public void AddAudio(string name, bool loop, bool playAwake, float vol, AudioClip clip)
    {
        if (FindSource(name) != null)                                                   //checks for duplicates
        {
            Debug.Log("Method: AddAudio quit due to the given name not being unique."); //logs error
            return;                                                                     //checks wether the primary key: name is unique
        }

        AudioSource newAudio = gameObject.AddComponent<AudioSource>();                  //Adds a new AudioSource to the AudioHandler

        //setting of given properties
        newAudio.name = name;
        newAudio.loop = loop;
        newAudio.playOnAwake = playAwake;
        newAudio.volume = vol;
        newAudio.clip = clip;

        //adding entries to lists; without duplicates
        sourceList.Add(newAudio);
        if (FindClip(clip) == null) clipList.Add(clip);

        return;
    }

    /// <summary>
    /// Plays the given audio-source
    /// </summary>
    /// <param name="sourceName">Name of the audio-source; used to find the source in the list</param>
    public void Play(string sourceName)
    {
        FindSource(sourceName).Play();
    }

    /// <summary>
    /// tops the given audio-source
    /// </summary>
    /// <param name="sourceName">Name of the audio-source; used to find the source in the list</param>
    public void Stop(string sourceName)
    {
        FindSource(sourceName).Stop();
    }

    /// <summary>
    /// Scriptually adds an audioclip to a source; Overwrites
    /// </summary>
    /// <param name="sourceName"></param>
    /// <param name="clip"></param>
    public void AddClip(string sourceName, AudioClip clip)
    {
        FindSource(sourceName).clip = clip;
        if (FindClip(clip) == null) clipList.Add(clip);
    }

    /// <summary>
    /// Returns an audio-source corresponding to its entry in the list; if nothing found -> returns null. Checks for NullRef
    /// </summary>
    /// <param name="sourceName">Key to find corresponding entry in list</param>
    /// <returns></returns>
    public AudioSource FindSource(string sourceName)
    {
        if (sourceList.Count <= 0) return null;

        foreach (AudioSource s in sourceList)
        {
            if (s == null) return null;                 //Prevent NullRef
            if (s.name.Equals(sourceName)) return s;    // == operator checks for same instance and wouldn't work here
        }
        return null;                                    //Nothing found
    }

    /// <summary>
    /// Returns an audioclip corresponding to its entry in the list; if nothing found -> returns null. Checks for NullRef
    /// </summary>
    /// <param name="clipName">Key to find corresponding entry in list</param>
    /// <returns></returns>
    public AudioClip FindClip(string clipName)
    {
        if (clipList.Count <= 0) return null;

        foreach (AudioClip c in clipList)
        {
            if (c == null) return null;                 //Prevent NullRef
            if (c.name.Equals(clipName)) return c;      // == operator checks for same instance and wouldn't work here
        }
        return null;                                    //Nothing found
    }

    /// <summary>
    /// Returns an audioclip corresponding to its entry in the list; if nothing found -> returns null. Checks for NullRef
    /// </summary>
    /// <param name="clip">Checks for clip in cliplist</param>
    /// <returns></returns>
    public AudioClip FindClip(AudioClip clip)
    {
        if (clipList.Count <= 0) return null;

        foreach (AudioClip c in clipList)
        {
            if (c == null) return null;                 //Prevent NullRef
            if (clip.Equals(clip)) return c;            // == operator checks for same instance and wouldn't work here
        }
        return null;                                    //Nothing found
    }
}
