using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI.Table;

[CreateAssetMenu(fileName = "Level", menuName = "Level Generator")]
public class LevelGenerator : ScriptableObject
{
    #region SINGLETON_INSTANCES
    private static LevelGenerator _instance;
    public static LevelGenerator Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = CreateInstance<LevelGenerator>();
            }
            return _instance;
        }
    }
    #endregion

    #region PRIMITIVE_VARIABLES
    private int _level = 10;
    #endregion

    #region PUBLIC_METHODS
    public void Begin(GameObject[] _prefabs)
    {
        //Starting point of the scriptable object...
        GenerateLevel(_prefabs);
    }
    #endregion

    #region PRIVATE_METHODS
    private void GenerateLevel(GameObject[] _prefabs)
    {
        Debug.Log("Level Generation Process Has Been Begun...");
        for(int col = 0; col < _level; col++)
        {
            for(int row = 0; row < 1; row++)
            {
                Vector3 _m = new Vector3(row * 2, col * 2, 0);
                var _x = Instantiate(_prefabs[3], _m, Quaternion.identity);
                _x.transform.SetParent(GameObject.FindGameObjectWithTag("Level").transform);
            }
        }
    }
    #endregion
}
