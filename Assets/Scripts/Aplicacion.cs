using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class Aplicacion : MonoBehaviour
{

	private static Aplicacion _instancia;
		
	public static Aplicacion instancia
	{
		get
		{
			if (_instancia == null)
				_instancia = FindObjectOfType<Aplicacion>();
			if (_instancia == null)
			{
				var res = Resources.Load("Aplicacion", typeof(GameObject)) as GameObject;
				GameObject go = GameObject.Instantiate(res);
				_instancia = go.GetComponent<Aplicacion>();
				_instancia.Iniciar();
			}
			return _instancia;
		}
	}
	
	bool instanciaIniciada = false;
	
	
	void Iniciar()
	{
		if (instanciaIniciada) return;
		
		// ...
		
		instanciaIniciada = true;
	}   
	

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        // reiniciar estado 

        // establecer resolucion
        Screen.SetResolution(1920, 1080, true);
        // no permitir el uso de raton fuera del editor

    }






}
