using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWin : MonoBehaviour
{

    GameObject gameWinUI;


    private void OnTriggerEnter(Collider Player)
    {
        gameWinUI.SetActive(true);
    }

}
