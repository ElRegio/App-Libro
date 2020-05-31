using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnVenadoCBInfo : MonoBehaviour
{

    string btnName;
    int Conteo;
    GameObject DatoVenadoCB;
    GameObject DatoPino;
    GameObject DatoVenadoCB2;
    GameObject DatoVenadoCB3;

    // Use this for initialization
    void Start()
    {

        DatoVenadoCB = GameObject.Find("VenadoCBDato");
        DatoVenadoCB.SetActive(false);

        DatoVenadoCB2 = GameObject.Find("VenadoCBDato2");
        DatoVenadoCB2.SetActive(false);

        DatoVenadoCB3 = GameObject.Find("VenadoCBDato3");
        DatoVenadoCB3.SetActive(false);

        DatoPino = GameObject.Find("PinoDato");
        DatoPino.SetActive(false);

    }

    public void Next()
    {
        DatoVenadoCB.SetActive(false);
        DatoVenadoCB2.SetActive(true);
    }
    public void Next2()
    {
        DatoVenadoCB2.SetActive(false);
        DatoVenadoCB3.SetActive(true);
    }
    public void Close()
    {
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
                    case "VenadoCB":
                        DatoVenadoCB.SetActive(true);
                        DatoPino.SetActive(false);
                        DatoVenadoCB2.SetActive(false);
                        DatoVenadoCB3.SetActive(false);
                        break;

                    case "Pino":
                        DatoPino.SetActive(true);
                        DatoVenadoCB.SetActive(false);
                        DatoVenadoCB2.SetActive(false);
                        DatoVenadoCB3.SetActive(false);
                        break;



                }
            }

        }
    }
}
