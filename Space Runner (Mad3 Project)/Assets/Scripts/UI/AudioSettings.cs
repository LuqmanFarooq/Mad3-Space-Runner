using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSettings : MonoBehaviour
{
    private static readonly string BackGroundPref = "BackGroundPref";
    private static readonly string SoundEffectsPref = "SoundEffectsPref";

    private float backgroundFloat, soundEffectsFloat;
    public AudioSource backGroundMusic;
    public AudioSource[] soundEffectsAudio;
    private void Awake()
    {
        ContinueSettings();
    }

    public void ContinueSettings()
    {
        backgroundFloat = PlayerPrefs.GetFloat(BackGroundPref);
        soundEffectsFloat = PlayerPrefs.GetFloat(SoundEffectsPref);

        backGroundMusic.volume = backgroundFloat;
        // we can have any value in the array
        for (int i = 0; i < soundEffectsAudio.Length; i++)
        {
            soundEffectsAudio[i].volume = soundEffectsFloat;
        }
    }


}
