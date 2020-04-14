using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePanel : MonoBehaviour {

    GameObject Dato;


    void Start()
    {

        Dato = GameObject.Find("Panel");
     
    }
    public void Close()
    {

        Dato.SetActive(false);

    }
}
