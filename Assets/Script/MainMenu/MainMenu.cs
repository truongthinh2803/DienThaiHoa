using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartApp()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void ExitApp()
    {
        Application.Quit();
    }
}
