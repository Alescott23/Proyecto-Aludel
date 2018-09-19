using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public GameObject Flecha, Lista; //Variables a Controlar
    private Animator Flama;

    int Indice = 0; //Indice para vincular cada texto

    void Start ()
    {

        Dibujar();     //Creamos un metodo que se encarga de dibujar la flecha en el lugar correcto 

	}
	
	
	void Update ()
    {
        bool up = Input.GetKeyDown("up"); //tecla arriba, se da un true si se cumple
        bool down = Input.GetKeyDown("down"); //tecla abajo, se da un down si cumple

        if (up) Indice--; //decrementa en 1 si es tecla arriba
        if (down) Indice++; //aumenta en 1 si es tecla abajo

        if (Indice > Lista.transform.childCount - 1) Indice = 0; //si indice es mayor al numero de referencia que hay en la lista con un ChildCount sabemos el numero de hijos y restamos menos un, es decir, "Si el indice es mayor qu eel numero de hijos -1 pondremos el indice en 0"
        else if (Indice < 0) Indice = Lista.transform.childCount - 1; //el child count es el contador de la cantidad de Childs en este caso es de 4

        if (up || down) Dibujar(); //si se da un  "up" o un "down" se dibuja

        if (Input.GetKeyDown("return")) Accion(); //si presionamos la tecla enter llamamos a el metodo "Accion" creado abajo del todo

	}
 
    void Dibujar()     //es void por que no devuelve nada
    {

        Transform opcion = Lista.transform.GetChild(Indice); //estamos guardando el Indice de la lista en un transform 
        Flecha.transform.position = opcion.position; //le vamos asignar al objeto que acabamos de recuperar por ejemplo su nueva posicion 


    }

    void Accion()
    {
        Transform opcion = Lista.transform.GetChild(Indice); //lee el indice en el que esta

        if (opcion.gameObject.name == "Salir") //Si queremos salir del juego
        {
            Application.Quit(); //para salir
        }

     
   
 }



}
