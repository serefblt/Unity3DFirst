using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBall : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("BlueBall"))
        {
            Main._blueBallScore++;



        }

    }
}