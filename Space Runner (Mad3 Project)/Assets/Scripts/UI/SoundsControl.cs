using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundsControl : MonoBehaviour
{
    private static readonly string FirstPlay = "FirstPlay";
    private static readonly string BackGroundPref = "BackGroundPref";
    private static readonly string SoundEffectsPref = "SoundEffectsPref";

    private int firstPlayInt;
    public Slider backGroundSlider, soundEffectsSlider;
    private float backgroundFloat, soundEffectsFloat;
    public AudioSource backGroundMusic;
    public AudioSource[] soundEffectsAudio;

    // Start is called before the first frame update
    void Start()
    {
        firstPlayInt = PlayerPrefs.GetInt(FirstPlay);
        // when first time open game 
        if(firstPlayInt == 0)
        {
            backgroundFloat = .25f;
            soundEffectsFloat = .75f;
            backGroundSlider.value = backgroundFloat;
            soundEffectsSlider.value = soundEffectsFloat;
            PlayerPrefs.SetFloat(BackGroundPref, backgroundFloat);
            PlayerPrefs.SetFloat(SoundEffectsPref, soundEffectsFloat);
            PlayerPrefs.SetInt(FirstPlay, -1);
        }
        else
        {
            backgroundFloat =  PlayerPrefs.GetFloat(BackGroundPref);
            backGroundSlider.value = backgroundFloat;
            soundEffectsFloat = PlayerPrefs.GetFloat(SoundEffectsPref);
            soundEffectsSlider.value = soundEffectsFloat;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // save sound settings throughout the game
    public void SaveSoundSettings()
    {
        PlayerPrefs.SetFloat(BackGroundPref, backgroundFloat);
        PlayerPrefs.SetFloat(SoundEffectsPref, soundEffectsFloat);
    }
    // when player exits the game or pause it we save these values
    private void OnApplicationFocus(bool focus)
    {
        if(!focus)
        {
            SaveSoundSettings();
        }
    }

    public void UpdateSound()
    {
        backGroundMusic.volume = backGroundSlider.value;
        // we can have any value in the array
        for(int i = 0; i< soundEffectsAudio.Length; i++)
        {
            soundEffectsAudio[i].volume = soundEffectsSlider.value;
        }
    }
}
