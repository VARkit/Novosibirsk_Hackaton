using UltimateXR.Avatar;
using UltimateXR.Core;
using UltimateXR.Devices;
using UnityEngine;

public class LaserShooter : MonoBehaviour
{
    public GameObject laserPrefab; // префаб лазера
    public float laserSpeed = 0.001f; // скорость лазера
    bool wasPressed;
    void Update()
    {
        if (wasPressed) // если нажата лева€ кнопка мыши
        {
            ShootLaser(); // вызываем функцию стрельбы
        }
        wasPressed = UxrAvatar.LocalAvatarInput.GetButtonsPressDown(UxrHandSide.Right, UxrInputButtons.Trigger);
    }

    void ShootLaser()
    {
        // создаем экземпл€р лазера из префабаa
        GameObject laser = Instantiate(laserPrefab, transform.position, transform.rotation);

        // задаем скорость лазера
        Rigidbody laserRigidbody = laser.GetComponent<Rigidbody>();
        laserRigidbody.velocity = transform.up * laserSpeed;
    }
}
