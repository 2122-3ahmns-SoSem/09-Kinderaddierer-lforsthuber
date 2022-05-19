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
    public TMP_InputField ipfKidsNameTMP;

    private SoRuntimeData runtimeData;

    void Start()
    {
        runtimeData = Resources.Load<SoRuntimeData>("Kinderaddierer");
    }
    
    //Aufruf in Inspector OnClick bei Button, generisch �ber Parameter
    public void SwitchScene(int x)
    {
        runtimeData.nameKid = ipfKidsNameTMP.text;
        
        SceneManager.LoadScene(x);
    }
}
