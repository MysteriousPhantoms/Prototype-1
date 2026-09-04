using UnityEngine;
using UnityEngine.InputSystem; // NEW INPUT SYSTEM

public class PlayerGunRotation : MonoBehaviour
{
    public Transform gunPivot;
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 12f;

    void Update()
    {
        RotateGunTowardMouse();

        if (Mouse.current.leftButton.wasPressedThisFrame)
            Shoot();
    }

    void RotateGunTowardMouse()
    {
        Vector3 mousePos = Mouse.current.position.ReadValue();
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        Vector2 direction = mousePos - gunPivot.position;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        gunPivot.rotation = Quaternion.Euler(0, 0, angle);
    }

    void Shoot()
    {
        GameObject b = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = b.GetComponent<Rigidbody2D>();
        rb.linearVelocity = firePoint.right * bulletSpeed;
    }
}
