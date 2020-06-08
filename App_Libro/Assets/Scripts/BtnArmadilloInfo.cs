using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnArmadilloInfo : MonoBehaviour
{

    string btnName;
    int Conteo;
    GameObject DatoArmadillo;
    GameObject DatoCazahuate;
    GameObject DatoColorin;
    GameObject DatoCactus;
    GameObject DatoArmadillo2;
    GameObject DatoArmadillo3;

    // Use this for initialization
    void Start()
    {

        DatoArmadillo = GameObject.Find("ArmadilloDato");
        DatoArmadillo.SetActive(false);

        DatoArmadillo2 = GameObject.Find("ArmadilloDato2");
        DatoArmadillo2.SetActive(false);

        DatoArmadillo3 = GameObject.Find("ArmadilloDato3");
        DatoArmadillo3.SetActive(false);

        DatoColorin = GameObject.Find("ColorinDato");
        DatoColorin.SetActive(false);

        DatoCazahuate = GameObject.Find("CazahuateDato");
        DatoCazahuate.SetActive(false);

        DatoCactus = GameObject.Find("CactusDato");
        DatoCactus.SetActive(false);

              

    }

    public void Next()
    {
        DatoArmadillo.SetActive(false);
        DatoArmadillo2.SetActive(true);

    }
    public void Next2()
    {
        DatoArmadillo2.SetActive(false);
        DatoArmadillo3.SetActive(true);
    }
    public void Close()
    {
        DatoArmadillo.SetActive(false);
        DatoArmadillo2.SetActive(false);
        DatoArmadillo3.SetActive(false);
        DatoColorin.SetActive(false);
        DatoCazahuate.SetActive(false);
        DatoCactus.SetActive(false); 
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
                    case "Armadillo":
                        DatoArmadillo.SetActive(true);
                        DatoCazahuate.SetActive(false);
                        DatoColorin.SetActive(false);
                        DatoCactus.SetActive(false);
                        DatoArmadillo2.SetActive(false);
                        break;

                    case "Cazahuate":
                        DatoCazahuate.SetActive(true);
                        DatoArmadillo.SetActive(false);
                        DatoColorin.SetActive(false);
                        DatoCactus.SetActive(false);
                        DatoArmadillo2.SetActive(false);
                        break;

                    case "Colorin":
                        DatoColorin.SetActive(true);
                        DatoArmadillo.SetActive(false);
                        DatoCazahuate.SetActive(false);
                        DatoCactus.SetActive(false);
                        DatoArmadillo2.SetActive(false);
                        break;

                    case "Cactus":
                        DatoCactus.SetActive(true);
                        DatoArmadillo.SetActive(false);
                        DatoCazahuate.SetActive(false);
                        DatoColorin.SetActive(false);
                        DatoArmadillo2.SetActive(false);
                        break;
                                           


                }
            }

        }
    }
}
