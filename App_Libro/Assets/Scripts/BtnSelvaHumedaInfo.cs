using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnSelvaHumedaInfo : MonoBehaviour
{

    string btnName;
    int Conteo;
    GameObject DatoJabali;
    GameObject DatoJabali2;
    GameObject DatoNutria;
    GameObject DatoNutria2;
    GameObject DatoNutria3;
    GameObject DatoOsoHormiguero;
    GameObject DatoOsoHormiguero2;
    GameObject DatoOsoHormiguero3;
    GameObject DatoTapir;
    GameObject DatoTapir2;
    GameObject DatoVenadoTemazate;

    GameObject DatoCeriman;
    GameObject DatoCaoba;
    GameObject DatoCedroRojo;
    GameObject DatoHelecho;
    GameObject DatoLiana;


    // Use this for initialization
    void Start()
    {

        DatoJabali = GameObject.Find("JabaliDato");
        DatoJabali.SetActive(false);

        DatoJabali2 = GameObject.Find("JabaliDato2");
        DatoJabali2.SetActive(false);

        DatoNutria = GameObject.Find("NutriaDato");
        DatoNutria.SetActive(false);

        DatoNutria2 = GameObject.Find("NutriaDato2");
        DatoNutria2.SetActive(false);

        DatoNutria3 = GameObject.Find("NutriaDato3");
        DatoNutria3.SetActive(false);

        DatoOsoHormiguero = GameObject.Find("OsoHormigueroDato");
        DatoOsoHormiguero.SetActive(false);

        DatoOsoHormiguero2 = GameObject.Find("OsoHormigueroDato2");
        DatoOsoHormiguero2.SetActive(false);

        DatoOsoHormiguero3 = GameObject.Find("OsoHormigueroDato3");
        DatoOsoHormiguero3.SetActive(false);

        DatoTapir = GameObject.Find("TapirDato");
        DatoTapir.SetActive(false);

        DatoTapir2 = GameObject.Find("TapirDato2");
        DatoTapir2.SetActive(false);

        DatoVenadoTemazate = GameObject.Find("VenadoTemazateDato");
        DatoVenadoTemazate.SetActive(false);

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

    public void JabaliNext()
    {
        DatoJabali.SetActive(false);
        DatoJabali2.SetActive(true);

    }
    public void NutriaNext()
    {
        DatoNutria.SetActive(false);
        DatoNutria2.SetActive(true);

    }
    public void NutriaNext2()
    {
        DatoNutria2.SetActive(false);
        DatoNutria3.SetActive(true);
    }
    public void OsoHormigueroNext()
    {
        DatoOsoHormiguero.SetActive(false);
        DatoOsoHormiguero2.SetActive(true);

    }
    public void OsoHormigueroNext2()
    {
        DatoOsoHormiguero2.SetActive(false);
        DatoOsoHormiguero3.SetActive(true);
    }
    public void TapirNext()
    {
        DatoTapir.SetActive(false);
        DatoTapir2.SetActive(true);
    }
    public void CloseSelvaHumeda()
    {
        DatoJabali.SetActive(false);
        DatoJabali2.SetActive(false);
        DatoNutria.SetActive(false);
        DatoNutria2.SetActive(false);
        DatoNutria3.SetActive(false);
        DatoOsoHormiguero.SetActive(false);
        DatoOsoHormiguero2.SetActive(false);
        DatoOsoHormiguero3.SetActive(false);
        DatoTapir.SetActive(false);
        DatoTapir2.SetActive(false);
        DatoVenadoTemazate.SetActive(false);
        DatoCaoba.SetActive(false);
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
                    case "Jabali":
                        DatoJabali.SetActive(true);
                        DatoCeriman.SetActive(false);
                        DatoCaoba.SetActive(false);
                        DatoCedroRojo.SetActive(false);
                        DatoHelecho.SetActive(false);
                        DatoLiana.SetActive(false);
                        DatoJabali2.SetActive(false);
                        DatoNutria.SetActive(false);
                        DatoNutria2.SetActive(false);
                        DatoNutria3.SetActive(false);
                        DatoOsoHormiguero.SetActive(false);
                        DatoOsoHormiguero2.SetActive(false);
                        DatoOsoHormiguero3.SetActive(false);
                        DatoTapir.SetActive(false);
                        DatoTapir2.SetActive(false);
                        DatoVenadoTemazate.SetActive(false);
                        break;

                    case "Nutria":
                        DatoNutria.SetActive(true);
                        DatoCeriman.SetActive(false);
                        DatoCaoba.SetActive(false);
                        DatoCedroRojo.SetActive(false);
                        DatoHelecho.SetActive(false);
                        DatoLiana.SetActive(false);
                        DatoNutria2.SetActive(false);
                        DatoJabali.SetActive(false);
                        DatoJabali2.SetActive(false);
                        DatoOsoHormiguero.SetActive(false);
                        DatoOsoHormiguero2.SetActive(false);
                        DatoOsoHormiguero3.SetActive(false);
                        DatoTapir.SetActive(false);
                        DatoTapir2.SetActive(false);
                        DatoVenadoTemazate.SetActive(false);
                        break;

                   case "OsoHormiguero":
                        DatoOsoHormiguero.SetActive(true);
                        DatoCeriman.SetActive(false);
                        DatoCaoba.SetActive(false);
                        DatoCedroRojo.SetActive(false);
                        DatoHelecho.SetActive(false);
                        DatoLiana.SetActive(false);
                        DatoOsoHormiguero2.SetActive(false);
                        DatoOsoHormiguero3.SetActive(false);
                        DatoJabali.SetActive(false);
                        DatoJabali2.SetActive(false);
                        DatoNutria.SetActive(false);
                        DatoNutria2.SetActive(false);
                        DatoNutria3.SetActive(false);
                        DatoTapir.SetActive(false);
                        DatoTapir2.SetActive(false);
                        DatoVenadoTemazate.SetActive(false);
                        break;

                    case "Tapir":
                        DatoTapir.SetActive(true);
                        DatoCeriman.SetActive(false);
                        DatoCaoba.SetActive(false);
                        DatoCedroRojo.SetActive(false);
                        DatoHelecho.SetActive(false);
                        DatoLiana.SetActive(false);
                        DatoTapir2.SetActive(false);
                        DatoJabali.SetActive(false);
                        DatoJabali2.SetActive(false);
                        DatoNutria.SetActive(false);
                        DatoNutria2.SetActive(false);
                        DatoNutria3.SetActive(false);
                        DatoOsoHormiguero.SetActive(false);
                        DatoOsoHormiguero2.SetActive(false);
                        DatoOsoHormiguero3.SetActive(false);
                        DatoVenadoTemazate.SetActive(false);
                        break;

                    case "VenadoTemazate":
                        DatoVenadoTemazate.SetActive(true);
                        DatoCeriman.SetActive(false);
                        DatoCaoba.SetActive(false);
                        DatoCedroRojo.SetActive(false);
                        DatoHelecho.SetActive(false);
                        DatoLiana.SetActive(false);
                        DatoJabali.SetActive(false);
                        DatoJabali2.SetActive(false);
                        DatoNutria.SetActive(false);
                        DatoNutria2.SetActive(false);
                        DatoNutria3.SetActive(false);
                        DatoOsoHormiguero.SetActive(false);
                        DatoOsoHormiguero2.SetActive(false);
                        DatoOsoHormiguero3.SetActive(false);
                        DatoTapir.SetActive(false);
                        DatoTapir2.SetActive(false);
                        break;

                    case "Ceriman":
                        DatoCeriman.SetActive(true);
                        DatoJabali.SetActive(false);
                        DatoCaoba.SetActive(false);
                        DatoCedroRojo.SetActive(false);
                        DatoHelecho.SetActive(false);
                        DatoLiana.SetActive(false);
                        DatoJabali2.SetActive(false);
                        DatoNutria.SetActive(false);
                        DatoNutria2.SetActive(false);
                        DatoNutria3.SetActive(false);
                        DatoOsoHormiguero.SetActive(false);
                        DatoOsoHormiguero2.SetActive(false);
                        DatoOsoHormiguero3.SetActive(false);
                        DatoTapir.SetActive(false);
                        DatoTapir2.SetActive(false);
                        DatoVenadoTemazate.SetActive(false);
                        break;

                    

                    case "Caoba":
                        DatoCaoba.SetActive(true);
                        DatoJabali.SetActive(false);
                        DatoCedroRojo.SetActive(false);
                        DatoCeriman.SetActive(false);
                        DatoHelecho.SetActive(false);
                        DatoLiana.SetActive(false);
                        DatoJabali2.SetActive(false);
                        DatoNutria.SetActive(false);
                        DatoNutria2.SetActive(false);
                        DatoNutria3.SetActive(false);
                        DatoOsoHormiguero.SetActive(false);
                        DatoOsoHormiguero2.SetActive(false);
                        DatoOsoHormiguero3.SetActive(false);
                        DatoTapir.SetActive(false);
                        DatoTapir2.SetActive(false);
                        DatoVenadoTemazate.SetActive(false);
                        break;

                    case "CedroRojo":
                        DatoCedroRojo.SetActive(true);
                        DatoJabali.SetActive(false);
                        DatoCeriman.SetActive(false);
                        DatoCaoba.SetActive(false);
                        DatoHelecho.SetActive(false);
                        DatoLiana.SetActive(false);
                        DatoJabali2.SetActive(false);
                        DatoNutria.SetActive(false);
                        DatoNutria2.SetActive(false);
                        DatoNutria3.SetActive(false);
                        DatoOsoHormiguero.SetActive(false);
                        DatoOsoHormiguero2.SetActive(false);
                        DatoOsoHormiguero3.SetActive(false);
                        DatoTapir.SetActive(false);
                        DatoTapir2.SetActive(false);
                        DatoVenadoTemazate.SetActive(false);
                        break;

                    case "Helecho":
                        DatoHelecho.SetActive(true);
                        DatoLiana.SetActive(false);
                        DatoJabali.SetActive(false);
                        DatoCeriman.SetActive(false);
                        DatoCaoba.SetActive(false);
                        DatoCedroRojo.SetActive(false);
                        DatoJabali2.SetActive(false);
                        DatoNutria.SetActive(false);
                        DatoNutria2.SetActive(false);
                        DatoNutria3.SetActive(false);
                        DatoOsoHormiguero.SetActive(false);
                        DatoOsoHormiguero2.SetActive(false);
                        DatoOsoHormiguero3.SetActive(false);
                        DatoTapir.SetActive(false);
                        DatoTapir2.SetActive(false);
                        DatoVenadoTemazate.SetActive(false);
                        break;

                    case "Liana":
                        DatoLiana.SetActive(true);
                        DatoJabali.SetActive(false);
                        DatoCeriman.SetActive(false);
                        DatoCaoba.SetActive(false);
                        DatoHelecho.SetActive(false);
                        DatoCedroRojo.SetActive(false);
                        DatoJabali2.SetActive(false);
                        DatoNutria.SetActive(false);
                        DatoNutria2.SetActive(false);
                        DatoNutria3.SetActive(false);
                        DatoOsoHormiguero.SetActive(false);
                        DatoOsoHormiguero2.SetActive(false);
                        DatoOsoHormiguero3.SetActive(false);
                        DatoTapir.SetActive(false);
                        DatoTapir2.SetActive(false);
                        DatoVenadoTemazate.SetActive(false);
                        break;


                }
            }

        }
    }
}
