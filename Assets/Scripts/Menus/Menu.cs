using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro; 

public class Menu : MonoBehaviour
{

    public RectTransform canvasRect; 

    public RectTransform CanvasRect 
    {
        get {return canvasRect;}
    }

    public void Salir()
    {
        Application.Quit();
    }

  
    
}
