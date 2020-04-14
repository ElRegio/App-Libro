using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class cambiarrapido : MonoBehaviour {

	

   
    public void cambiar(int nombrecual)
   { 

   int nivel;

   nivel=nombrecual;
   SceneManager.LoadScene(nivel);
    	
   }
	



}