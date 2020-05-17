using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnBorregoInfo : MonoBehaviour
{

    string btnName;
    int Conteo;
    GameObject DatoBorrego;
    GameObject DatoAlamo;
    GameObject DatoSicomoro;
    GameObject DatoMaguey;
    GameObject DatoBorrego2;
    GameObject DatoBorrego3;

    // Use this for initialization
    void Start()
    {

        DatoBorrego = GameObject.Find("BorregoDato");
        DatoBorrego.SetActive(false);

        DatoBorrego2 = GameObject.Find("BorregoDato2");
        DatoBorrego2.SetActive(false);

        DatoBorrego3 = GameObject.Find("BorregoDato3");
        DatoBorrego3.SetActive(false);

        DatoAlamo = GameObject.Find("AlamoDato");
        DatoAlamo.SetActive(false);

        DatoSicomoro = GameObject.Find("SicomoroDato");
        DatoSicomoro.SetActive(false);

        DatoMaguey = GameObject.Find("MagueyDato");
        DatoMaguey.SetActive(false);
    }

    public void Next()
    {
        DatoBorrego.SetActive(false);
        DatoBorrego2.SetActive(true);
    }
    public void Next2()
    {
        DatoBorrego2.SetActive(false);
        DatoBorrego3.SetActive(true);
    }
    public void Close()
    {
        DatoBorrego.SetActive(false);
        DatoBorrego2.SetActive(false);
        DatoBorrego3.SetActive(false);
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
                    case "Borrego":
                        DatoBorrego.SetActive(true);
                        DatoAlamo.SetActive(false);
                        DatoSicomoro.SetActive(false);
                        DatoMaguey.SetActive(false);
                        DatoBorrego2.SetActive(false);
                        DatoBorrego3.SetActive(false);
                        break;

                    case "Alamo":
                        DatoAlamo.SetActive(true);
                        DatoBorrego.SetActive(false);
                        DatoSicomoro.SetActive(false);
                        DatoMaguey.SetActive(false);
                        DatoBorrego2.SetActive(false);
                        DatoBorrego3.SetActive(false);
                        break;

                    case "Sicomoro":
                        DatoSicomoro.SetActive(true);
                        DatoBorrego.SetActive(false);
                        DatoMaguey.SetActive(false);
                        DatoAlamo.SetActive(false);
                        DatoBorrego2.SetActive(false);
                        DatoBorrego3.SetActive(false);
                        break;

                    case "Maguey":
                        DatoMaguey.SetActive(true);
                        DatoBorrego.SetActive(false);
                        DatoAlamo.SetActive(false);
                        DatoSicomoro.SetActive(false);
                        DatoBorrego2.SetActive(false);
                        DatoBorrego3.SetActive(false);
                        break;

                }
            }

        }
    }
}
