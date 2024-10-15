using System;

class Health : IState
{
    private readonly float _value;

    public float Value => _value;

    public Health(float value)
    {
        if (value < 0)
        {
            throw new ArgumentException("체력은 0보다 작을 수 없습니다.");
        }

        if (value > 9999)
        {
            throw new SuspiciousPlayerException("체력은 9999보다 클 수 없습니다.");
        }

        _value = value;
    }
}