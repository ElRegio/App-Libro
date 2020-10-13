using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnOceloteInfo : MonoBehaviour
{

    string btnName;
    int Conteo;
    GameObject DatoOcelote;
    GameObject DatoCazahuate;
    GameObject DatoColorin;
    GameObject DatoCactus;
    GameObject DatoOcelote2;

    // Use this for initialization
    void Start()
    {

        DatoOcelote = GameObject.Find("OceloteDato");
        DatoOcelote.SetActive(false);

        DatoOcelote2 = GameObject.Find("OceloteDato2");
        DatoOcelote2.SetActive(false);

        DatoColorin = GameObject.Find("ColorinDato");
        DatoColorin.SetActive(false);

        DatoCazahuate = GameObject.Find("CazahuateDato");
        DatoCazahuate.SetActive(false);

        DatoCactus = GameObject.Find("CactusDato");
        DatoCactus.SetActive(false);



    }

    public void OCeloteNext()
    {
        DatoOcelote.SetActive(false);
        DatoOcelote2.SetActive(true);

    }
    public void Close()
    {
        DatoOcelote.SetActive(false);
        DatoOcelote2.SetActive(false);
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
                    case "Ocelote":
                        DatoOcelote.SetActive(true);
                        DatoCazahuate.SetActive(false);
                        DatoColorin.SetActive(false);
                        DatoCactus.SetActive(false);
                        DatoOcelote2.SetActive(false);
                        break;

                    case "Cazahuate":
                        DatoCazahuate.SetActive(true);
                        DatoOcelote.SetActive(false);
                        DatoColorin.SetActive(false);
                        DatoCactus.SetActive(false);
                       
                        break;

                    case "Colorin":
                        DatoColorin.SetActive(true);
                        DatoOcelote.SetActive(false);
                        DatoCazahuate.SetActive(false);
                        DatoCactus.SetActive(false);
                       
                        break;

                    case "Cactus":
                        DatoCactus.SetActive(true);
                        DatoOcelote.SetActive(false);
                        DatoCazahuate.SetActive(false);
                        DatoColorin.SetActive(false);
                       
                        break;

                }
            }

        }
    }
}
