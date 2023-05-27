using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool hasGameEnded = false;
    public static bool hasLevelCompleted;

    public Rotator rotator;
    public Spawner spawner;
    public Animator animator;
    public string NextLevelScene;
    public GameObject LevelWonUi;

    void Start()
    {
        FindObjectOfType<AudioController>().GetComponent<AudioController>().PlayBGMusic();
        hasLevelCompleted = false;
        LevelWonUi.SetActive(false);
    }

    void Update()
    {
        if (hasLevelCompleted)
        {
            Debug.Log("Completed Level");
            LevelComplete();
        }
    }

    public void EndGame()
    {
        if (hasGameEnded)
            return;
        rotator.enabled = false;
        spawner.enabled = false;
        FindObjectOfType<AudioController>().GetComponent<AudioController>().StopBgMusic();
        FindObjectOfType<AudioController>().GetComponent<AudioController>().PlayLoseSfx();
        animator.SetTrigger("EndGame");

        hasGameEnded = true;

    }

    public void LevelComplete()
    {
        rotator.enabled = false;
        spawner.enabled = false;
        FindObjectOfType<AudioController>().GetComponent<AudioController>().StopBgMusic();
        FindObjectOfType<AudioController>().GetComponent<AudioController>().PlayWinSfx();
        animator.SetTrigger("LevelWin");
    }

    public void AnimateLevelWin()
    {
        LevelWonUi.SetActive(true);
    }

    public void LoadNextLevel()
    {
        FindObjectOfType<AudioController>().GetComponent<AudioController>().PlaySelectUi();
        SceneManager.LoadScene(NextLevelScene);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}
