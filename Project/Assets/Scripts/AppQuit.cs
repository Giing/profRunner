using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppQuit : MonoBehaviour
{
    public void doQuit() { 
        Application.Quit();
        Debug.Log("App quited");
    }
}
