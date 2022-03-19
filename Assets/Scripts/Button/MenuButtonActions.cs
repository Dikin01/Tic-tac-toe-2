using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonActions : MonoBehaviour
{
    public void ExitGame()
    {
        Debug.Log("Вышли из игры");
        Application.Quit();
    }

    public void PlayClassicMode()
    {
        DataHolder.SceneBuilder = FindObjectOfType<GameModes>().ClassicSceneBuilder;
        SceneManager.LoadScene("EmptyScene");
    }

    public void PlayExtendMode()
    {
        DataHolder.SceneBuilder = FindObjectOfType<GameModes>().StrategySceneBuilder;
        SceneManager.LoadScene("EmptyScene");
    }

    public void Replay()
    {        
        SceneManager.LoadScene("EmptyScene");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("StartMenuScene");
    }
}
