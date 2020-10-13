using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnMatorralesInfo : MonoBehaviour
{

    string btnName;
    int Conteo;
    GameObject DatoBorrego;
    GameObject DatoBorrego2;
    GameObject DatoBorrego3;
    GameObject DatoLiebre;
    GameObject DatoLiebre2;
    GameObject DatoPecari;
    GameObject DatoPecari2;
    GameObject DatoZorrita;
    GameObject DatoZorrita2;
    GameObject DatoCoyote;
    GameObject DatoCoyote2;
    GameObject DatoCactus;
    GameObject DatoCoryphantha;
    GameObject DatoIzote;


    // Use this for initialization
    void Start()
    {

        DatoBorrego = GameObject.Find("BorregoDato");
        DatoBorrego.SetActive(false);

        DatoBorrego2 = GameObject.Find("BorregoDato2");
        DatoBorrego2.SetActive(false);

        DatoBorrego3 = GameObject.Find("BorregoDato3");
        DatoBorrego3.SetActive(false); 

        DatoLiebre = GameObject.Find("LiebreDato");
        DatoLiebre.SetActive(false);

        DatoLiebre2 = GameObject.Find("LiebreDato2");
        DatoLiebre2.SetActive(false);

        DatoPecari = GameObject.Find("PecariDato");
        DatoPecari.SetActive(false);

        DatoPecari2 = GameObject.Find("PecariDato2");
        DatoPecari2.SetActive(false);

        DatoZorrita = GameObject.Find("ZorritaDato");
        DatoZorrita.SetActive(false);

        DatoZorrita2 = GameObject.Find("ZorritaDato2");
        DatoZorrita2.SetActive(false);

        DatoCoyote = GameObject.Find("CoyoteDato");
        DatoCoyote.SetActive(false);

        DatoCoyote2 = GameObject.Find("CoyoteDato2");
        DatoCoyote2.SetActive(false);

        DatoCactus = GameObject.Find("CactusDato");
        DatoCactus.SetActive(false);

        DatoCoryphantha = GameObject.Find("CoryphanthaDato");
        DatoCoryphantha.SetActive(false);

        DatoIzote = GameObject.Find("IzoteDato");
        DatoIzote.SetActive(false);
    }

    public void BorregoNext()
    {
        DatoBorrego.SetActive(false);
        DatoBorrego2.SetActive(true);
    }
    public void BorregoNext2()
    {
        DatoBorrego2.SetActive(false);
        DatoBorrego3.SetActive(true);
    }
    public void LiebreNext()
    {
        DatoLiebre.SetActive(false);
        DatoLiebre2.SetActive(true);
    }
    public void PecariNext()
    {
        DatoPecari.SetActive(false);
        DatoPecari2.SetActive(true);
    }
    public void ZorritaNext()
    {
        DatoZorrita.SetActive(false);
        DatoZorrita2.SetActive(true);
    }
    public void CoyoteNext()
    {
        DatoCoyote.SetActive(false);
        DatoCoyote2.SetActive(true);
    }

    public void CloseMatorral()
    {
        DatoBorrego.SetActive(false);
        DatoBorrego2.SetActive(false);
        DatoBorrego3.SetActive(false);
        DatoLiebre.SetActive(false);
        DatoLiebre2.SetActive(false);
        DatoPecari.SetActive(false);
        DatoPecari2.SetActive(false);
        DatoZorrita.SetActive(false);
        DatoZorrita2.SetActive(false);
        DatoCoyote.SetActive(false);
        DatoCoyote2.SetActive(false);

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
                    case "Borrego":
                        DatoBorrego.SetActive(true);
                        DatoCactus.SetActive(false);
                        DatoCoryphantha.SetActive(false);
                        DatoIzote.SetActive(false);
                        DatoBorrego2.SetActive(false);
                        DatoBorrego3.SetActive(false);
                        DatoLiebre.SetActive(false);
                        DatoLiebre2.SetActive(false);
                        DatoPecari.SetActive(false);
                        DatoPecari2.SetActive(false);
                        DatoZorrita.SetActive(false);
                        DatoZorrita2.SetActive(false);
                        DatoCoyote.SetActive(false);
                        DatoCoyote2.SetActive(false);
                        break;

                    case "Liebre":
                        DatoLiebre.SetActive(true);
                        DatoCactus.SetActive(false);
                        DatoCoryphantha.SetActive(false);
                        DatoIzote.SetActive(false);
                        DatoLiebre2.SetActive(false);
                        DatoBorrego.SetActive(false);
                        DatoBorrego2.SetActive(false);
                        DatoBorrego3.SetActive(false);
                        DatoPecari.SetActive(false);
                        DatoPecari2.SetActive(false);
                        DatoZorrita.SetActive(false);
                        DatoZorrita2.SetActive(false);
                        DatoCoyote.SetActive(false);
                        DatoCoyote2.SetActive(false);
                        break;

                    case "Pecari":
                        DatoPecari.SetActive(true);
                        DatoCactus.SetActive(false);
                        DatoCoryphantha.SetActive(false);
                        DatoIzote.SetActive(false);
                        DatoPecari2.SetActive(false);
                        DatoBorrego.SetActive(false);
                        DatoBorrego2.SetActive(false);
                        DatoBorrego3.SetActive(false);
                        DatoLiebre.SetActive(false);
                        DatoLiebre2.SetActive(false);
                        DatoZorrita.SetActive(false);
                        DatoZorrita2.SetActive(false);
                        DatoCoyote.SetActive(false);
                        DatoCoyote2.SetActive(false);
                        break;

                    case "Zorrita":
                        DatoZorrita.SetActive(true);
                        DatoCactus.SetActive(false);
                        DatoCoryphantha.SetActive(false);
                        DatoIzote.SetActive(false);
                        DatoZorrita2.SetActive(false);
                        DatoBorrego.SetActive(false);
                        DatoBorrego2.SetActive(false);
                        DatoBorrego3.SetActive(false);
                        DatoLiebre.SetActive(false);
                        DatoLiebre2.SetActive(false);
                        DatoPecari.SetActive(false);
                        DatoPecari2.SetActive(false);
                        DatoCoyote.SetActive(false);
                        DatoCoyote2.SetActive(false);
                        break;

                    case "Coyote":
                        DatoCoyote.SetActive(true);
                        DatoCactus.SetActive(false);
                        DatoCoryphantha.SetActive(false);
                        DatoIzote.SetActive(false);
                        DatoCoyote2.SetActive(false);
                        DatoBorrego.SetActive(false);
                        DatoBorrego2.SetActive(false);
                        DatoBorrego3.SetActive(false);
                        DatoLiebre.SetActive(false);
                        DatoLiebre2.SetActive(false);
                        DatoPecari.SetActive(false);
                        DatoPecari2.SetActive(false);
                        DatoZorrita.SetActive(false);
                        DatoZorrita2.SetActive(false);
                        break;

                    case "Cactus":
                        DatoCactus.SetActive(true);
                        DatoBorrego.SetActive(false);
                        DatoCoryphantha.SetActive(false);
                        DatoIzote.SetActive(false);
                        DatoBorrego2.SetActive(false);
                        DatoBorrego3.SetActive(false);
                        DatoLiebre.SetActive(false);
                        DatoLiebre2.SetActive(false);
                        DatoPecari.SetActive(false);
                        DatoPecari2.SetActive(false);
                        DatoZorrita.SetActive(false);
                        DatoZorrita2.SetActive(false);
                        DatoCoyote.SetActive(false);
                        DatoCoyote2.SetActive(false);
                        break;

                    case "Coryphantha":
                        DatoCoryphantha.SetActive(true);
                        DatoBorrego.SetActive(false);
                        DatoIzote.SetActive(false);
                        DatoCactus.SetActive(false);
                        DatoBorrego2.SetActive(false);
                        DatoBorrego3.SetActive(false);
                        DatoLiebre.SetActive(false);
                        DatoLiebre2.SetActive(false);
                        DatoPecari.SetActive(false);
                        DatoPecari2.SetActive(false);
                        DatoZorrita.SetActive(false);
                        DatoZorrita2.SetActive(false);
                        DatoCoyote.SetActive(false);
                        DatoCoyote2.SetActive(false);
                        break;

                    case "Izote":
                        DatoIzote.SetActive(true);
                        DatoBorrego.SetActive(false);
                        DatoCactus.SetActive(false);
                        DatoCoryphantha.SetActive(false);
                        DatoBorrego2.SetActive(false);
                        DatoBorrego3.SetActive(false);
                        DatoLiebre.SetActive(false);
                        DatoLiebre2.SetActive(false);
                        DatoPecari.SetActive(false);
                        DatoPecari2.SetActive(false);
                        DatoZorrita.SetActive(false);
                        DatoZorrita2.SetActive(false);
                        DatoCoyote.SetActive(false);
                        DatoCoyote2.SetActive(false);
                        break;

                }
            }

        }
    }
}
