using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnTapirInfo    : MonoBehaviour
{

    string btnName;
    int Conteo;
    GameObject DatoTapir;
    GameObject DatoTapir2;
    GameObject DatoCeriman;
    GameObject DatoCaoba;
    GameObject DatoCedroRojo;
    GameObject DatoHelecho;
    GameObject DatoLiana;
    
    

    // Use this for initialization
    void Start()
    {

        DatoTapir = GameObject.Find("TapirDato");
        DatoTapir.SetActive(false);

        DatoTapir2 = GameObject.Find("TapirDato2");
        DatoTapir2.SetActive(false);

        DatoCaoba = GameObject.Find("CaobaDato");
        DatoCaoba.SetActive(false);

        DatoCeriman = GameObject.Find("CerimanDato");
        DatoCeriman.SetActive(false);

        DatoCedroRojo = GameObject.Find("CedroDato");
        DatoCedroRojo.SetActive(false);

        DatoHelecho = GameObject.Find("HelechoDato");
        DatoHelecho.SetActive(false);

        DatoLiana = GameObject.Find("LianaDato");
        DatoLiana.SetActive(false);

    }

    public void Next()
    {
        DatoTapir.SetActive(false);
        DatoTapir2.SetActive(true);

    }
    public void Next2()
    {
       
    }
    public void Close()
    {
        DatoTapir2.SetActive(false);
        DatoTapir2.SetActive(false);
        DatoCaoba.SetActive(false);
        DatoCeriman.SetActive(false);
        DatoCedroRojo.SetActive(false);
        DatoHelecho.SetActive(false);
        DatoLiana.SetActive(false);
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
                    case "Tapir":
                        DatoTapir.SetActive(true);
                        DatoCeriman.SetActive(false);
                        DatoCaoba.SetActive(false);
                        DatoCedroRojo.SetActive(false);
                        DatoHelecho.SetActive(false);
                        DatoLiana.SetActive(false);
                        DatoTapir2.SetActive(false);
                        break;

                    case "Ceriman":
                        DatoCeriman.SetActive(true);
                        DatoTapir.SetActive(false);
                        DatoCaoba.SetActive(false);
                        DatoCedroRojo.SetActive(false);
                        DatoHelecho.SetActive(false);
                        DatoLiana.SetActive(false);
                        DatoTapir2.SetActive(false);
                        break;

                    case "Caoba":
                        DatoCaoba.SetActive(true);
                        DatoTapir.SetActive(false);
                        DatoCedroRojo.SetActive(false);
                        DatoCeriman.SetActive(false);
                        DatoHelecho.SetActive(false);
                        DatoLiana.SetActive(false);
                        DatoTapir2.SetActive(false);
                        break;

                    case "CedroRojo":
                        DatoCedroRojo.SetActive(true);
                        DatoTapir.SetActive(false);
                        DatoCeriman.SetActive(false);
                        DatoCaoba.SetActive(false);
                        DatoHelecho.SetActive(false);
                        DatoLiana.SetActive(false);
                        DatoTapir2.SetActive(false);
                        break;

                    case "Helecho":
                        DatoHelecho.SetActive(true);
                        DatoLiana.SetActive(false);
                        DatoTapir.SetActive(false);
                        DatoCeriman.SetActive(false);
                        DatoCaoba.SetActive(false);
                        DatoCedroRojo.SetActive(false);
                        DatoTapir2.SetActive(false);
                        break;

                    case "Liana":
                        DatoLiana.SetActive(true);
                        DatoTapir.SetActive(false);
                        DatoCeriman.SetActive(false);
                        DatoCaoba.SetActive(false);
                        DatoHelecho.SetActive(false);
                        DatoCedroRojo.SetActive(false);
                        DatoTapir2.SetActive(false);
                        break;


                }
            }

        }
    }
}
