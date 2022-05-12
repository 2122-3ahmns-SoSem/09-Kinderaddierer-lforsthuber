using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum MyScenes
{
    Welcome,
    Round1,
    Round2,
    Round3,
    End
}

public class Manager : MonoBehaviour
{
    
    //Aufruf in Inspector OnClick bei Button, generisch über Parameter
    public void SwitchScene(int x)
    {
        SceneManager.LoadScene(x);
    }

    //Aufruf in Inspector OnClick bei Button, über Name
    public void SwitchScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    //Jede Szene wird einzeln aufgerufen, muss dan auch 
    //für jede Szene eine Methode schreiben
    public void SwitchToEnd()
    {
        SceneManager.LoadScene((int)MyScenes.End);
    }
}
