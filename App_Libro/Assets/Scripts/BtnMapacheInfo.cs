using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnMapacheInfo : MonoBehaviour
{

    string btnName;
    int Conteo;
    GameObject DatoMapache;
    GameObject DatoCazahuate;
    GameObject DatoColorin;
    GameObject DatoCactus;
    GameObject DatoMapache2;
    GameObject DatoMapache3;

    // Use this for initialization
    void Start()
    {


        DatoMapache = GameObject.Find("MapacheDato");
        DatoMapache.SetActive(false);

        DatoMapache2 = GameObject.Find("MapacheDato2");
        DatoMapache2.SetActive(false);

        DatoMapache3 = GameObject.Find("MapacheDato3");
        DatoMapache3.SetActive(false);

        DatoColorin = GameObject.Find("ColorinDato");
        DatoColorin.SetActive(false);

        DatoCazahuate = GameObject.Find("CazahuateDato");
        DatoCazahuate.SetActive(false);

        DatoCactus = GameObject.Find("CactusDato");
        DatoCactus.SetActive(false);




    }

    public void Next()
    {
        DatoMapache.SetActive(false);
        DatoMapache2.SetActive(true);

    }
    public void Next2()
    {
        DatoMapache2.SetActive(false);
        DatoMapache3.SetActive(true);
    }
    public void Close()
    {
        DatoMapache.SetActive(false);
        DatoMapache2.SetActive(false);
        DatoMapache3.SetActive(false);
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
                    case "Mapache":
                        DatoMapache.SetActive(true);
                        DatoCazahuate.SetActive(false);
                        DatoColorin.SetActive(false);
                        DatoCactus.SetActive(false);
                        DatoMapache2.SetActive(false);
                        DatoMapache3.SetActive(false);
                        break;

                    case "Cazahuate":
                        DatoCazahuate.SetActive(true);
                        DatoMapache.SetActive(false);
                        DatoColorin.SetActive(false);
                        DatoCactus.SetActive(false);
                        DatoMapache2.SetActive(false);
                        DatoMapache3.SetActive(false);
                        break;

                    case "Colorin":
                        DatoColorin.SetActive(true);
                        DatoMapache.SetActive(false);
                        DatoCazahuate.SetActive(false);
                        DatoCactus.SetActive(false);
                        DatoMapache2.SetActive(false);
                        DatoMapache3.SetActive(false);
                        break;

                    case "Cactus":
                        DatoCactus.SetActive(true);
                        DatoMapache.SetActive(false);
                        DatoCazahuate.SetActive(false);
                        DatoColorin.SetActive(false);
                        DatoMapache2.SetActive(false);
                        DatoMapache3.SetActive(false);
                        break;



                }
            }

        }
    }
}
