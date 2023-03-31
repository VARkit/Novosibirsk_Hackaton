using UnityEngine;

public class LaserShooter : MonoBehaviour
{
    public GameObject laserPrefab; // префаб лазера
    public float laserSpeed = 0.001f; // скорость лазера

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // если нажата лева€ кнопка мыши
        {
            ShootLaser(); // вызываем функцию стрельбы
        }
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
