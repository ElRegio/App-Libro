using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Animations;





public class cambiarescena : MonoBehaviour {
	public Animator anim;
	public Animator anim2;

	void start()
	{
		anim = GetComponent<Animator>();
	}
	
	public void LoadScene(int nombrecual)
	{
		StartCoroutine(Espera(nombrecual));
		anim.SetTrigger("salida");
		anim2.SetTrigger("salida");
	}	
		
IEnumerator Espera(int nombrecual)
{
	yield return new WaitForSeconds (2);
	SceneManager.LoadScene(nombrecual);

}




}
