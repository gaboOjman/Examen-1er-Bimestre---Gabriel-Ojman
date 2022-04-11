using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Un refugio de animales rescatados nos pide que le programemos una calculadora de alimento para saber qué costo 
//tendrán que afrontar para darle de comer a sus animales.
//Los datos que tenemos son:
//.Los gatos comen 300 g de alimento por día, y su código es G.
//.Los perros comen 400 g de alimento por día, y su código es PP.
//.Los perros grandes comen 700 g de alimento por día, y su código es PG.

//Realizar el programa que permita ingresar por inspector el código de la categoría del animal y cuántos días va a quedarse.

//El programa debe cumplir los siguientes requerimientos:

//Debe devolver el mensaje “Para ese período se necesitan  ” + [peso en gramos del alimento] + “ gramos de alimento”.

//Sabiendo que el precio del alimento es de $80 por 100g, agregar un mensaje que muestre el costo de la cantidad de alimento 
//calculada.

//Debe mostrar mensajes de error (y no realizar el cálculo) si se ingresa un código no válido o si se ingresa una cantidad
//de días menor a 3.



public class Ejercicio : MonoBehaviour
{
    // Start is called before the first frame update

    public string cat;
    public int dias;
    string[] catPermitidas = {"G","PP","GP"};
    bool[] error = new bool[2];
    

    void Start()
    {
        int errCounter = 0;
        error[0] = false;
        error[1] = false;
        for (int i = 0; i < catPermitidas.Length; i++)
        {
            if(cat == catPermitidas[i])
            {
                if (dias >= 3)
                {
                    calc();
                } else
                {
                    error[0] = true;
                }
            } else
            {
                errCounter++;
            }
        }
        if(errCounter == catPermitidas.Length)
        {
            error[1] = true;
        }


        if (error[0])
        {
            Debug.Log("La cantidad de dias no puede ser menor a 3");
        } else if (error[1])
        {
            Debug.Log("Codigo no válido");
        } else
        {
            calc();
            Debug.Log("a");
        }
    }

    void calc() {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
