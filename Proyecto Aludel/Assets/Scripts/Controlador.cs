using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //directiva para caragar escenas


public class Controlador : MonoBehaviour {

	public void Cambiar_Escena (string Juego) //se tiene que ver desde afuera y no devolver nada por eso sera un "public void", le vamos a pasar una cadena de caracteres de tipo string con  el nombre de la escena a la que queremos cambiar 
    {
        print("Cambiando Escena" + Juego);
        SceneManager.LoadScene(Juego);   
    }

    public void Salir ()
    {
        print("Saliedo del Juego");
    }

}
