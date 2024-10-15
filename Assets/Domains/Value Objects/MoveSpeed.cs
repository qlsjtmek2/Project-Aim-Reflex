using System;

class MoveSpeed : IState
{
    private readonly float _value;

    public float Value => _value;

    public MoveSpeed(float value)
    {
        if (value < 0)
        {
            throw new ArgumentException("이동속도는 0보다 작을 수 없습니다.");
        }

        if (value > 99)
        {
            throw new SuspiciousPlayerException("이동속도는 99보다 클 수 없습니다.");
        }

        _value = value;
    }
}