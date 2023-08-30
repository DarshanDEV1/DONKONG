using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UIController _ui_Controller;
    [SerializeField] private LevelGenerator _levelGenerator;
    [SerializeField] private GameObject _ui_Prefab;

    [SerializeField] private GameObject[] _prefabs = new GameObject[4];

    private void Awake()
    {
        _ui_Controller = UIController.Instance;
        _levelGenerator = LevelGenerator.Instance;
    }
    private void Start()
    {
        _ui_Controller.Begin(_ui_Prefab);
        _levelGenerator.Begin(_prefabs);
    }
}
