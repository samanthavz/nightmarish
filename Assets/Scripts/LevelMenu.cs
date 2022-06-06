using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    public void Level1 ()
    {
        SceneManager.LoadScene("bootcamp");
    }
    
    public void Level2 ()
    {
        SceneManager.LoadScene("level2");
    }
    
    public void Level3 ()
    {
        SceneManager.LoadScene("level3");
    }
    
    public void Level4 ()
    {
        SceneManager.LoadScene("level4");
    }
}
