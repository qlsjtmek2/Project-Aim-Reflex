using UnityEngine;

public interface IMoveable
{
    void Move(Vector3 position);
}

public interface IJumpable
{
    void Jump();
    void Land();
}

public interface ICrouchable
{
    void Crouch();
    void StandUp();
}

public interface ISprintable
{
    void StartRunning();
    void StopRunning();
}