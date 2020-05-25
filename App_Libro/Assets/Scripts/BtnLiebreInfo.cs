using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnLiebreInfo : MonoBehaviour
{

    string btnName;
    int Conteo;
    GameObject DatoLiebre;
    GameObject DatoCactus;
    GameObject DatoCoryphantha;
    GameObject DatoIzote;
    GameObject DatoLiebre2;


    // Use this for initialization
    void Start()
    {

        DatoLiebre = GameObject.Find("LiebreDato");
        DatoLiebre.SetActive(false);

        DatoLiebre2 = GameObject.Find("LiebreDato2");
        DatoLiebre2.SetActive(false);

        DatoCactus = GameObject.Find("CactusDato");
        DatoCactus.SetActive(false);

        DatoCoryphantha = GameObject.Find("CoryphanthaDato");
        DatoCoryphantha.SetActive(false);

        DatoIzote = GameObject.Find("IzoteDato");
        DatoIzote.SetActive(false);
    }

    public void Next()
    {
        DatoLiebre.SetActive(false);
        DatoLiebre2.SetActive(true);
    }

    public void Close()
    {
        DatoLiebre.SetActive(false);
        DatoLiebre2.SetActive(false);
        DatoCactus.SetActive(false);
        DatoCoryphantha.SetActive(false);
        DatoIzote.SetActive(false);

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
                    case "Liebre":
                        DatoLiebre.SetActive(true);
                        DatoCactus.SetActive(false);
                        DatoCoryphantha.SetActive(false);
                        DatoIzote.SetActive(false);
                        DatoLiebre2.SetActive(false);
                        break;

                    case "Cactus":
                        DatoCactus.SetActive(true);
                        DatoLiebre.SetActive(false);
                        DatoCoryphantha.SetActive(false);
                        DatoIzote.SetActive(false);
                        DatoLiebre2.SetActive(false);
                        break;

                    case "Coryphantha":
                        DatoCoryphantha.SetActive(true);
                        DatoLiebre.SetActive(false);
                        DatoIzote.SetActive(false);
                        DatoCactus.SetActive(false);
                        DatoLiebre2.SetActive(false);
                        break;

                    case "Izote":
                        DatoIzote.SetActive(true);
                        DatoLiebre.SetActive(false);
                        DatoCactus.SetActive(false);
                        DatoCoryphantha.SetActive(false);
                        DatoLiebre2.SetActive(false);
                        break;

                }
            }

        }
    }
}
