using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkBall : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PinkBall"))
        {
            Main._pinkBallScore++;



        }
    }
}
