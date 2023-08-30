using UnityEngine;

public class MyPlayer : MonoBehaviour, BaapBaapHotaHai
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jump;
    [SerializeField] private Rigidbody2D _rb;
    private static MyPlayer _instance;

    private bool _move;
    private Vector2 _position;

    public static MyPlayer Instance
    {
        get
        {
            if (_instance == null)
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
        if (_move)
        {
            _rb.MovePosition((Vector2)transform.position + _position * Time.deltaTime * _speed);
            transform.GetChild(0).GetComponent<Animator>().SetBool(AnimBool.isWalking.ToString(), true);
        }
        else
        {
            transform.GetChild(0).GetComponent<Animator>().SetBool(AnimBool.isWalking.ToString(), false);
        }
    }

    protected internal void Move(Vector2 _direction, bool _canMove)
    {
        _move = _canMove;
        _position = _direction;
    }

    protected internal void Jump()
    {
        transform.GetChild(0).GetComponent<Animator>().Play(PlayerAnimation.PlayerJump.ToString());
        //_rb.AddForce(new Vector2(_rb.velocity.x, _jump));
    }
}
