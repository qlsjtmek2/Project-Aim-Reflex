using System;

class AttackSpeed : IState
{
    private readonly float _value;

    public float Value => _value;


    public AttackSpeed(float value)
    {
        if (value < 0)
        {
            throw new ArgumentException("공격속도는 0보다 작을 수 없습니다.");
        }

        if (value > 999)
        {
            throw new SuspiciousPlayerException("공격속도는 999보다 클 수 없습니다.");
        }

        _value = value;
    }
}