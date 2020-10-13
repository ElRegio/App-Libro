using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnBosqueInfo : MonoBehaviour
{

    string btnName;
    int Conteo;
    GameObject DatoOso;
    GameObject DatoOso2;
    GameObject DatoOso3;
    GameObject DatoOso4;
    GameObject DatoPuma;
    GameObject DatoPuma2;
    GameObject DatoPuma3;
    GameObject DatoCoati;
    GameObject DatoCoati2;
    GameObject DatoCoati3;
    GameObject DatoTlacuache;
    GameObject DatoTlacuache2;
    GameObject DatoTlacuache3;
    GameObject DatoVenadoCB;
    GameObject DatoVenadoCB2;
    GameObject DatoVenadoCB3;
    GameObject DatoPino;
    // Use this for initialization
    void Start()
    {

        DatoOso = GameObject.Find("OsoDato");
        DatoOso.SetActive(false);

        DatoOso2 = GameObject.Find("OsoDato2");
        DatoOso2.SetActive(false);

        DatoOso3 = GameObject.Find("OsoDato3");
        DatoOso3.SetActive(false);

        DatoOso4 = GameObject.Find("OsoDato4");
        DatoOso4.SetActive(false);

        DatoPuma = GameObject.Find("PumaDato");
        DatoPuma.SetActive(false);

        DatoPuma2 = GameObject.Find("PumaDato2");
        DatoPuma2.SetActive(false);

        DatoPuma3 = GameObject.Find("PumaDato3");
        DatoPuma3.SetActive(false);

        DatoCoati = GameObject.Find("CoatiDato");
        DatoCoati.SetActive(false);

        DatoCoati2 = GameObject.Find("CoatiDato2");
        DatoCoati2.SetActive(false);

        DatoCoati3 = GameObject.Find("CoatiDato3");
        DatoCoati3.SetActive(false);

        DatoTlacuache = GameObject.Find("TlacuacheDato");
        DatoTlacuache.SetActive(false);

        DatoTlacuache2 = GameObject.Find("TlacuacheDato2");
        DatoTlacuache2.SetActive(false);

        DatoTlacuache3 = GameObject.Find("TlacuacheDato3");
        DatoTlacuache3.SetActive(false);

        DatoVenadoCB = GameObject.Find("VenadoCBDato");
        DatoVenadoCB.SetActive(false);

        DatoVenadoCB2 = GameObject.Find("VenadoCBDato2");
        DatoVenadoCB2.SetActive(false);

        DatoVenadoCB3 = GameObject.Find("VenadoCBDato3");
        DatoVenadoCB3.SetActive(false);

        DatoPino = GameObject.Find("PinoDato");
        DatoPino.SetActive(false);

    }

    public void OsoNext()
    {
        DatoOso.SetActive(false);
        DatoOso2.SetActive(true);
    }
    public void OsoNext2()
    {
        DatoOso2.SetActive(false);
        DatoOso3.SetActive(true);
    }
    public void OsoNext3()
    {
        DatoOso3.SetActive(false);
        DatoOso4.SetActive(true);
    }
    public void PumaNext()
    {
        DatoPuma.SetActive(false);
        DatoPuma2.SetActive(true);
    }
    public void PumaNext2()
    {
        DatoPuma2.SetActive(false);
        DatoPuma3.SetActive(true);
    }
    public void CoatiNext()
    {
        DatoCoati.SetActive(false);
        DatoCoati2.SetActive(true);
    }
    public void CoatiNext2()
    {
        DatoCoati2.SetActive(false);
        DatoCoati3.SetActive(true);
    }

    public void TlacuacheNext()
    {
        DatoTlacuache.SetActive(false);
        DatoTlacuache2.SetActive(true);
    }
    public void TlacuacheNext2()
    {
        DatoTlacuache2.SetActive(false);
        DatoTlacuache3.SetActive(true);
    }
    public void VenadoCBNext()
    {
        DatoVenadoCB.SetActive(false);
        DatoVenadoCB2.SetActive(true);
    }
    public void VenadoCBNext2()
    {
        DatoVenadoCB2.SetActive(false);
        DatoVenadoCB3.SetActive(true);
    }

    public void CloseBosque()
    {
        DatoOso.SetActive(false);
        DatoOso2.SetActive(false);
        DatoOso3.SetActive(false);
        DatoPuma.SetActive(false);
        DatoPuma2.SetActive(false);
        DatoPuma3.SetActive(false);
        DatoCoati.SetActive(false);
        DatoCoati2.SetActive(false);
        DatoCoati3.SetActive(false);
        DatoTlacuache.SetActive(false);
        DatoTlacuache2.SetActive(false);
        DatoTlacuache3.SetActive(false);
        DatoVenadoCB.SetActive(false);
        DatoVenadoCB2.SetActive(false);
        DatoVenadoCB3.SetActive(false);
        DatoPino.SetActive(false);


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
                    case "OsoNegro":
                        DatoOso.SetActive(true);
                        DatoOso2.SetActive(false);
                        DatoOso3.SetActive(false);
                        DatoPino.SetActive(false);
                        DatoPuma.SetActive(false);
                        DatoPuma.SetActive(false);
                        DatoPuma2.SetActive(false);
                        DatoPuma3.SetActive(false);
                        DatoCoati.SetActive(false);
                        DatoCoati2.SetActive(false);
                        DatoCoati3.SetActive(false);
                        DatoTlacuache.SetActive(false);
                        DatoTlacuache2.SetActive(false);
                        DatoTlacuache3.SetActive(false);
                        DatoVenadoCB.SetActive(false);
                        DatoVenadoCB2.SetActive(false);
                        DatoVenadoCB3.SetActive(false);
                        break;

                    case "Puma":
                        DatoPuma.SetActive(true);
                        DatoPuma2.SetActive(false);
                        DatoPuma3.SetActive(false);
                        DatoPino.SetActive(false);
                        DatoOso.SetActive(false);
                        DatoOso2.SetActive(false);
                        DatoOso3.SetActive(false);
                        DatoPino.SetActive(false);
                        DatoCoati.SetActive(false);
                        DatoCoati2.SetActive(false);
                        DatoCoati3.SetActive(false);
                        DatoTlacuache.SetActive(false);
                        DatoTlacuache2.SetActive(false);
                        DatoTlacuache3.SetActive(false);
                        DatoVenadoCB.SetActive(false);
                        DatoVenadoCB2.SetActive(false);
                        DatoVenadoCB3.SetActive(false);
                        break;

                    case "Coati":
                        DatoCoati.SetActive(true);
                        DatoCoati2.SetActive(false);
                        DatoCoati3.SetActive(false);
                        DatoPuma.SetActive(false);
                        DatoPuma2.SetActive(false);
                        DatoPuma3.SetActive(false);
                        DatoOso.SetActive(false);
                        DatoOso2.SetActive(false);
                        DatoOso3.SetActive(false);
                        DatoPino.SetActive(false);
                        DatoTlacuache.SetActive(false);
                        DatoTlacuache2.SetActive(false);
                        DatoTlacuache3.SetActive(false);
                        DatoVenadoCB.SetActive(false);
                        DatoVenadoCB2.SetActive(false);
                        DatoVenadoCB3.SetActive(false);
                        break;

                    case "Tlacuache":
                        DatoTlacuache.SetActive(true);
                        DatoTlacuache2.SetActive(false);
                        DatoTlacuache3.SetActive(false);
                        DatoOso.SetActive(false);
                        DatoOso2.SetActive(false);
                        DatoOso3.SetActive(false);
                        DatoPino.SetActive(false);
                        DatoPuma.SetActive(false);
                        DatoPuma.SetActive(false);
                        DatoPuma2.SetActive(false);
                        DatoPuma3.SetActive(false);
                        DatoCoati.SetActive(false);
                        DatoCoati2.SetActive(false);
                        DatoCoati3.SetActive(false);
                        DatoVenadoCB.SetActive(false);
                        DatoVenadoCB2.SetActive(false);
                        DatoVenadoCB3.SetActive(false);
                        break;

                    case "VenadoCB":
                        DatoVenadoCB.SetActive(true);
                        DatoVenadoCB2.SetActive(false);
                        DatoVenadoCB3.SetActive(false);
                        DatoOso.SetActive(false);
                        DatoOso2.SetActive(false);
                        DatoOso3.SetActive(false);
                        DatoPino.SetActive(false);
                        DatoPuma.SetActive(false);
                        DatoPuma.SetActive(false);
                        DatoPuma2.SetActive(false);
                        DatoPuma3.SetActive(false);
                        DatoCoati.SetActive(false);
                        DatoCoati2.SetActive(false);
                        DatoCoati3.SetActive(false);
                        DatoTlacuache.SetActive(false);
                        DatoTlacuache2.SetActive(false);
                        DatoTlacuache3.SetActive(false);
                        break;

                    case "Pino":
                        DatoPino.SetActive(true);
                        DatoOso.SetActive(false);
                        DatoOso2.SetActive(false);
                        DatoOso3.SetActive(false);
                        DatoPuma.SetActive(false);
                        DatoPuma2.SetActive(false);
                        DatoPuma3.SetActive(false);
                        DatoCoati.SetActive(false);
                        DatoCoati2.SetActive(false);
                        DatoCoati3.SetActive(false);
                        DatoTlacuache.SetActive(false);
                        DatoTlacuache2.SetActive(false);
                        DatoTlacuache3.SetActive(false);
                        DatoVenadoCB.SetActive(false);
                        DatoVenadoCB2.SetActive(false);
                        DatoVenadoCB3.SetActive(false);
                        break;



                }
            }

        }
    }
}
