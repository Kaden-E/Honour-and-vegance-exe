using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwap : MonoBehaviour
{
    public GameObject gameWinUI;
    bool gameOver;


    void ShowGameWinUI()
    {
        OnGameOver(gameWinUI);
    }

    private void OnTriggerEnter(Collider Player)
    {
        gameOver = true;
    }
    void Update()
    {
        if (gameOver)
        {
            gameWinUI.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                ScoringSystem.theScore = 0;
                SceneManager.LoadScene(0);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }

    void OnGameOver(GameObject GameOverUI)
    {
        gameWinUI.SetActive(true);
        gameOver = true;
        GameObject rawImageGO = GameOverUI.transform.GetChild(0).gameObject;
        rawImageGO.GetComponent<RawImage>().enabled = true;
        GameObject textGO = GameOverUI.transform.GetChild(1).gameObject;
        textGO.GetComponent<Text>().enabled = true;


    }

}
