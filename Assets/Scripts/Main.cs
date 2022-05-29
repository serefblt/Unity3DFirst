using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public static int _greenBallScore = 0;
    public static int _blueBallScore = 0;
    public static int _yellowBallScore = 0;
    public static int _pinkBallScore = 0;
    [SerializeField] Text _greenBallScoreText, _blueBallScoreText, _yellowBallScoreText, _pinkBallScoreText;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        _greenBallScoreText.text = _greenBallScore.ToString();
        _blueBallScoreText.text = _blueBallScore.ToString();
        _yellowBallScoreText.text = _yellowBallScore.ToString();
        _pinkBallScoreText.text = _pinkBallScore.ToString();
    }

}
