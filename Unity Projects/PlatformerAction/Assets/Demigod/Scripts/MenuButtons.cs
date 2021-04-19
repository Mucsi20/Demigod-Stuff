using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuButtons : MonoBehaviour
{
    public void PlayButtonPress()
    {
        SceneManager.LoadScene("Level1");
    }
    public void OptionsButtonPress()
    {
        SceneManager.LoadScene("Options", LoadSceneMode.Additive);
    }
    public void QuitButtonPress()
    {
        Application.Quit();
    }
}
