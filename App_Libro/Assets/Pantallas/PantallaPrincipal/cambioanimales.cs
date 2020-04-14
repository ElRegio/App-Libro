using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class cambioanimales : MonoBehaviour {
	
	public void LoadScene(int numeroescena)
	{
		StartCoroutine(lento(numeroescena));
	}	

IEnumerator lento(int numeroescena)
{
	yield return new WaitForSeconds (1);
	SceneManager.LoadScene(numeroescena);

}




	
		}
