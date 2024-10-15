using System;

class Damage : IState
{
    private readonly float _value;

    public float Value => _value;

    public Damage(float value)
    {
        if (value < 0)
        {
            throw new ArgumentException("공격력은 0보다 작을 수 없습니다.");
        }

        if (value > 999)
        {
            throw new SuspiciousPlayerException("공격력은 999보다 클 수 없습니다.");
        }

        _value = value;
    }
}