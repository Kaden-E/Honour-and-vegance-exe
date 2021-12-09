using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserDetect : MonoBehaviour
{
    GameObject gameLoseUI;
    bool gameIsOver;

    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.CompareTag("Collect"))
        {
            Destroy(collision.gameObject);
        }

    }


}



    