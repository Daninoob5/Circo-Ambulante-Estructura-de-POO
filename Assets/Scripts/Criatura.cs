using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Criatura : MonoBehaviour
{
    // Propiedades
    public string nombre;
    public int nivel;
    public Habilidad habilidad;
    public Habilidad[] todasLasHabilidades = new Habilidad[1];
    public float oroPorEspectaculo;
    public int repPorEspectaculo;
    public bool Legendario;
    // Atributos privados
    public bool esEstrella;
    public int costoSubirNivel;

    //Métodos
    public void usarHabilidad()
    {
        if (habilidad != null)
        {
            habilidad.activar();
            print("La criatura: " + nombre + ", ha utilizado su habilidad: " + habilidad.nombre);

        }
        else
        {
            print("La criatura " + nombre + " no tiene una hablididad");
        }
    }

    public void subirNivel()
    {
        nivel++;
        if (Legendario)
        {
            if (nivel < 5)
            {
                oroPorEspectaculo += 4;
            }
            else if (nivel == 5)
            {
                oroPorEspectaculo += 6;
                repPorEspectaculo += 4;
            }
            else if (nivel < 10)
            {
                oroPorEspectaculo += 6;
            }
            else
            {
                oroPorEspectaculo += 10;
                repPorEspectaculo += 10;
            }
        } // esto se podría hacer con un for pero no sé
        else
        {
            if (nivel < 5)
            {
                oroPorEspectaculo += 2;
            }
            else if (nivel == 5)
            {
                oroPorEspectaculo += 3;
                repPorEspectaculo += 2;
            }
            else if (nivel < 10)
            {
                oroPorEspectaculo += 3;
            }
            else
            {
                oroPorEspectaculo += 5;
                repPorEspectaculo += 5;
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        nivel = 1;
        habilidad = null;
        habilidad = todasLasHabilidades[Random.Range(0, todasLasHabilidades.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        if( Legendario ) 
        {

            costoSubirNivel = nivel * 20;
        }
        else
        {
            costoSubirNivel = nivel * 10;
        }

        if (nivel >= 10)
        {
            esEstrella = true;
        }
    }
}
