using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnZorritaInfo : MonoBehaviour
{

    string btnName;
    int Conteo;
    GameObject DatoZorrita;
    GameObject DatoCactus;
    GameObject DatoCoryphantha;
    GameObject DatoIzote;
    GameObject DatoZorrita2;


    // Use this for initialization
    void Start()
    {

        DatoZorrita = GameObject.Find("ZorritaDato");
        DatoZorrita.SetActive(false);

        DatoZorrita2 = GameObject.Find("ZorritaDato2");
        DatoZorrita2.SetActive(false);

        DatoCactus = GameObject.Find("CactusDato");
        DatoCactus.SetActive(false);

        DatoCoryphantha = GameObject.Find("CoryphanthaDato");
        DatoCoryphantha.SetActive(false);

        DatoIzote = GameObject.Find("IzoteDato");
        DatoIzote.SetActive(false);
    }

    public void Next()
    {
        DatoZorrita.SetActive(false);
        DatoZorrita2.SetActive(true);
    }

    public void Close()
    {
        DatoZorrita.SetActive(false);
        DatoZorrita2.SetActive(false);
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
                    case "Zorrita":
                        DatoZorrita.SetActive(true);
                        DatoCactus.SetActive(false);
                        DatoCoryphantha.SetActive(false);
                        DatoIzote.SetActive(false);
                        DatoZorrita2.SetActive(false);
                        break;

                    case "Cactus":
                        DatoCactus.SetActive(true);
                        DatoZorrita.SetActive(false);
                        DatoCoryphantha.SetActive(false);
                        DatoIzote.SetActive(false);
                        DatoZorrita2.SetActive(false);
                        break;

                    case "Coryphantha":
                        DatoCoryphantha.SetActive(true);
                        DatoZorrita.SetActive(false);
                        DatoIzote.SetActive(false);
                        DatoCactus.SetActive(false);
                        DatoZorrita2.SetActive(false);
                        break;

                    case "Izote":
                        DatoIzote.SetActive(true);
                        DatoZorrita.SetActive(false);
                        DatoCactus.SetActive(false);
                        DatoCoryphantha.SetActive(false);
                        DatoZorrita2.SetActive(false);
                        break;

                }
            }

        }
    }
}
