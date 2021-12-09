using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Onclicklvl1: MonoBehaviour
{
	public Button MyButton;

	void Start()
	{
		Button btn = MyButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		SceneManager.LoadScene(2);
		Destroy(GameObject.Find("MenuMusic"));
	}




	public void QuitGame()
    {
		Debug.Log("QUIT");
		Application.Quit();
    }



}



