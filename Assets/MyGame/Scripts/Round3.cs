using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.UI;

public class Round3 : MonoBehaviour
{
    public TMP_Text randomNr1;
    public TMP_Text randomNr2;
    public TMP_Text randomNr3;
    public TMP_Text randomNr4;

    public TMP_Text score;
    public int scoreCount;

    public TMP_InputField input1, input3, input5, input7;
    public TMP_InputField input2, input4, input6, input8;

    private SoRuntimeData runtimeData;
    
    private string getNumber1;
    private string getNumber2;
    private string getNumber3;
    private string getNumber4;
    private string getNumber5;
    private string getNumber6;
    private string getNumber7;
    private string getNumber8;

    private int result;

    void Start()
    {
        runtimeData = Resources.Load<SoRuntimeData>("Kinderaddierer");

        randomNr1.text = UnityEngine.Random.Range(1, 20).ToString();
        randomNr2.text = UnityEngine.Random.Range(1, 20).ToString();
        randomNr3.text = UnityEngine.Random.Range(1, 20).ToString();
        randomNr4.text = UnityEngine.Random.Range(1, 20).ToString();

        score.text = scoreCount.ToString();
        scoreCount = 0;
    }

    public void GetNumber(string firstNr, string secondNr, TMP_InputField firstIP, TMP_InputField secondIP, TMP_Text randomNr, TMP_InputField sprite)
    {
        firstNr = firstIP.text;
        secondNr = secondIP.text;

        int.TryParse(firstNr, out int parseNr1);
        int.TryParse(secondNr, out int parseNr2);

        result = parseNr2 - parseNr1;
        Debug.Log(result);

        int parseRandomNumber1 = Int32.Parse(randomNr.text);

        if(parseRandomNumber1 == result)
        {
            Debug.Log("true");
            sprite.image.color = Color.green;

            scoreCount++;
            Debug.Log(scoreCount);
            score.text = scoreCount.ToString();
        }
        else
        {
            Debug.Log("false");
            sprite.image.color = Color.red;
        }

        runtimeData.scoreResult = score.text;
        runtimeData.scoreMessage = scoreCount;
    }

    public void Test()
    {
        GetNumber(getNumber1, getNumber2, input1, input2, randomNr1, input2);
        GetNumber(getNumber3, getNumber4, input3, input4, randomNr2, input4);
        GetNumber(getNumber5, getNumber6, input5, input6, randomNr3, input6);
        GetNumber(getNumber7, getNumber8, input7, input8, randomNr4, input8);
    }
}
