using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnTlacuacheInfo : MonoBehaviour
{

    string btnName;
    int Conteo;
    GameObject DatoTlacuache;
    GameObject DatoPino;
    GameObject DatoTlacuache2;
    GameObject DatoTlacuache3;

    // Use this for initialization
    void Start()
    {

        DatoTlacuache = GameObject.Find("TlacuacheDato");
        DatoTlacuache.SetActive(false);

        DatoTlacuache2 = GameObject.Find("TlacuacheDato2");
        DatoTlacuache2.SetActive(false);

        DatoTlacuache3 = GameObject.Find("TlacuacheDato3");
        DatoTlacuache3.SetActive(false);

        DatoPino = GameObject.Find("PinoDato");
        DatoPino.SetActive(false);

    }

    public void Next()
    {
        DatoTlacuache.SetActive(false);
        DatoTlacuache2.SetActive(true);
    }
    public void Next2()
    {
        DatoTlacuache2.SetActive(false);
        DatoTlacuache3.SetActive(true);
    }
    public void Close()
    {
        DatoTlacuache.SetActive(false);
        DatoTlacuache2.SetActive(false);
        DatoTlacuache3.SetActive(false);
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
                    case "Tlacuache":
                        DatoTlacuache.SetActive(true);
                        DatoPino.SetActive(false);
                        DatoTlacuache2.SetActive(false);
                        DatoTlacuache3.SetActive(false);
                        break;

                    case "Pino":
                        DatoPino.SetActive(true);
                        DatoTlacuache.SetActive(false);
                        DatoTlacuache2.SetActive(false);
                        DatoTlacuache3.SetActive(false);
                        break;



                }
            }

        }
    }
}
