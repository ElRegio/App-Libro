using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnPecariInfo : MonoBehaviour
{

    string btnName;
    int Conteo;
    GameObject DatoPecari;
    GameObject DatoCactus;
    GameObject DatoCoryphantha;
    GameObject DatoIzote;
    GameObject DatoPecari2;


    // Use this for initialization
    void Start()
    {

        DatoPecari = GameObject.Find("PecariDato");
        DatoPecari.SetActive(false);

        DatoPecari2 = GameObject.Find("PecariDato2");
        DatoPecari2.SetActive(false);

        DatoCactus = GameObject.Find("CactusDato");
        DatoCactus.SetActive(false);
            
        DatoCoryphantha = GameObject.Find("CoryphanthaDato");
        DatoCoryphantha.SetActive(false);

        DatoIzote = GameObject.Find("IzoteDato");
        DatoIzote.SetActive(false);
    }

    public void Next()
    {
        DatoPecari.SetActive(false);
        DatoPecari2.SetActive(true);
    }

    public void Close()
    {
        DatoPecari.SetActive(false);
        DatoPecari2.SetActive(false);
        DatoCactus.SetActive(false);
        DatoCoryphantha.SetActive(false);
        DatoIzote.SetActive(false);

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
                    case "Pecari":
                        DatoPecari.SetActive(true);
                        DatoCactus.SetActive(false);
                        DatoCoryphantha.SetActive(false);
                        DatoIzote.SetActive(false);
                        DatoPecari2.SetActive(false);
                        break;

                    case "Cactus":
                        DatoCactus.SetActive(true);
                        DatoPecari.SetActive(false);
                        DatoCoryphantha.SetActive(false);
                        DatoIzote.SetActive(false);
                        DatoPecari2.SetActive(false);
                        break;

                    case "Coryphantha":
                        DatoCoryphantha.SetActive(true);
                        DatoPecari.SetActive(false);
                        DatoIzote.SetActive(false);
                        DatoCactus.SetActive(false);
                        DatoPecari2.SetActive(false);
                        break;

                    case "Izote":
                        DatoIzote.SetActive(true);
                        DatoPecari.SetActive(false);
                        DatoCactus.SetActive(false);
                        DatoCoryphantha.SetActive(false);
                        DatoPecari2.SetActive(false);
                        break;

                }
            }

        }
    }
}
