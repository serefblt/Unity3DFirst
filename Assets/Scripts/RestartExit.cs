using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartExit : MonoBehaviour
{
public void Restart()
    {
        SceneManager.LoadScene(0);
    Main._greenBallScore = 0;
    Main._blueBallScore = 0;
    Main._yellowBallScore = 0;
    Main._pinkBallScore = 0;
}

public void Exit()
    {
        Application.Quit();
    }
}
