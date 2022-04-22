using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeManager : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioMixer mixer;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeSound()
    {
        mixer.SetFloat("Sound Effect", volumeSlider.value);
    }
}
