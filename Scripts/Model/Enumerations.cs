using UnityEngine;

public enum MoveDirection
{
    left,
    right,
    up,
    down,
    zero
}

public enum PlayerAnimation
{
    PlayerIdle,
    PlayerWalk,
    PlayerJump,
    PlayerAct,
    PlayerDeath
}

public enum AnimBool
{
    isWalking,
    isJumping,
    isClimbing
}