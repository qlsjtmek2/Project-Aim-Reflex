using System;

class JumpPower : IState
{
    private readonly float _value;

    public float Value => _value;

    public JumpPower(float value)
    {
        if (value < 0)
        {
            throw new ArgumentException("점프력은 0보다 작을 수 없습니다.");
        }

        if (value > 99)
        {
            throw new SuspiciousPlayerException("점프력은 99보다 클 수 없습니다.");
        }

        _value = value;
    }
}