using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SoRuntimeData")]
public class SoRuntimeData : ScriptableObject
{
    public string nameKid;

    private void OnEnable()
    {
        nameKid = " ";
    }
}
