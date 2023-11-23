using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CordobaScenenManager : MonoBehaviour
{
    #region references
    [SerializeField]
    private CordobaUI uiManager;
    [SerializeField]
    LevelData _levelData;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
       Debug.Log(_levelData.texto[0]) ;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
