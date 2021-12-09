using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoringSystem : MonoBehaviour
{
    public GameObject Score;
    public static int theScore;
    


    void Update()
    {
        
        Score.GetComponent<Text>().text = "Score:" + theScore;

    }



}
