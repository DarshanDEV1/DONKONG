using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Level", menuName = "Level Generator")]
public class LevelGenerator : ScriptableObject
{
    //This is a scriptable object that is used to generator a level;
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private GameObject _playerPrefab;
    [SerializeField] private GameObject _ladderPrefab;
    [SerializeField] private GameObject _bridgePrefab;
}
