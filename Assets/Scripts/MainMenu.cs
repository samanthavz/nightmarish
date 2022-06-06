using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    public string sceneName;
    
    public void PlayGame ()
    {
        SceneManager.LoadScene(sceneName);
    }
    
    public void QuitGame ()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
