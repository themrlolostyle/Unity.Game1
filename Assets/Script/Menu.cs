using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        Application.LoadLevel("Game");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
