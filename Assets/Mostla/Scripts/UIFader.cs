using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFader : MonoBehaviour {


	public bool isTimed = false;
	public float fadeInAfter = 0;
	public float fadeOutAfter = 0;
	public CanvasGroup uiElement;

	private float fadingVelocity = 0.01f;
	private bool isFadingIn = true;
	private bool isFadingOut = false;


	void Start(){

		StartCoroutine (FadeInAfterTime(fadeInAfter));
	}



	void Update(){

		if (isFadingIn) {
			uiElement.alpha += fadingVelocity;
			if (uiElement.alpha >= 1) {
				isFadingIn = false;
				if (isTimed) {
					StartCoroutine (FadeOutAfterTime(fadeOutAfter));
				}
			}

		}

		if (isFadingOut) {
			uiElement.alpha -= fadingVelocity;
			if (uiElement.alpha <= 0)
				isFadingOut = false;
		}



	}


	void FadeIn(){
		isFadingIn = true;
	}

	void FadeOut(){
		isFadingOut = true;
	}

	IEnumerator FadeOutAfterTime(float time){

		yield return new WaitForSeconds (time);
		isFadingOut = true;
	}

	IEnumerator FadeInAfterTime(float time){

		yield return new WaitForSeconds (time);
		isFadingIn = true;
	}



}
