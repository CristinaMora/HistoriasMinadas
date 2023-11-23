using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/LevelData", order = 1)]
public class LevelData : ScriptableObject
{
      #region references
    /// <summary>
    /// Texto de info
    /// </summary>
    public string[] texto;
    #endregion
}
