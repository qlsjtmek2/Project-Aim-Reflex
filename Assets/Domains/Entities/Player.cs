using Reflex.Attributes;
using UnityEngine;

public interface IObjectController
{

}

public interface IWeapon
{

}

public interface IGun : IWeapon
{
    int BulletCount { get; }
}

public interface IEntity
{
}

public interface IAttacker
{
    void Attack(IEntity other);
}

public interface IAttackable
{
    void TakeDamage(IEntity other);
}

public class Player : MonoBehaviour, IEntity, IMoveable, IJumpable, ICrouchable, ISprintable, IAttacker, IAttackable
{
    [Inject]
    public IState MaxHealth { get; private set; }

    [Inject]
    public IState Damage { get; private set; }

    [Inject]
    public IState Defense { get; private set; }

    [Inject]
    public IState AttackSpeed { get; private set; }

    [Inject]
    public IState JumpPower { get; private set; }

    [Inject]
    public IState MoveSpeed { get; private set; }

    public IWeapon CurrentWeapon { get; private set; }

    public IWeapon SwapWeapon(IWeapon newWeapon)
    {
        IWeapon prevWeapon = CurrentWeapon;
        CurrentWeapon = newWeapon;
        return prevWeapon;
    }

    public int Bullet
    {
        get
        {
            if (CurrentWeapon is IGun gun)
            {
                return gun.BulletCount;
            }

            return 0;
        }
    }

    [Inject]
    private readonly IObjectController _objectController;

    // [Inject]
    // private readonly IAnimationController _animationController;

    public void Crouch()
    {
        throw new System.NotImplementedException();
    }

    public void Jump()
    {
        throw new System.NotImplementedException();
    }

    public void Land()
    {
        throw new System.NotImplementedException();
    }

    public void Move(Vector3 position)
    {
        throw new System.NotImplementedException();
    }

    public void StandUp()
    {
        throw new System.NotImplementedException();
    }

    public void StartRunning()
    {
        throw new System.NotImplementedException();
    }

    public void StopRunning()
    {
        throw new System.NotImplementedException();
    }
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Attack(IEntity other)
    {
        if (other is IAttackable attackable)
        {
            float damageAmount = Damage.Value;
            attackable.TakeDamage(this); // 공격
            // Debug.Log($"Attacked {other}, dealt {damageAmount} damage.");
        }
    }

    public void TakeDamage(IEntity other)
    {
        float damageAmount = other is Player player ? player.Damage.Value : 0;
        float actualDamage = Mathf.Max(0, damageAmount - Defense.Value); // 방어력 적용
        // MaxHealth.Reduce(actualDamage); // 가정: MaxHealth는 줄어들 수 있는 상태
        // Debug.Log($"Took {actualDamage} damage from {other}. Remaining health: {MaxHealth.GetValue()}");
    }
}
