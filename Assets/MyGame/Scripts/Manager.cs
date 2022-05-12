using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

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
    //normale Text Komponente
    //public InputField ipfKidsName;
    public TMP_Text displayKidsName;

    //TMP Komponente
    public TMP_InputField ipfKidsNameTMP;

    private SoRuntimeData runtimeData;

    void Start()
    {
        runtimeData = Resources.Load<SoRuntimeData>("Kinderaddierer");

        if(SceneManager.GetActiveScene().buildIndex == (int)MyScenes.Round1)
        {
            Debug.Log("in Scene Round1");
            displayKidsName.text = runtimeData.nameKid;
        }
    }
    
    //Aufruf in Inspector OnClick bei Button, generisch über Parameter
    public void SwitchScene(int x)
    {
        Debug.Log("BTN Pressed, get kidsname " + ipfKidsNameTMP.text);
        runtimeData.nameKid = ipfKidsNameTMP.text;

        if (SceneManager.GetActiveScene().buildIndex == (int)MyScenes.Welcome)
        {
            displayKidsName.text = runtimeData.nameKid;
        }
        
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
