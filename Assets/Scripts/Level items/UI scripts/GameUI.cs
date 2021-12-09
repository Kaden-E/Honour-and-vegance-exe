using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{

    public GameObject gameLoseUI;
    public GameObject gameWinUI;
    bool gameIsOver;


    void Start()
    {
        //Guard.OnGuardHasSpottedPlayer += ShowGameLoseUI;
        //gameLoseUI = GameObject.Find(Gamelose);


    }


    void Update()
    {
        if (gameIsOver)
        {


            ScoringSystem.theScore = 0;
            SceneManager.LoadScene(6);

        }
    }
}

   /* void ShowGameWinUI()
    {
        OnGameOver(gameWinUI);
    }

    void ShowGameLoseUI()
    {
        OnGameOver(gameLoseUI);
    }

   // public void OnGameOver(GameObject GameOverUI)
   // {
        //gameLoseUI.SetActive(true);
       // gameIsOver = true;
       // Guard.OnGuardHasSpottedPlayer -= ShowGameLoseUI;
       // GameObject rawImageGO = GameOverUI.transform.GetChild(0).gameObject;
       // rawImageGO.GetComponent<RawImage>().enabled = true;
       // GameObject textGO = GameOverUI.transform.GetChild(1).gameObject;
       // textGO.GetComponent<Text>().enabled = true;


   // }
}
   */