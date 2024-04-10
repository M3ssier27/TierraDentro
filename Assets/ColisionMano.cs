using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionMano : MonoBehaviour
{
    
    public GameObject objeto;
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
                print("Colision" + cont.contObjeto); 
                objeto.active = false;
                cont.contObjeto = cont.contObjeto + 1;
            } 
        } 
}
