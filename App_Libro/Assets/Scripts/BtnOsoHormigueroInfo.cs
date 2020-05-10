using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnOsoHormigueroInfo : MonoBehaviour
{

    string btnName;
    int Conteo;
    GameObject DatoOsoHormiguero;
    GameObject DatoOsoHormiguero2;
    GameObject DatoOsoHormiguero3;
    GameObject DatoCeriman;
    GameObject DatoCaoba;
    GameObject DatoCedroRojo;
    GameObject DatoHelecho;
    GameObject DatoLiana;
    

    // Use this for initialization
    void Start()
    {

        DatoOsoHormiguero = GameObject.Find("OsoHormigueroDato");
        DatoOsoHormiguero.SetActive(false);

        DatoOsoHormiguero2 = GameObject.Find("OsoHormigueroDato2");
        DatoOsoHormiguero2.SetActive(false);

        DatoOsoHormiguero3 = GameObject.Find("OsoHormigueroDato3");
        DatoOsoHormiguero3.SetActive(false);

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
        DatoOsoHormiguero.SetActive(false);
        DatoOsoHormiguero2.SetActive(true);

    }
    public void Next2()
    {
        DatoOsoHormiguero2.SetActive(false);
        DatoOsoHormiguero3.SetActive(true);
    }
    public void Close()
    {
        DatoOsoHormiguero.SetActive(false);
        DatoOsoHormiguero2.SetActive(false);
        DatoOsoHormiguero3.SetActive(false);
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
                    case "OsoHormiguero":
                        DatoOsoHormiguero.SetActive(true);
                        DatoCeriman.SetActive(false);
                        DatoCaoba.SetActive(false);
                        DatoCedroRojo.SetActive(false);
                        DatoHelecho.SetActive(false);
                        DatoLiana.SetActive(false);
                        DatoOsoHormiguero2.SetActive(false);
                        DatoOsoHormiguero3.SetActive(false);
                        break;

                    case "Ceriman":
                        DatoCeriman.SetActive(true);
                        DatoOsoHormiguero.SetActive(false);
                        DatoCaoba.SetActive(false);
                        DatoCedroRojo.SetActive(false);
                        DatoHelecho.SetActive(false);
                        DatoLiana.SetActive(false);
                        DatoOsoHormiguero2.SetActive(false);
                        DatoOsoHormiguero3.SetActive(false);
                        break;

                    case "Caoba":
                        DatoCaoba.SetActive(true);
                        DatoOsoHormiguero.SetActive(false);
                        DatoCedroRojo.SetActive(false);
                        DatoCeriman.SetActive(false);
                        DatoHelecho.SetActive(false);
                        DatoLiana.SetActive(false);
                        DatoOsoHormiguero2.SetActive(false);    
                        DatoOsoHormiguero3.SetActive(false);
                        break;

                    case "CedroRojo":
                        DatoCedroRojo.SetActive(true);
                        DatoOsoHormiguero.SetActive(false);
                        DatoCeriman.SetActive(false);
                        DatoCaoba.SetActive(false);
                        DatoHelecho.SetActive(false);
                        DatoLiana.SetActive(false);
                        DatoOsoHormiguero2.SetActive(false);
                        DatoOsoHormiguero3.SetActive(false);
                        break;

                    case "Helecho":
                        DatoHelecho.SetActive(true);
                        DatoLiana.SetActive(false);
                        DatoOsoHormiguero.SetActive(false);
                        DatoCeriman.SetActive(false);
                        DatoCaoba.SetActive(false);
                        DatoCedroRojo.SetActive(false);
                        DatoOsoHormiguero2.SetActive(false);
                        DatoOsoHormiguero3.SetActive(false);
                        break;

                    case "Liana":
                        DatoLiana.SetActive(true);
                        DatoOsoHormiguero.SetActive(false);
                        DatoCeriman.SetActive(false);
                        DatoCaoba.SetActive(false);
                        DatoHelecho.SetActive(false);
                        DatoCedroRojo.SetActive(false);
                        DatoOsoHormiguero2.SetActive(false);
                        DatoOsoHormiguero3.SetActive(false);
                        break;


                }
            }

        }
    }
}
