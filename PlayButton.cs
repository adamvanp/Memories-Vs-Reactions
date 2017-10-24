//Adam Van Peelen 2017
//    Used to load specific levels of the game
//    03/10/2017
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{

    public void LoadLevel()
    {
        SceneManager.LoadScene(1);

    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);

    }
}
