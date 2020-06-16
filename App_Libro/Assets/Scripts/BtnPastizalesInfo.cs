using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnPastizalesInfo : MonoBehaviour
{

    string btnName;
    int Conteo;
    GameObject DatoBerrendo;
    GameObject DatoAlamo;
    GameObject DatoSicomoro;
    GameObject DatoMaguey;
    GameObject DatoBisonte;
    GameObject DatoBisonte2;
    GameObject DatoBisonte3;
    GameObject DatoConejo;
    GameObject DatoConejo2;
    GameObject DatoPerrito;
    GameObject DatoTlalcoyote;
    GameObject DatoTlalcoyote2;
    GameObject DatoTlalcoyote3;


    // Use this for initialization
    void Start()
    {

        DatoBerrendo = GameObject.Find("BerrendoDato");
        DatoBerrendo.SetActive(false);

        DatoBisonte = GameObject.Find("BisonteDato");
        DatoBisonte.SetActive(false);

        DatoBisonte2 = GameObject.Find("BisonteDato2");
        DatoBisonte2.SetActive(false);

        DatoBisonte3 = GameObject.Find("BisonteDato3");
        DatoBisonte3.SetActive(false);

        DatoConejo = GameObject.Find("ConejoDato");
        DatoConejo.SetActive(false);

        DatoConejo2 = GameObject.Find("ConejoDato2");
        DatoConejo2.SetActive(false);

        DatoPerrito = GameObject.Find("PerritoDato");
        DatoPerrito.SetActive(false);
        
        DatoAlamo = GameObject.Find("AlamoDato");
        DatoAlamo.SetActive(false);

        DatoSicomoro = GameObject.Find("SicomoroDato");
        DatoSicomoro.SetActive(false);

        DatoMaguey = GameObject.Find("MagueyDato");
        DatoMaguey.SetActive(false);

        DatoTlalcoyote = GameObject.Find("TlalcoyoteDato");
        DatoTlalcoyote.SetActive(false);

        DatoTlalcoyote2 = GameObject.Find("TlalcoyoteDato2");
        DatoTlalcoyote2.SetActive(false);

        DatoTlalcoyote3 = GameObject.Find("TlalcoyoteDato3");
        DatoTlalcoyote3.SetActive(false);
    }

    public void NextBisonte()
    {
        DatoBisonte.SetActive(false);
        DatoBisonte2.SetActive(true);
    }
    public void Next2Bisonte()
    {
        DatoBisonte2.SetActive(false);
        DatoBisonte3.SetActive(true);
    }

    public void NextConejo()
    {
        DatoConejo.SetActive(false);
        DatoConejo2.SetActive(true);
    }

    public void NextTlalcoyote()
    {
        DatoTlalcoyote.SetActive(false);
        DatoTlalcoyote2.SetActive(true);
    }
    public void NextTlalcoyote2()
    {
        DatoTlalcoyote2.SetActive(false);
        DatoTlalcoyote3.SetActive(true);
    }

    public void ClosePastizal()
    {
        DatoBerrendo.SetActive(false);
        DatoBisonte.SetActive(false);
        DatoBisonte2.SetActive(false);
        DatoBisonte3.SetActive(false);
        DatoConejo.SetActive(false);
        DatoConejo2.SetActive(false);
        DatoAlamo.SetActive(false);
        DatoSicomoro.SetActive(false);
        DatoMaguey.SetActive(false);
        DatoPerrito.SetActive(false);
        DatoTlalcoyote.SetActive(false);
        DatoTlalcoyote2.SetActive(false);
        DatoTlalcoyote3.SetActive(false);
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
                    case "Berrendo":
                        DatoBerrendo.SetActive(true);
                        DatoBisonte.SetActive(false);
                        DatoBisonte2.SetActive(false);
                        DatoBisonte3.SetActive(false);
                        DatoAlamo.SetActive(false);
                        DatoSicomoro.SetActive(false);
                        DatoMaguey.SetActive(false);
                        DatoConejo.SetActive(false);
                        DatoPerrito.SetActive(false);
                        DatoTlalcoyote.SetActive(false);

                        break;

                    case "Bisonte":
                        DatoBisonte.SetActive(true);
                        DatoBerrendo.SetActive(false);
                        DatoBisonte2.SetActive(false);
                        DatoBisonte3.SetActive(false);
                        DatoAlamo.SetActive(false);
                        DatoSicomoro.SetActive(false);
                        DatoMaguey.SetActive(false);
                        DatoConejo.SetActive(false);
                        DatoPerrito.SetActive(false);
                        DatoTlalcoyote.SetActive(false);

                        break;


                    case "Conejo":
                        DatoConejo.SetActive(true);
                        DatoBisonte.SetActive(false);
                        DatoBerrendo.SetActive(false);
                        DatoBisonte2.SetActive(false);
                        DatoBisonte3.SetActive(false);
                        DatoAlamo.SetActive(false);
                        DatoSicomoro.SetActive(false);
                        DatoMaguey.SetActive(false);
                        DatoPerrito.SetActive(false);
                        DatoTlalcoyote.SetActive(false);


                        break;

                    case "Perrito":
                        DatoConejo.SetActive(false);
                        DatoBisonte.SetActive(false);
                        DatoBerrendo.SetActive(false);
                        DatoBisonte2.SetActive(false);
                        DatoBisonte3.SetActive(false);
                        DatoAlamo.SetActive(false);
                        DatoSicomoro.SetActive(false);
                        DatoMaguey.SetActive(false);
                        DatoPerrito.SetActive(true);
                        DatoTlalcoyote.SetActive(false);


                        break;

                    case "Tlalcoyote":
                        DatoConejo.SetActive(false);
                        DatoBisonte.SetActive(false);
                        DatoBerrendo.SetActive(false);
                        DatoBisonte2.SetActive(false);
                        DatoBisonte3.SetActive(false);
                        DatoAlamo.SetActive(false);
                        DatoSicomoro.SetActive(false);
                        DatoMaguey.SetActive(false);
                        DatoPerrito.SetActive(false);
                        DatoTlalcoyote.SetActive(true);


                        break;

                    case "Alamo":
                        DatoAlamo.SetActive(true);
                        DatoBerrendo.SetActive(false);
                        DatoSicomoro.SetActive(false);
                        DatoMaguey.SetActive(false);
                        DatoBisonte.SetActive(false);
                        DatoBisonte2.SetActive(false);
                        DatoBisonte3.SetActive(false);
                        DatoConejo.SetActive(false);
                        DatoPerrito.SetActive(false);
                        DatoTlalcoyote.SetActive(false);

                        break;

                    case "Sicomoro":
                        DatoSicomoro.SetActive(true);
                        DatoBerrendo.SetActive(false);
                        DatoMaguey.SetActive(false);
                        DatoAlamo.SetActive(false);
                        DatoBisonte.SetActive(false);
                        DatoBisonte2.SetActive(false);
                        DatoBisonte3.SetActive(false);
                        DatoConejo.SetActive(false);
                        DatoPerrito.SetActive(false);
                        DatoTlalcoyote.SetActive(false);

                        break;

                    case "Maguey":
                        DatoMaguey.SetActive(true);
                        DatoBerrendo.SetActive(false);
                        DatoAlamo.SetActive(false);
                        DatoSicomoro.SetActive(false);
                        DatoBisonte.SetActive(false);
                        DatoBisonte2.SetActive(false);
                        DatoBisonte3.SetActive(false);
                        DatoConejo.SetActive(false);
                        DatoPerrito.SetActive(false);
                        DatoTlalcoyote.SetActive(false);

                        break;

                }
            }

        }
    }
}
