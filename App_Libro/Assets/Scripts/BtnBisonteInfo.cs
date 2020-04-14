using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnBisonteInfo : MonoBehaviour {

    string btnName;
    int Conteo;
    GameObject DatoBisonte;
    GameObject DatoAlamo;
    GameObject DatoSicomoro;
    GameObject DatoMaguey;
    GameObject DatoBisonte2;
    GameObject DatoBisonte3;

    // Use this for initialization
    void Start()
    {

        DatoBisonte = GameObject.Find("BisonteDato");
        DatoBisonte.SetActive(false);

        DatoBisonte2 = GameObject.Find("BisonteDato2");
        DatoBisonte2.SetActive(false);

        DatoBisonte3 = GameObject.Find("BisonteDato3");
        DatoBisonte3.SetActive(false);

        DatoAlamo = GameObject.Find("AlamoDato");
        DatoAlamo.SetActive(false);

        DatoSicomoro = GameObject.Find("SicomoroDato");
        DatoSicomoro.SetActive(false);

        DatoMaguey = GameObject.Find("MagueyDato");
        DatoMaguey.SetActive(false);
    }

    public void Next()
    {
            DatoBisonte.SetActive(false);   
            DatoBisonte2.SetActive(true);
    }
    public void Next2()
    {
        DatoBisonte2.SetActive(false);
        DatoBisonte3.SetActive(true);
    }
    public void Close()
    {
        DatoBisonte.SetActive(false);
        DatoBisonte2.SetActive(false);
        DatoBisonte3.SetActive(false);
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
                    case "Bisonte":
                      DatoBisonte.SetActive(true);
                        DatoAlamo.SetActive(false);
                        DatoSicomoro.SetActive(false);
                        DatoMaguey.SetActive(false);
                        DatoBisonte2.SetActive(false);
                        DatoBisonte3.SetActive(false);
                        break;

                    case "Alamo":
                        DatoAlamo.SetActive(true);
                        DatoBisonte.SetActive(false);
                        DatoSicomoro.SetActive(false);
                        DatoMaguey.SetActive(false);
                        DatoBisonte2.SetActive(false);
                        DatoBisonte3.SetActive(false);
                        break;

                    case "Sicomoro":
                        DatoSicomoro.SetActive(true);
                        DatoBisonte.SetActive(false);
                        DatoMaguey.SetActive(false);
                        DatoAlamo.SetActive(false);
                        DatoBisonte2.SetActive(false);
                        DatoBisonte3.SetActive(false);
                        break;

                    case "Maguey":
                        DatoMaguey.SetActive(true);
                        DatoBisonte.SetActive(false);
                        DatoAlamo.SetActive(false);
                        DatoSicomoro.SetActive(false);
                        DatoBisonte2.SetActive(false);
                        DatoBisonte3.SetActive(false);
                        break;

                }
            }

        }
    }
}
