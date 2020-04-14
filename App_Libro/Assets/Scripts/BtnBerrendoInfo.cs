using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnBerrendoInfo : MonoBehaviour
{

    string btnName;
    int Conteo;
    GameObject DatoBerrendo;
    GameObject DatoAlamo;
    GameObject DatoSicomoro;
    GameObject DatoMaguey;
    GameObject DatoBisonte2;
    GameObject DatoBisonte3;

    // Use this for initialization
    void Start()
    {

        DatoBerrendo = GameObject.Find("BerrendoDato");
        DatoBerrendo.SetActive(false);

        DatoAlamo = GameObject.Find("AlamoDato");
        DatoAlamo.SetActive(false);

        DatoSicomoro = GameObject.Find("SicomoroDato");
        DatoSicomoro.SetActive(false);

        DatoMaguey = GameObject.Find("MagueyDato");
        DatoMaguey.SetActive(false);
    }

    public void Next()
    {
        DatoBerrendo.SetActive(false);
        DatoBisonte2.SetActive(true);
    }
    public void Next2()
    {
        DatoBisonte2.SetActive(false);
        DatoBisonte3.SetActive(true);
    }
    public void Close()
    {
        DatoBerrendo.SetActive(false);
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
                    case "Berrendo":
                        DatoBerrendo.SetActive(true);
                        DatoAlamo.SetActive(false);
                        DatoSicomoro.SetActive(false);
                        DatoMaguey.SetActive(false);
                        DatoBisonte2.SetActive(false);
                        DatoBisonte3.SetActive(false);
                        break;

                    case "Alamo":
                        DatoAlamo.SetActive(true);
                        DatoBerrendo.SetActive(false);
                        DatoSicomoro.SetActive(false);
                        DatoMaguey.SetActive(false);
                        DatoBisonte2.SetActive(false);
                        DatoBisonte3.SetActive(false);
                        break;

                    case "Sicomoro":
                        DatoSicomoro.SetActive(true);
                        DatoBerrendo.SetActive(false);
                        DatoMaguey.SetActive(false);
                        DatoAlamo.SetActive(false);
                        DatoBisonte2.SetActive(false);
                        DatoBisonte3.SetActive(false);
                        break;

                    case "Maguey":
                        DatoMaguey.SetActive(true);
                        DatoBerrendo.SetActive(false);
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
