using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    //variables --> tipo de dato + nombre + simbolo de asignacion + valor a asignar +;
    public int edad = 15;
    public float altura = 1.83f;
    public string nombre= "Andrea";
    public char letras = '1';
    public bool IsDoorOpen = false;

    // Function

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
        transform.Rotate(Vector3.up * 30 * Time.deltaTime);

    }

    float getAltura ()
    {
        return altura;
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hola, esto es una prueba llamada Start()");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("actualiacion de la funcion Update()");
        setRotationOfCube();
        Debug.Log("La altura es:" + getAltura() . ToString());
       
    }
}
