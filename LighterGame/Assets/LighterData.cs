using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "LighterData", menuName = "Scriptable Objects/LighterData")]
public class LighterData : ScriptableObject
{
    [Header("ƒ‰ƒCƒ^[‚ğİ’è‚·‚é")]
    [SerializeField] public List<CursorEntry> lighterImage = new List<CursorEntry>();

    [Header("‰Î‚ğİ’è‚·‚é")]
    [SerializeField] public List<FireManager> fireImage = new List<FireManager>();
}
