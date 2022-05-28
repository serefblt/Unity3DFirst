using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GreenBall : MonoBehaviour
{
    private float _greenBallScore = 0;
  //  [SerializeField] Text _greenBallScoreText;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("GreenBall"))
        {
            _greenBallScore++;
      //      _greenBallScoreText.text = _greenBallScore.ToString();
            Debug.Log(_greenBallScore);
        }
    }
}
