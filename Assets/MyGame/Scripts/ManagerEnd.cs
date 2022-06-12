using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ManagerEnd : MonoBehaviour
{
    public TMP_Text displayKidsName;
    public Image displayImage;
    public TMP_Text displayScore;
    public TMP_Text displayMessage;

    private int score;
    private SoRuntimeData runtimeData;

    void Start()
    {
        runtimeData = Resources.Load<SoRuntimeData>("Kinderaddierer");

        displayKidsName.text = runtimeData.nameKid;
        SetUserImage(runtimeData.selectedImg);
        displayScore.text = runtimeData.scoreResult;
        score = runtimeData.scoreMessage;

        if(score >= 3)
        {
            displayMessage.text = "Perfekt!";
        }

        if(score <= 2 && score >= 1)
        {
            displayMessage.text = "Das geht doch besser!";
        }

        if(score < 1)
        {
            displayMessage.text = "Versuchs lieber noch mal!";
        }
    }

    void SetUserImage(string imageName)
    {
        displayImage.sprite = Resources.Load<Sprite>(imageName) as Sprite;
    }

    //Aufruf in Inspector OnClick bei Button, generisch über Parameter
    public void SwitchScene(int x)
    {
        SceneManager.LoadScene(x);
    }

}
