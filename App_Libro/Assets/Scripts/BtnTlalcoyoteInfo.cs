using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BtnTlalcoyoteInfo : MonoBehaviour
{

    string btnName;
    int Conteo;
    GameObject DatoTlalcoyote;
    GameObject DatoAlamo;
    GameObject DatoSicomoro;
    GameObject DatoMaguey;
    GameObject DatoTlalcoyote2;
    GameObject DatoTlalcoyote3;

    // Use this for initialization
    void Start()
    {

        DatoTlalcoyote = GameObject.Find("TlalcoyoteDato");
        DatoTlalcoyote.SetActive(false);

        DatoTlalcoyote2 = GameObject.Find("TlalcoyoteDato2");
        DatoTlalcoyote2.SetActive(false);

        DatoTlalcoyote3 = GameObject.Find("TlalcoyoteDato3");
        DatoTlalcoyote3.SetActive(false);

        DatoAlamo = GameObject.Find("AlamoDato");
        DatoAlamo.SetActive(false);

        DatoSicomoro = GameObject.Find("SicomoroDato");
        DatoSicomoro.SetActive(false);

        DatoMaguey = GameObject.Find("MagueyDato");
        DatoMaguey.SetActive(false);
    }

    public void Next()
    {
        DatoTlalcoyote.SetActive(false);
        DatoTlalcoyote2.SetActive(true);
    }
    public void Next2()
    {
        DatoTlalcoyote2.SetActive(false);
        DatoTlalcoyote3.SetActive(true);
    }
    public void Close()
    {
        DatoTlalcoyote.SetActive(false);
        DatoTlalcoyote2.SetActive(false);
        DatoTlalcoyote3.SetActive(false);
        DatoAlamo.SetActive(false);
        DatoSicomoro.SetActive(false);
        DatoMaguey.SetActive(false);

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
                    case "Tlalcoyote":
                        DatoTlalcoyote.SetActive(true);
                        DatoAlamo.SetActive(false);
                        DatoSicomoro.SetActive(false);
                        DatoMaguey.SetActive(false);
                        DatoTlalcoyote2.SetActive(false);
                        DatoTlalcoyote3.SetActive(false);
                        break;

                    case "Alamo":
                        DatoAlamo.SetActive(true);
                        DatoTlalcoyote.SetActive(false);
                        DatoSicomoro.SetActive(false);
                        DatoMaguey.SetActive(false);
                        DatoTlalcoyote2.SetActive(false);
                        DatoTlalcoyote3.SetActive(false);
                        break;

                    case "Sicomoro":
                        DatoSicomoro.SetActive(true);
                        DatoTlalcoyote.SetActive(false);
                        DatoMaguey.SetActive(false);
                        DatoAlamo.SetActive(false);
                        DatoTlalcoyote2.SetActive(false);
                        DatoTlalcoyote3.SetActive(false);
                        break;

                    case "Maguey":
                        DatoMaguey.SetActive(true);
                        DatoTlalcoyote.SetActive(false);
                        DatoAlamo.SetActive(false);
                        DatoSicomoro.SetActive(false);
                        DatoTlalcoyote2.SetActive(false);
                        DatoTlalcoyote3.SetActive(false);
                        break;

                }
            }

        }
    }
}
