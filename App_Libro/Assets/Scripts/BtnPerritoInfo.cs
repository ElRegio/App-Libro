using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnPerritoInfo : MonoBehaviour
{

    string btnName;
    int Conteo;
    GameObject DatoPerrito;
    GameObject DatoAlamo;
    GameObject DatoSicomoro;
    GameObject DatoMaguey;
    


    // Use this for initialization
    void Start()
    {

        DatoPerrito = GameObject.Find("ConejoDato");
        DatoPerrito.SetActive(false);

        DatoAlamo = GameObject.Find("AlamoDato");
        DatoAlamo.SetActive(false);

        DatoSicomoro = GameObject.Find("SicomoroDato");
        DatoSicomoro.SetActive(false);

        DatoMaguey = GameObject.Find("MagueyDato");
        DatoMaguey.SetActive(false);
    }

    

    public void Close()
    {
        DatoPerrito.SetActive(false);
        DatoAlamo.SetActive(false);
        DatoSicomoro.SetActive(false);
        DatoMaguey.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit))
            {
                btnName = Hit.transform.name;
                //btnName = Hit.transform.gameObject.tag;

                switch (btnName)
                {
                    case "Perrito":
                        DatoPerrito.SetActive(true);
                        DatoAlamo.SetActive(false);
                        DatoSicomoro.SetActive(false);
                        DatoMaguey.SetActive(false);
                        
                        break;

                    case "Alamo":
                        DatoAlamo.SetActive(true);
                        DatoPerrito.SetActive(false);
                        DatoSicomoro.SetActive(false);
                        DatoMaguey.SetActive(false);
                        
                        break;

                    case "Sicomoro":
                        DatoSicomoro.SetActive(true);
                        DatoPerrito.SetActive(false);
                        DatoMaguey.SetActive(false);
                        DatoAlamo.SetActive(false);
                        
                        break;

                    case "Maguey":
                        DatoMaguey.SetActive(true);
                        DatoPerrito.SetActive(false);
                        DatoAlamo.SetActive(false);
                        DatoSicomoro.SetActive(false);
                        
                        break;

                }
            }

        }
    }
}
