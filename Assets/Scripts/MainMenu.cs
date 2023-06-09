using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadLevels()
    {
        FindObjectOfType<AudioController>().GetComponent<AudioController>().PlaySelectUi();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitApplication()
    {
        Application.Quit();
    }
}
