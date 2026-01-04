using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicController : MonoBehaviour
{
  public AudioSource audioSource;
  public AudioMixer audioMixer;

  public void SetMusicVolume(float volume)
  {
    audioMixer.SetFloat("Music", Mathf.Log10(volume) * 20);
  }


}
