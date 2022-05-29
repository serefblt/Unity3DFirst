using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowBall : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("YellowBall"))
        {
            Main._yellowBallScore++;



        }
    }
}
