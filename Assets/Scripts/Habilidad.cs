using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Habilidad : MonoBehaviour
{
    //Propiedades
    public CirusManager manager;
    public string nombre;
    public int reputaci�nQueOtorga;
    public float oroQueOtorga;
    //Atributos privados
    //M�todos 
    public void activar()
    {
        manager.oro += oroQueOtorga;
        manager.reputaci�n += reputaci�nQueOtorga;
        print("Has presenciado: " + nombre + ". Has ganado " + oroQueOtorga + " de oro y tu reputaci�n ahora es de " + manager.reputaci�n);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
