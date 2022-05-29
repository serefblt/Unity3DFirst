using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GreenBall : MonoBehaviour
{


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("GreenBall"))
        {
            Main._greenBallScore++;
            
            

        }


}
}
