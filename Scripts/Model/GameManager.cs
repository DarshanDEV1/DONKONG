using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UIController _ui_Controller;
    [SerializeField] private GameObject _ui_Prefab;

    private void Awake()
    {
        _ui_Controller = UIController.Instance;
    }
    private void Start()
    {
        _ui_Controller.Begin(_ui_Prefab);
    }
}
