using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFade : MonoBehaviour {


	public CanvasGroup uiElement;

	private float fadingVelocity = 0.01f;
	private bool isFadingIn = false;
	private bool isFadingOut = false;




	void Update(){

		if (isFadingIn) {
			uiElement.alpha += fadingVelocity;
			if (uiElement.alpha >= 1) {
				isFadingIn = false;
			}

		}

		if (isFadingOut) {
			uiElement.alpha -= fadingVelocity;
			if (uiElement.alpha <= 0)
				isFadingOut = false;
		}



	}


	public void TriggerFadeIn(){
		isFadingIn = true;
	}

	public void TriggerFadeOut(){
		isFadingOut = true;
	}





}
