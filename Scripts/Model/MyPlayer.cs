using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class MyPlayer : MonoBehaviour, BaapBaapHotaHai
{
    [SerializeField] private int _speed;
    [SerializeField] private Rigidbody2D _rb;
    private static MyPlayer _instance;

    private bool _move;
    private Vector2 _position;

    public static MyPlayer Instance
    {
        get
        {
            if( _instance == null)
            {
                _instance = FindObjectOfType<MyPlayer>();
            }
            return _instance;
        }
    }

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _rb.MovePosition((Vector2)transform.position + _position * Time.deltaTime * _speed);
    }

    protected internal void Move(Vector2 _direction, bool _canMove)
    {
        //This method is used to move the player towards the provided direction...
        //Debug.Log("Move Player... " + _direction);
        _move = _canMove;
        _position = _direction;
    }
}
