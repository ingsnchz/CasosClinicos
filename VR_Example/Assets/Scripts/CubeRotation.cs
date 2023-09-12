using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //Variables - Tipo de dato + nombre + Simbolo de Asignacion + valor + ;
    public int edad = 15;
    public float altura = 1.85f, speed = 30;
    public string nombre = "Jorge";
    public char letras = 'l';
    public bool IsDoorOpen = false;

    // Function - Tipo de dato
    void setNombre()
    {
        //Logica
    }
    void setNombre(string _nombre)
    {
        nombre = _nombre;
    }

    void setRotationOfCube()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }

    float getAltura()
    {
        return altura; 
    }

    // Start is called before the first frame update
    void Start()
    {
        // Inicializacion de recursos
        Debug.Log("Hola, esto es una prueba de una funcion llamada Start()");
    }

    // Update is called once per frame
    void Update()
    {
        //Actualizacion logica
        Debug.Log("Actualizacion de la funcion Update()");

        // 1) Crear una variable de tipo float llamada speed
        // 2) Crear una funcion llamada setRotationOfCube()
        // 3) Llamar funcion en Update
        setRotationOfCube();

        Debug.Log("La altura es: " + getAltura().ToString());
    }


}
