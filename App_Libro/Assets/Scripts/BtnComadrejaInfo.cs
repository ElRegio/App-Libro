using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnComadrejaInfo : MonoBehaviour
{

    string btnName;
    int Conteo;
    GameObject DatoComadreja;
    GameObject DatoCazahuate;
    GameObject DatoColorin;
    GameObject DatoCactus;
    GameObject DatoComadreja2;
   
    // Use this for initialization
    void Start()
    {

        DatoComadreja = GameObject.Find("ComadrejaDato");
        DatoComadreja.SetActive(false);

        DatoComadreja2 = GameObject.Find("ComadrejaDato2");
        DatoComadreja2.SetActive(false);

        DatoColorin = GameObject.Find("ColorinDato");
        DatoColorin.SetActive(false);

        DatoCazahuate = GameObject.Find("CazahuateDato");
        DatoCazahuate.SetActive(false);

        DatoCactus = GameObject.Find("CactusDato");
        DatoCactus.SetActive(false);



    }

    public void Next()
    {
        DatoComadreja.SetActive(false);
        DatoComadreja2.SetActive(true);

    }
    public void Close()
    {
        DatoComadreja.SetActive(false);
        DatoComadreja2.SetActive(false);
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
                    case "Comadreja":
                        DatoComadreja.SetActive(true);
                        DatoCazahuate.SetActive(false);
                        DatoColorin.SetActive(false);
                        DatoCactus.SetActive(false);
                        DatoComadreja2.SetActive(false);
                        break;

                    case "Cazahuate":
                        DatoCazahuate.SetActive(true);
                        DatoComadreja.SetActive(false);
                        DatoColorin.SetActive(false);
                        DatoCactus.SetActive(false);
                        DatoComadreja2.SetActive(false);
                        break;

                    case "Colorin":
                        DatoColorin.SetActive(true);
                        DatoComadreja.SetActive(false);
                        DatoCazahuate.SetActive(false);
                        DatoCactus.SetActive(false);
                        DatoComadreja2.SetActive(false);
                        break;

                    case "Cactus":
                        DatoCactus.SetActive(true);
                        DatoComadreja.SetActive(false);
                        DatoCazahuate.SetActive(false);
                        DatoColorin.SetActive(false);
                        DatoComadreja2.SetActive(false);
                        break;
                                               
                }
            }

        }
    }
}
