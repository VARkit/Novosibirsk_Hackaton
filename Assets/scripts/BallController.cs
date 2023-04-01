using UnityEngine;
using UnityEngine.Pool;
using TMPro;
using System;

public class BallController : MonoBehaviour
{
    public float size; // Размер шара
    public int weight; // Вес шара

    private float difference; // Разность между размером и весом шара
    private float colorValue; // Значение цвета шара

    private Renderer ballRenderer; // Компонент Renderer шара
    public float speed;
    public Transform point;
    public TMP_InputField inputField;
    bool transforming;
    void Start()
    {
        ballRenderer = GetComponent<Renderer>(); // Получаем компонент Renderer шара
    }

    public void Sumbit()
    {
        weight = Int32.Parse(inputField.text);
        transforming = true;
    }
    void Update()
    {   
        if(transforming)
        {   
            float dif2 = size - weight;
            if(dif2 > 100)
            {
                point.transform.localPosition = new Vector3(0, 5, 0);
            }
            else if(dif2 < -100)
            {
                point.transform.localPosition = new Vector3(0, -5, 0);
            }
            else
            {
                point.localPosition = new Vector3(0, -3 * dif2 / 100, 0);
            }
            gameObject.transform.position = Vector3.Lerp(transform.position, point.position, speed);
            difference = Mathf.Abs(size - weight); // Вычисляем модуль разности между размером и весом шара-
            print(dif2);
        
            // Если разность равна 50, устанавливаем зеленый цвет
            if (difference == 0)
            {
                ballRenderer.material.color = Color.green;
            }
            // Если разность меньше 50 и больше или равна 30, вычисляем промежуточное значение между зеленым и желтым цветом
            else if (difference > 0 && difference <= 20)
            {
                colorValue = Mathf.InverseLerp(0, 40, difference);
                ballRenderer.material.color = new Color(colorValue, 1 - colorValue, 0f);
            }
            // Если разность меньше 30 и больше или равна 10, вычисляем промежуточное значение между желтым и красным цветом
            else if (difference > 20 && difference <= 40)
            {
                colorValue = Mathf.InverseLerp(40, 20, difference);
                ballRenderer.material.color = new Color(1f, colorValue, 0f);
            }
            // Если разность меньше 10 и больше или равна 1, вычисляем промежуточное значение между красным и черным цветом
            else if (difference > 40 && difference <= 49)
            {
                colorValue = Mathf.InverseLerp(40, 50, difference);
                ballRenderer.material.color = new Color(1f, 1 - colorValue, colorValue);
            }
            // Если разность меньше 1, устанавливаем черный цвет
            else
            {
                ballRenderer.material.color = Color.black;
            }
        }
       
    }
}
