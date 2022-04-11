using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej : MonoBehaviour
{
    //Todos los ingresos se hacen por Inspector.
    //Ingresar:
    //nombre de alumno
    //de qué año es(un número del 1 al 5)
    //a qué orientación pertenece(sólo se puede ingresar la inicial en mayúscula de la especialidad: T para TIC, D para Diseño, G para Gestión, M para Medios y H para Humanidades).

    //El programa debe cumplir los siguientes requerimientos:

    //Mostrar un mensaje de error si el nombre ingresado es una cadena de caracteres vacía y si el año ingresado no está en el rango del 1 al 5. 

    //Si se ingresa un valor diferente a las opciones válidas en el campo ingreso de orientación escribir en consola “Solo puede ingresar T, D, G, M o H”. 


    //Si el año ingresado no está entre 3 y 5 se debe mostrar el mensaje “Error.Aún estás en el ciclo básico”.


    //Si los ingresos de nombre, año y orientación son válidos escribir en consola un mensaje de agradecimiento en el siguiente formato: “Muchas gracias[nombreAlumno]!”


    public string nombre;
    public int anio;
    public string orientacion;

    // Start is called before the first frame update
    void Start()
    {
        int orientacionmal = 0;
        
            if (nombre == "")
            {
                Debug.Log("ERROR: El nombre esta vacio");
            }

            if (anio < 1 || anio > 5)
            {
                Debug.Log("ERROR: El año debe estar entre primer y quinto año");
            }

            if (anio < 3)
            {
                Debug.Log("ERROR: aun estas en ciclo basico");
            }

            if (orientacion == "T" || orientacion == "D" || orientacion == "G" || orientacion == "M" || orientacion == "H")
            {
                orientacionmal = 1;
            }
            else if (orientacionmal == 0)
            {
                Debug.Log("ERROR: Solo puede ingresar T, D, G, M o H");
            }
        



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
