using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CirusManager : MonoBehaviour
{
    // Propiedades
    public string nombre;
    public int reputación;
    public float oro;
    public Criatura[] todasLasCriaturas = new Criatura[20];
    public bool realizarUnEspectáculo;

    public Criatura criatura1;
    public bool entrenarSlot1;
    public bool expulsarCriaturaSlot1;
    public bool NuevaCriaturaSlot1;
    public bool realizarHabilidad1;
    
    public Criatura criatura2;
    public bool entrenarSlot2;
    public bool expulsarCriaturaSlot2;
    public bool NuevaCriaturaSlot2;
    public bool realizarHabilidad2;
    
    public Criatura criatura3;
    public bool entrenarSlot3;
    public bool expulsarCriaturaSlot3;
    public bool NuevaCriaturaSlot3;
    public bool realizarHabilidad3;

    // Atributos privados
    private float oroPorEspectaculoTotal;
    //private int capacidadCirco;

    // Métodos
    private void organizarEspectaculo()
    {
        if (criatura1 != null || criatura2 != null || criatura3 != null)
        {
            print("Realizando un espectáculo..."); // aquí esperaría unos segundos
            //Calculo del dinero
            if (criatura1 != null)
            {
                if(criatura2 != null)
                {
                    if (criatura3 != null)
                    {
                        oroPorEspectaculoTotal += criatura1.oroPorEspectaculo + criatura2.oroPorEspectaculo + criatura3.oroPorEspectaculo;
                    }
                    else
                    {
                        oroPorEspectaculoTotal += criatura1.oroPorEspectaculo + criatura2.oroPorEspectaculo;
                    }
                }
                else if (criatura3 != null)
                {
                    oroPorEspectaculoTotal += criatura1.oroPorEspectaculo + criatura3.oroPorEspectaculo;
                }
                else
                {
                    oroPorEspectaculoTotal += criatura1.oroPorEspectaculo;
                }
            }
            else if (criatura2 != null)
            {
                if (criatura3 != null)
                {
                    oroPorEspectaculoTotal += criatura2.oroPorEspectaculo + criatura3.oroPorEspectaculo;
                }
                else
                {
                    oroPorEspectaculoTotal += criatura2.oroPorEspectaculo;
                }
            }
            else
            {
                oroPorEspectaculoTotal += criatura3.oroPorEspectaculo;
            }
            //Calculo de la reputación
            if (criatura1 != null)
            {
                if (criatura2 != null)
                {
                    if (criatura3 != null)
                    {
                        reputación += criatura1.repPorEspectaculo + criatura2.repPorEspectaculo + criatura3.repPorEspectaculo;
                    }
                    else
                    {
                        reputación += criatura1.repPorEspectaculo + criatura2.repPorEspectaculo;
                    }
                }
                else if (criatura3 != null)
                {
                    reputación += criatura1.repPorEspectaculo + criatura3.repPorEspectaculo;
                }
                else
                {
                    reputación += criatura1.repPorEspectaculo;
                }
            }
            else if (criatura2 != null)
            {
                if (criatura3 != null)
                {
                    reputación += criatura2.repPorEspectaculo + criatura3.repPorEspectaculo;
                }
                else
                {
                    reputación += criatura2.repPorEspectaculo;
                }
            }
            else
            {
                reputación += criatura3.repPorEspectaculo;
            }
            oro += oroPorEspectaculoTotal;
            print("Has organizado un espectáculo, has ganado " + oroPorEspectaculoTotal + " monedas y tu reputación ahora es de " + reputación);
        }
        else
        {
            print("No tienes criaturas para el espectáculo");
        }
    }

    private void entrenarCriatura(Criatura criatura)
    {
        if (criatura != null)
        {
            if(oro >= criatura.costoSubirNivel)
            {
                if (criatura.esEstrella)
                {
                    print("Tu " + criatura.nombre + " ha llegado al nivel máximo.");
                }
                else
                {
                    oro = oro - criatura.costoSubirNivel;
                    criatura.subirNivel();
                    print("Has entrenado a tu " + criatura.nombre + " y has gastado " + criatura.costoSubirNivel + " monedas.");
                }
            }
            else
            {
                print("No tienes suficiente dinero");
            }
        }
        else
        {
            print("La criatura no existe");
        }
    }

    private void agregarCriatura(int i)
    {
        print("Buscando una nueva criatura...");
        if(oro >= 20)
        {
            if (i == 1)
            {
                if (criatura1 != null)
                {
                    print("No hay espacio para una nueva criatura");
                }
                else
                {
                    oro = oro - 20;
                    criatura1 = todasLasCriaturas[Random.Range(0, todasLasCriaturas.Length)];
                    print("Has obtenido la criatura " + criatura1.nombre);
                }
            }
            else if(i == 2)
            {
                if (criatura2 != null)
                {
                    print("No hay espacio para una nueva criatura");
                }
                else
                {
                    oro = oro - 20;
                    criatura2 = todasLasCriaturas[Random.Range(0, todasLasCriaturas.Length)];
                    print("Has obtenido la criatura " + criatura2.nombre);
                }
            }
            else if (i == 3)
            {
                if (criatura3 != null)
                {
                    print("No hay espacio para una nueva criatura");
                }
                else
                {
                    oro = oro - 20;
                    criatura3 = todasLasCriaturas[Random.Range(0, todasLasCriaturas.Length)];
                    print("Has obtenido la criatura " + criatura3.nombre);
                }
            }
            else
            {
                print("Error");
            }
        }
        else
        {
            print("No tienes suficiente dinero");
        }
            

    }

    private void removerCriatura(int i)
    {
        if(i==1)
        {
            if (criatura1 != null)
            {
                print("Has expulsado a tu " + criatura1.name);
                criatura1 = null;
            }
            else
            {
                print("No tienes una criatura");
            }
        }
        else if (i == 2)
        {
            if (criatura2 != null)
            {
                print("Has expulsado a tu " + criatura2.name);
                criatura2 = null;
            }
            else
            {
                print("No tienes una criatura");
            }
        }
        else if(i==3)
        {
            if (criatura3 != null)
            {
                print("Has expulsado a tu " + criatura3.name);
                criatura3 = null;
            }
            else
            {
                print("No tienes una criatura");
            }
        }
        else
        {
            print("Error");
        }
    }
    
    //private void mejorarCirco()
    //{
        //print("Has mejorado el circo, ahora tienes espacio para " + " criaturas.");
    //}



    void Start()
    {
       reputación = 0;
       oro = 100;
        //capacidadCirco = 3;
        print("Has creado tu circo");
    }
    void Update()
    {
        if(reputación <= -50)
        {
            print("Has perdido, tu reputación es demasiado baja");
            
        }
        // Slot 1
        if (entrenarSlot1)
        {
            entrenarCriatura(criatura1);
            entrenarSlot1 = false;
        }
        if (expulsarCriaturaSlot1)
        {
            removerCriatura(1);
            expulsarCriaturaSlot1 = false;
        }
        if (NuevaCriaturaSlot1)
        {
            agregarCriatura(1);
            NuevaCriaturaSlot1 = false;
        }
        if (realizarHabilidad1)
        {
            if (criatura1 != null)
            {
                criatura1.usarHabilidad();
            }
            else
            {
                print("No tienes una criatura");
            }
            realizarHabilidad1 = false;
        }
        //Slot 2
        if (entrenarSlot2)
        {
            entrenarCriatura(criatura2);
            entrenarSlot2 = false;
        }
        if (expulsarCriaturaSlot2)
        {
            removerCriatura(2);
            expulsarCriaturaSlot2 = false;
        }
        if (NuevaCriaturaSlot2)
        {
            agregarCriatura(2);
            NuevaCriaturaSlot2 = false;
        }
        if (realizarHabilidad2)
        {
            if (criatura2 != null)
            {
                criatura2.usarHabilidad();
            }
            else
            {
                print("No tienes una criatura");
            }
            realizarHabilidad2 = false;
        }
        // Slot 3
        if (entrenarSlot3)
        {
            entrenarCriatura(criatura3);
            entrenarSlot3 = false;
        }
        if (expulsarCriaturaSlot3)
        {
            removerCriatura(3);
            expulsarCriaturaSlot3 = false;
        }
        if (NuevaCriaturaSlot3)
        {
            agregarCriatura(3);
            NuevaCriaturaSlot3 = false;
        }
        if (realizarHabilidad3)
        {
            if(criatura3 != null)
            {
                criatura3.usarHabilidad();
            }
            else
            {
                print("No tienes una criatura");
            }
            realizarHabilidad3 = false;
        }

        if (realizarUnEspectáculo)
        {
            organizarEspectaculo();
            realizarUnEspectáculo = false;
        }
    }
}
