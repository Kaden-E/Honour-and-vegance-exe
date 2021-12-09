using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Reset : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ScoringSystem.theScore = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
