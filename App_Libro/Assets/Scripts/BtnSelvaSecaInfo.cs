using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnSelvaSecaInfo : MonoBehaviour
{

    string btnName;
    int Conteo;
    GameObject DatoArmadillo;
    GameObject DatoArmadillo2;
    GameObject DatoArmadillo3;
    GameObject DatoComadreja;
    GameObject DatoComadreja2;
    GameObject DatoJaguar;
    GameObject DatoJaguar2;
    GameObject DatoMapache;
    GameObject DatoMapache2;
    GameObject DatoMapache3;
    GameObject DatoOcelote;
    GameObject DatoOcelote2;
    GameObject DatoCazahuate;
    GameObject DatoColorin;
    GameObject DatoCactus;
   

    // Use this for initialization
    void Start()
    {

        DatoArmadillo = GameObject.Find("ArmadilloDato");
        DatoArmadillo.SetActive(false);

        DatoArmadillo2 = GameObject.Find("ArmadilloDato2");
        DatoArmadillo2.SetActive(false);

        DatoArmadillo3 = GameObject.Find("ArmadilloDato3");
        DatoArmadillo3.SetActive(false);

        DatoComadreja = GameObject.Find("ComadrejaDato");
        DatoComadreja.SetActive(false);

        DatoComadreja2 = GameObject.Find("ComadrejaDato2");
        DatoComadreja2.SetActive(false);

        DatoJaguar = GameObject.Find("JaguarDato");
        DatoJaguar.SetActive(false);

        DatoJaguar2 = GameObject.Find("JaguarDato2");
        DatoJaguar2.SetActive(false);

        DatoMapache = GameObject.Find("MapacheDato");
        DatoMapache.SetActive(false);

        DatoMapache2 = GameObject.Find("MapacheDato2");
        DatoMapache2.SetActive(false);

        DatoMapache3 = GameObject.Find("MapacheDato3");
        DatoMapache3.SetActive(false);

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

    public void ArmadilloNext()
    {
        DatoArmadillo.SetActive(false);
        DatoArmadillo2.SetActive(true);

    }
    public void ArmadilloNext2()
    {
        DatoArmadillo2.SetActive(false);
        DatoArmadillo3.SetActive(true);
    }
    public void ComadrejaNext()
    {
        DatoComadreja.SetActive(false);
        DatoComadreja2.SetActive(true);

    }
    public void JaguarNext()
    {
        DatoJaguar.SetActive(false);
        DatoJaguar2.SetActive(true);

    }
    public void MapacheNext()
    {
        DatoMapache.SetActive(false);
        DatoMapache2.SetActive(true);

    }
    public void MapcheNext2()
    {
        DatoMapache2.SetActive(false);
        DatoMapache3.SetActive(true);
    }
    public void OceloteNext()
    {
        DatoOcelote.SetActive(false);
        DatoOcelote2.SetActive(true);

    }
    public void Close()
    {
        DatoArmadillo.SetActive(false);
        DatoArmadillo2.SetActive(false);
        DatoArmadillo3.SetActive(false);
        DatoComadreja.SetActive(false);
        DatoComadreja2.SetActive(false);
        DatoJaguar.SetActive(false);
        DatoJaguar2.SetActive(false);
        DatoMapache.SetActive(false);
        DatoMapache2.SetActive(false);
        DatoMapache3.SetActive(false);
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
                    case "Armadillo":
                        DatoArmadillo.SetActive(true);
                        DatoCazahuate.SetActive(false);
                        DatoColorin.SetActive(false);
                        DatoCactus.SetActive(false);
                        DatoArmadillo2.SetActive(false);
                        DatoComadreja.SetActive(false);
                        DatoComadreja2.SetActive(false);
                        DatoJaguar.SetActive(false);
                        DatoJaguar2.SetActive(false);
                        DatoMapache.SetActive(false);
                        DatoMapache2.SetActive(false);
                        DatoMapache3.SetActive(false);
                        DatoColorin.SetActive(false);
                        DatoOcelote.SetActive(false);
                        DatoOcelote2.SetActive(false);
                        break;

                    case "Comadreja":
                        DatoComadreja.SetActive(true);
                        DatoCazahuate.SetActive(false);
                        DatoColorin.SetActive(false);
                        DatoCactus.SetActive(false);
                        DatoComadreja2.SetActive(false);
                        DatoArmadillo.SetActive(false);
                        DatoArmadillo2.SetActive(false);
                        DatoArmadillo3.SetActive(false);
                        DatoJaguar.SetActive(false);
                        DatoJaguar2.SetActive(false);
                        DatoMapache.SetActive(false);
                        DatoMapache2.SetActive(false);
                        DatoMapache3.SetActive(false);
                        DatoColorin.SetActive(false);
                        DatoOcelote.SetActive(false);
                        DatoOcelote2.SetActive(false);
                        break;

                    case "Jaguar":
                        DatoJaguar.SetActive(true);
                        DatoCazahuate.SetActive(false);
                        DatoColorin.SetActive(false);
                        DatoCactus.SetActive(false);
                        DatoJaguar2.SetActive(false);
                        DatoArmadillo.SetActive(false);
                        DatoArmadillo2.SetActive(false);
                        DatoArmadillo3.SetActive(false);
                        DatoComadreja.SetActive(false);
                        DatoComadreja2.SetActive(false);
                        DatoMapache.SetActive(false);
                        DatoMapache2.SetActive(false);
                        DatoMapache3.SetActive(false);
                        DatoColorin.SetActive(false);
                        DatoOcelote.SetActive(false);
                        DatoOcelote2.SetActive(false);

                        break;

                    case "Mapache":
                        DatoMapache.SetActive(true);
                        DatoCazahuate.SetActive(false);
                        DatoColorin.SetActive(false);
                        DatoCactus.SetActive(false);
                        DatoMapache2.SetActive(false);
                        DatoMapache3.SetActive(false);
                        DatoArmadillo.SetActive(false);
                        DatoArmadillo2.SetActive(false);
                        DatoArmadillo3.SetActive(false);
                        DatoComadreja.SetActive(false);
                        DatoComadreja2.SetActive(false);
                        DatoJaguar.SetActive(false);
                        DatoJaguar2.SetActive(false);
                        DatoOcelote.SetActive(false);
                        DatoOcelote2.SetActive(false);
                        break;

                    case "Ocelote":
                        DatoOcelote.SetActive(true);
                        DatoCazahuate.SetActive(false);
                        DatoColorin.SetActive(false);
                        DatoCactus.SetActive(false);
                        DatoOcelote2.SetActive(false);
                        DatoArmadillo.SetActive(false);
                        DatoArmadillo2.SetActive(false);
                        DatoArmadillo3.SetActive(false);
                        DatoComadreja.SetActive(false);
                        DatoComadreja2.SetActive(false);
                        DatoJaguar.SetActive(false);
                        DatoJaguar2.SetActive(false);
                        DatoMapache.SetActive(false);
                        DatoMapache2.SetActive(false);
                        DatoMapache3.SetActive(false);
                        break;

                    case "Colorin":
                        DatoColorin.SetActive(true);
                        DatoArmadillo.SetActive(false);
                        DatoCazahuate.SetActive(false);
                        DatoCactus.SetActive(false);
                        DatoArmadillo2.SetActive(false);
                        DatoComadreja.SetActive(false);
                        DatoComadreja2.SetActive(false);
                        DatoJaguar.SetActive(false);
                        DatoJaguar2.SetActive(false);
                        DatoMapache.SetActive(false);
                        DatoMapache2.SetActive(false);
                        DatoMapache3.SetActive(false);
                       
                        break;

                    case "Cazahuate":
                        DatoCazahuate.SetActive(true);
                        DatoArmadillo.SetActive(false);
                        DatoColorin.SetActive(false);
                        DatoCactus.SetActive(false);
                        DatoArmadillo2.SetActive(false);
                        DatoComadreja.SetActive(false);
                        DatoComadreja2.SetActive(false);
                        DatoJaguar.SetActive(false);
                        DatoJaguar2.SetActive(false);
                        DatoMapache.SetActive(false);
                        DatoMapache2.SetActive(false);
                        DatoMapache3.SetActive(false);
                        DatoColorin.SetActive(false);
                        break;

                  

                    case "Cactus":
                        DatoCactus.SetActive(true);
                        DatoArmadillo.SetActive(false);
                        DatoCazahuate.SetActive(false);
                        DatoColorin.SetActive(false);
                        DatoArmadillo2.SetActive(false);
                        DatoComadreja.SetActive(false);
                        DatoComadreja2.SetActive(false);
                        DatoJaguar.SetActive(false);
                        DatoJaguar2.SetActive(false);
                        DatoMapache.SetActive(false);
                        DatoMapache2.SetActive(false);
                        DatoMapache3.SetActive(false);
                        DatoColorin.SetActive(false);
                        break;



                }
            }

        }
    }
}
