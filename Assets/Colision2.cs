using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision2 : MonoBehaviour
{
    public GameObject objeto;
    public GameObject devuelta;

    public Contador cont;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
        {
            if( other.transform.tag == "Mano" )
            { 
                print("Retorno" + cont.retorno); 
                devuelta.active = true;
                objeto.active   = false;
                cont.retorno = cont.retorno + 1;
            } 
        } 
}
