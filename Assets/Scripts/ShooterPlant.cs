using UnityEngine;

public class ShooterPlant : Plant
{
    [SerializeField, Tooltip("")]
    private Bullet bulletPref;
    [SerializeField, Tooltip("Set the direction that the bullet is going.")]
    private Vector2 direction;
    
    protected override void ActivateAbility()
    {
        ShootBullet();
    }

    public void ShootBullet()
    {
        if (bulletPref == null) return;
        
        Bullet bullet = Instantiate(bulletPref, transform.position, transform.rotation);

        bullet.UpdateDirection(Vector2.left);
    }
}