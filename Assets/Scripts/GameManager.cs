using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool hasGameEnded = false;

    public Rotator rotator;
    public Spawner spawner;
    public Animator animator;

    public void EndGame()
    {
        if (hasGameEnded)
            return;

        rotator.enabled = false;
        spawner.enabled = false;
        animator.SetTrigger("EndGame");

        hasGameEnded = true;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}
