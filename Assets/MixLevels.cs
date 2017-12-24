using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class MixLevels : MonoBehaviour {

    public AudioMixer masterMixer;
    public AudioMixer sfxMixer;

    public void SetSfxLvl(float sfxLvl)
    {
        masterMixer.SetFloat("sfxVol", sfxLvl);
    }

    public void SetMusicLvl(float musicLvl)
    {
        masterMixer.SetFloat("musicVol", musicLvl);
    }

    public void SetSoundToggle(bool value)
    {
        if (value)
        {
            masterMixer.SetFloat("masterVol", 0);
        }
        else
        {
            masterMixer.SetFloat("masterVol", -80);
        }
    }

    public void SetEchoToggle(bool value)
    {
        if (value)
        {
            
            sfxMixer.SetFloat("animalsEchoLv", 0.0f);
            sfxMixer.SetFloat("environEchoLv", -25.0f);
        }
        else
        {
           
            sfxMixer.SetFloat("animalsEchoLv", -80.0f);
            sfxMixer.SetFloat("environEchoLv", -80.0f);
        }
    }
}
