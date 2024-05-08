using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

// MANAGES ALL AUDIO FOR GAME.

public class AudioManager : MonoBehaviour
{
    // audio mixer.
    public AudioMixer mixer;

    // audio sliders.
    public Slider masterSlider;
    public Slider bgmSlider;
    public Slider sfxSlider;

    // set default slider values.
    void Start() {
        masterSlider.value = PlayerPrefs.GetFloat("Master Volume", 0.75f);
        bgmSlider.value = PlayerPrefs.GetFloat("BGM Volume", 0.75f);
        sfxSlider.value = PlayerPrefs.GetFloat("SFX Volume", 0.75f);
    }

    public void SetMasterVol (float sliderValue)
    {
        mixer.SetFloat("masterVol", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("Master Volume", sliderValue);
    }

    public void SetBGMVol (float sliderValue)
    {
        mixer.SetFloat("bgmVol", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("BGM Volume", sliderValue);
    }

    public void SetSFXVol (float sliderValue)
    {
        mixer.SetFloat("sfxVol", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("SFX Volume", sliderValue);
    }
}
