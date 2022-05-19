using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ManagerMainScenes : MonoBehaviour
{
    public TMP_Text displayKidsName;

    private SoRuntimeData runtimeData;

    void Start()
    {
        runtimeData = Resources.Load<SoRuntimeData>("Kinderaddierer");

        displayKidsName.text = runtimeData.nameKid;
    }

    //Aufruf in Inspector OnClick bei Button, generisch über Parameter
    public void SwitchScene(int x)
    {
        SceneManager.LoadScene(x);
    }

}
