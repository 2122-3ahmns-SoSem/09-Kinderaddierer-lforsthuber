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
    public Button bear;
    public Button cat;
    public Button bunny;

    private string getButton;
    private SoRuntimeData runtimeData;

    void Start()
    {
        runtimeData = Resources.Load<SoRuntimeData>("Kinderaddierer");
    }

    public void CatButton()
    {
        runtimeData.selectedImg = "cat";
    }

    public void BearButton()
    {
        runtimeData.selectedImg = "bear";
    }

    public void BunnyButton()
    {
        runtimeData.selectedImg = "bunny";
    }

    //Aufruf in Inspector OnClick bei Button, generisch über Parameter
    public void SwitchScene(int x)
    {
        runtimeData.nameKid = ipfKidsNameTMP.text;

        SceneManager.LoadScene(x);
    }
}
