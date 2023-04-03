using System.Collections;
using UnityEngine;
using TMPro;

public class DoorScript : MonoBehaviour
{
    public string code = "78114"; // Код замка
    private string inputCode = ""; // Введенный пользователем код
    public GameObject door;
    public AudioSource dver;
    AudioClip TryAgain;
    public bool Start;
    float time;
    bool predupr;
    public SaveDataToJson SaveDataToJson;
    public TextMeshProUGUI TextMeshProUGUI;
    // Функция проверки кода замка
    private void CheckCode()
    {
        if (inputCode == code)
        {
            TextMeshProUGUI.text = "Код верный!";
            gameObject.SetActive(false);
            SaveDataToJson.SaveToJson();
        }
        else
        {
            StartCoroutine(Wrong());
            SaveDataToJson.SaveToJson();
        }
    }

    // Функция обработки ввода с клавиатуры
    public void InputCode(string digit)
    {
        // Добавить цифру в введенный код
        inputCode += digit;

        // Проверить код, если он полностью введен
        if (inputCode.Length == code.Length)
        {
            CheckCode();
        }
    }

    IEnumerator Wrong()
    {
        TextMeshProUGUI.text = "Неправильно!";
        yield return new WaitForSeconds(1);
        inputCode = ""; // Сбросить введенный код
    }
    private void OnCollisionEnter(Collision collision)
    {
        Start = true;
    }

    private void Update()
    {
        if(Start)
        {
            time += Time.deltaTime;
            if(time >= 15 && time <= 40)
            {
                if(!predupr)
                {
                    predupr = true;
                    dver.Play();
                }
            }
            if (time >= 40)
            {
                Application.Quit();
            }
        }
    }
}