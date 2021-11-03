using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botones : MonoBehaviour
{
    Juego juego;

    public GameObject vacio;
    public GameObject player1_X;
    public GameObject player2_O;

    public int estado = 0;

    private void Awake()
    {
        juego = GameObject.Find("Juego").gameObject.GetComponent<Juego>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Pulsaciones()
    {
        if (juego.jugador == false)
        {
            estado = 1;

            vacio.SetActive(false);
            player1_X.SetActive(true);
            
        }
        else
        {
            estado = 2;
            vacio.SetActive(false);
            
            player2_O.SetActive(true); 
        }
    }

}
