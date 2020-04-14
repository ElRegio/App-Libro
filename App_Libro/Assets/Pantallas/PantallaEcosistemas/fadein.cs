using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fadein : MonoBehaviour {

	public CanvasGroup uiElement;
	// Use this for initialization
	public void FadeIn()
	{
		StartCoroutine(FadeCanvasGroup(uiElement, uiElement.alpha, 1));
	}

	public void FadeOut()
	{
		StartCoroutine(FadeCanvasGroup(uiElement, uiElement.alpha, 0));
	}

	public IEnumerator FadeCanvasGroup(CanvasGroup cg, float star, float end, float lerpTime = 0.5f)
	{
		float _timeStartedLerping = Time.time;
		float timeSinceStarted = Time.time - _timeStartedLerping;
		float percentegeComplete = timeSinceStarted / lerpTime;

		while(true)
		{
			timeSinceStarted = Time.time - _timeStartedLerping;
			percentegeComplete = timeSinceStarted / lerpTime;
			
			float currentValue = Mathf.Lerp(star,end,percentegeComplete);
			cg.alpha = currentValue;

			yield return new WaitForEndOfFrame();
		}
	}
}
