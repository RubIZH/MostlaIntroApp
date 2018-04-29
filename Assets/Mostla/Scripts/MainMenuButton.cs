using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour {

	public Button mainMenuButton;



	void Start()
	{
		Button btn = mainMenuButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		transition ();
		SceneManager.LoadScene (1);

	}


	IEnumerator transition(){
		float fadeTime = GameObject.Find ("Fading").GetComponent<SceneFading> ().BeginFade (1);
		yield return new WaitForSeconds(fadeTime);
		
	}


}
