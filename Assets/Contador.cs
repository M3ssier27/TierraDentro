using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contador : MonoBehaviour
{

    public float contObjeto = 0;
    public float retorno = 0;
    
    public GameObject piedra;

    public GameObject obj1A;
    public GameObject obj2A;
    public GameObject obj3A;
    public GameObject obj4A;
    public GameObject obj5A;

    public GameObject obj1B;
    public GameObject obj2B;
    public GameObject obj3B;
    public GameObject obj4B;
    public GameObject obj5B;

   

    void Start()
    {
        piedra.active= false;
    
        obj1B.active = false;
        obj2B.active = false;
        obj3B.active = false;
        obj4B.active = false;
        obj5B.active = false;

    }

    void Update()
    {
        if(contObjeto == 5)
        {
            piedra.active= true;
    
            obj1B.active = true;
            obj2B.active = true;
            obj3B.active = true;
            obj4B.active = true;
            obj5B.active = true;

            contObjeto = 0;

        }

        if(retorno == 5)
        {
            piedra.active = false;
            retorno = 0;
            print("Contador completado");
        }

    }

}
