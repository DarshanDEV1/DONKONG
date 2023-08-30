using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "UI", menuName = "UI Control")]
public class UIController : ScriptableObject, BaapBaapHotaHai
{
    private static UIController _instance; // Singleton instance
    private Transform _ui_Controller;
    public static UIController Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = CreateInstance<UIController>();
            }
            return _instance;
        }
    }

    /*public bool _button_presssed { get; set; }*/

    public void Begin(GameObject _ui_controller)
    {
        Transform parentTransform = FindObjectOfType<GameManager>().transform;
        Debug.Log("The UIController object has been started...");
        ButtonClickActions(_ui_controller);
    }

    private void ButtonClickActions(GameObject _ui_Prefab)
    {
        _ui_Controller = Instantiate(_ui_Prefab).transform;

        _ui_Controller.GetChild(2).GetComponent<Button>().onClick.AddListener(() =>
        {
            Debug.Log("Jump button clicked...");
        });
        _ui_Controller.GetChild(3).GetComponent<Button>().onClick.AddListener(() =>
        {
            Debug.Log("Act button clicked...");
        });
    }

    public void CheckMovement()
    {
        MyPlayer _player = MyPlayer.Instance;

        if (_ui_Controller.GetChild(0).GetComponent<ButtonPressed>()._pressed)
        {
            //Debug.Log("Left button is pressed...");
            _player.Move(GetVectorDirection(MoveDirection.left), true);
        }
        else if (_ui_Controller.GetChild(1).GetComponent<ButtonPressed>()._pressed)
        {
            //Debug.Log("Right button is pressed...");
            _player.Move(GetVectorDirection(MoveDirection.right), true);
        }
        else
        {
            _player.Move(GetVectorDirection(MoveDirection.zero), false);
        }
    }

    private Vector2 GetVectorDirection(MoveDirection _direction)
    {
        if(_direction == MoveDirection.left)
        {
            return Vector2.left;
        }
        else if(_direction == MoveDirection.right)
        {
            return Vector2.right;
        }
        else if(_direction == MoveDirection.up)
        {
            return Vector2.up;
        }
        else if( _direction == MoveDirection.down)
        {
            return Vector2.down;
        }
        else
        {
            return Vector2.zero;
        }
    }
}
