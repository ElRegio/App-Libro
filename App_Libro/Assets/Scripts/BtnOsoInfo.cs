using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnOsoInfo : MonoBehaviour
{

    string btnName;
    int Conteo;
    GameObject DatoOso;
    GameObject DatoPino;
    GameObject DatoOso2;
    GameObject DatoOso3;
    GameObject DatoOso4;

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

        DatoPino = GameObject.Find("PinoDato");
        DatoPino.SetActive(false);

    }

    public void Next()
    {
        DatoOso.SetActive(false);
        DatoOso2.SetActive(true);
    }
    public void Next2()
    {
        DatoOso2.SetActive(false);
        DatoOso3.SetActive(true);
    }
    public void Next3()
    {
        DatoOso3.SetActive(false);
        DatoOso4.SetActive(true);
    }
    public void Close()
    {
        DatoOso.SetActive(false);
        DatoOso2.SetActive(false);
        DatoOso3.SetActive(false);
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
                        DatoPino.SetActive(false);
                        DatoOso2.SetActive(false);
                        DatoOso3.SetActive(false);
                        break;

                    case "Pino":
                        DatoPino.SetActive(true);
                        DatoOso.SetActive(false);
                        DatoOso2.SetActive(false);
                        DatoOso3.SetActive(false);
                        break;



                }
            }

        }
    }
}
