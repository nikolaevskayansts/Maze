using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource startSource;
    public AudioSource firstSource;
    public AudioSource secondSource;
    public AudioClip[] audioSources;
    public AudioClip startClip;
    float timeLeft;

    private void Start()
    {
        timeLeft = 10;

    }

    private void Update()
    {
        timeLeft -= Time.deltaTime;

        if (!startSource.isPlaying)
        {
            StartSoundness();
        }
        if (!firstSource.isPlaying && timeLeft < 3 && !MenuController.GameIsPaused)
        {
            FirstSoundness();
        }
        if (!secondSource.isPlaying && timeLeft < 0 && !MenuController.GameIsPaused)
        {
            SecondSoundness();
        }
        if (MenuController.GameIsPaused)
        {
            firstSource.pitch = 0;
            secondSource.pitch = 0;
        }
        if(!MenuController.GameIsPaused)
        {
            firstSource.pitch = 1;
            secondSource.pitch = 1;
        }

    }

    void StartSoundness()
    {
        startSource.clip = startClip;
        startSource.Play();
    }
    void FirstSoundness()
    {
        firstSource.clip = audioSources[Random.Range(0, audioSources.Length)];
        firstSource.Play();
    }
    void SecondSoundness()
    {
        secondSource.clip = audioSources[Random.Range(0, audioSources.Length)];
        secondSource.Play();

    }
}
