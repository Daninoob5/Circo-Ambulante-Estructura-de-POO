using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Habilidad : MonoBehaviour
{
    //Propiedades
    public CirusManager manager;
    public string nombre;
    public int reputaciónQueOtorga;
    public float oroQueOtorga;
    //Atributos privados
    //Métodos 
    public void activar()
    {
        manager.oro += oroQueOtorga;
        manager.reputación += reputaciónQueOtorga;
        print("Has presenciado: " + nombre + ". Has ganado " + oroQueOtorga + " de oro y tu reputación ahora es de " + manager.reputación);
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
