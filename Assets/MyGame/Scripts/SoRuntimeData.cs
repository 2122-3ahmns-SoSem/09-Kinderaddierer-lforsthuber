using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SoRuntimeData")]
public class SoRuntimeData : ScriptableObject
{
    public string nameKid = " ";
    public string selectedImg = " ";
    public string scoreResult = " ";
    public int scoreMessage = 0;

    private void OnEnable()
    {
        nameKid = " ";
        selectedImg = " ";
        scoreResult = " ";
        scoreMessage = 0;
    }
}
