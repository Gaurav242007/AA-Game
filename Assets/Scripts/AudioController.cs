using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource HitSfx;
    public AudioSource LoseSfx;
    public AudioSource LevelWonSfx;
    public AudioSource SelectSfx;
    public AudioSource ScoreBoosterSfx;

    public AudioSource BgMusic;

    public void PlayHitSfx()
    {
        HitSfx.Play();
    }

    public void PlayWinSfx()
    {
        LevelWonSfx.Play();
    }

    public void PlayLoseSfx()
    {
        LoseSfx.Play();
    }

    public void PlayBGMusic()
    {
        BgMusic.Play();
    }

    public void StopBgMusic()
    {
        BgMusic.Stop();
    }

    public void PlayLevelWonSfx()
    {
        LevelWonSfx.Play();
    }

    public void PlaySelectUi()
    {
        SelectSfx.Play();
    }

    public void PlayScoreBooster()
    {
        ScoreBoosterSfx.Play();
    }
}
