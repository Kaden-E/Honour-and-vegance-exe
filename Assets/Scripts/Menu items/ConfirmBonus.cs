using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ConfirmBonus : MonoBehaviour
{
	public Button MyButton;

	void Start()
	{
		Button btn = MyButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		//Destroy(GameObject.Find("MenuMusic"));
		SceneManager.LoadScene(5);
	}

}
