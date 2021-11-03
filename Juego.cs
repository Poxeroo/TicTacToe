using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Juego : MonoBehaviour
{

    public bool jugador = false; // false = x y true = O
    public GameObject jugadorx;
    public GameObject jugadorO;

    public List<GameObject> fichas = new List<GameObject>();

    int CasillasVacias = 0;


    
  /*  
    public Text ScoreX;
    public Text ScoreO;
    int victoriasX = 0;
    int victoriasO = 0;
  */

    // Start is called before the first frame update
    void Start()
    {
        jugador = false;
        jugadorx.SetActive(true);
        jugadorO.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                botones boton = hit.transform.gameObject.GetComponent<botones>();

                if (boton.estado == 0)
                {
                    hit.transform.gameObject.GetComponent<botones>().Pulsaciones();
                    ChequeoVictoria();
                }
                else if (boton.estado == 1)
                {
                    // hit.transform.gameObject.GetComponent<botones>().Pulsaciones();
                    //CambiarJugador();
                }
                else if (boton.estado == 2)
                {
                    //hit.transform.gameObject.GetComponent<botones>().Pulsaciones();
                    //CambiarJugador();
                }
                chequeo();

            }
        }
    }

    void ChequeoVictoria()
    {       //Filas x
        if (fichas[0].GetComponent<botones>().estado == 1 &&
            fichas[1].GetComponent<botones>().estado == 1 &&
            fichas[2].GetComponent<botones>().estado == 1) {
            reset();
        }
        if (fichas[3].GetComponent<botones>().estado == 1 &&
            fichas[4].GetComponent<botones>().estado == 1 &&
            fichas[5].GetComponent<botones>().estado == 1)
        {
            reset();
        }
        if (fichas[6].GetComponent<botones>().estado == 1 &&
            fichas[7].GetComponent<botones>().estado == 1 &&
            fichas[8].GetComponent<botones>().estado == 1)
        {
            reset();
        }
        //Columnas x
        if (fichas[0].GetComponent<botones>().estado == 1 &&
            fichas[3].GetComponent<botones>().estado == 1 &&
            fichas[6].GetComponent<botones>().estado == 1)
        {
            reset();
        }
        if (fichas[1].GetComponent<botones>().estado == 1 &&
            fichas[4].GetComponent<botones>().estado == 1 &&
            fichas[7].GetComponent<botones>().estado == 1)
        {
            reset();
        }
        if (fichas[2].GetComponent<botones>().estado == 1 &&
            fichas[5].GetComponent<botones>().estado == 1 &&
            fichas[8].GetComponent<botones>().estado == 1)
        {
            reset();
        }
        //Diagonales x
        if (fichas[0].GetComponent<botones>().estado == 1 &&
            fichas[4].GetComponent<botones>().estado == 1 &&
            fichas[8].GetComponent<botones>().estado == 1)
        {
            reset();
        }
        if (fichas[2].GetComponent<botones>().estado == 1 &&
            fichas[4].GetComponent<botones>().estado == 1 &&
            fichas[6].GetComponent<botones>().estado == 1)
        {
            reset();
        }

        //Filas 0
        if (fichas[0].GetComponent<botones>().estado == 2 &&
            fichas[1].GetComponent<botones>().estado == 2 &&
            fichas[2].GetComponent<botones>().estado == 2)
        {
            reset();
        }
        if (fichas[3].GetComponent<botones>().estado == 2 &&
            fichas[4].GetComponent<botones>().estado == 2 &&
            fichas[5].GetComponent<botones>().estado == 2)
        {
            reset();
        }
        if (fichas[6].GetComponent<botones>().estado == 2 &&
            fichas[7].GetComponent<botones>().estado == 2 &&
            fichas[8].GetComponent<botones>().estado == 2)
        {
            reset();
        }
        //Columnas 0
        if (fichas[0].GetComponent<botones>().estado == 2 &&
            fichas[3].GetComponent<botones>().estado == 2 &&
            fichas[6].GetComponent<botones>().estado == 2)
        {
            reset();
        }
        if (fichas[1].GetComponent<botones>().estado == 2 &&
            fichas[4].GetComponent<botones>().estado == 2 &&
            fichas[7].GetComponent<botones>().estado == 2)
        {
            reset();
        }
        if (fichas[2].GetComponent<botones>().estado == 2 &&
            fichas[5].GetComponent<botones>().estado == 2 &&
            fichas[8].GetComponent<botones>().estado == 2)
        {
            reset();
        } 
        //Diagonales 0
        if (fichas[0].GetComponent<botones>().estado == 2 &&
            fichas[4].GetComponent<botones>().estado == 2 &&
            fichas[8].GetComponent<botones>().estado == 2)
        {
            reset();
        }
        if (fichas[2].GetComponent<botones>().estado == 2 &&
            fichas[4].GetComponent<botones>().estado == 2 &&
            fichas[6].GetComponent<botones>().estado == 2)
        {
            reset();
        }

        CambiarJugador();
    }
    void chequeo()
    {
        for (int x = 0; x < fichas.Count; x++)
        {
            if (fichas[x].GetComponent<botones>().estado == 0)
            {
                CasillasVacias++;
            }
        }
        if (CasillasVacias == 0)
        {
            reset();
        }
        CasillasVacias = 0;
    }

    void reset()
    {
        SceneManager.LoadScene(0);
    }

    void CambiarJugador()
    {
        jugador = !jugador;
        CambiarTextJugador();
    }

    void CambiarTextJugador()
    {
        if (jugador == false)
        {
            jugadorx.SetActive(true);
            jugadorO.SetActive(false);
        }
        else
        {
            jugadorx.SetActive(false);
            jugadorO.SetActive(true);
        }
    }

   /* void victoria(){
        reset();
    }*/
}
