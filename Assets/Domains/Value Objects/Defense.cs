using System;

class Defense : IState
{
    private readonly float _value;

    public float Value => _value;

    public Defense(float value)
    {
        if (value < 0)
        {
            throw new ArgumentException("방어력은 0보다 작을 수 없습니다.");
        }

        if (value > 999)
        {
            throw new SuspiciousPlayerException("방어력은 999보다 클 수 없습니다.");
        }

        _value = value;
    }
}