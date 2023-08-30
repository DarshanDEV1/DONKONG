using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "UI", menuName = "UI Control")]
public class UIController : ScriptableObject, BaapBaapHotaHai
{
    #region SINGLETON_INSTANCES
    private static UIController _instance; // Singleton instance
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
    #endregion

    #region PREFAB_INSTANCES
    private Transform _ui_Controller;
    #endregion

    #region PUBLIC_METHODS
    public void Begin(GameObject _ui_controller)
    {
        Transform parentTransform = FindObjectOfType<GameManager>().transform;
        Debug.Log("The UIController object has been started...");
        ButtonClickActions(_ui_controller);
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
    #endregion

    #region PRIVATE_METHODS
    private void ButtonClickActions(GameObject _ui_Prefab)
    {
        _ui_Controller = Instantiate(_ui_Prefab).transform;
        MyPlayer _player = MyPlayer.Instance;

        _ui_Controller.GetChild(2).GetComponent<Button>().onClick.AddListener(() =>
        {
            //Debug.Log("Jump button clicked...");
            _player.Jump();
        });
        _ui_Controller.GetChild(3).GetComponent<Button>().onClick.AddListener(() =>
        {
            Debug.Log("Act button clicked...");
        });
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
    #endregion
}
