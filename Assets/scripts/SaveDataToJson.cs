using UnityEngine;
using System.IO;
using Newtonsoft.Json;

public class SaveDataToJson : MonoBehaviour
{
    public int mark;
    public string Name;
    public string Gender;
    public int age;
    public string baloons;
    public void SaveToJson()
    {
        // Создаем объект, который будет содержать наши данные
        var LVL1DATA = new SaveData
        {
            age = "Возраст испытуемого: " + age.ToString(),
            Name = "ФИО испытуемого: " + Name,
            Mark = "Оценка по математике испытуемого: " + mark.ToString(),
            Gender = "Пол испытуемого: " + Gender,
            baloons = "время за которое были сбиты8 шаров: " + baloons.ToString(),
        };
        var LVL2DATA = new LVL2DATA
        {

        };
        // Преобразуем данные в формат JSON
        string jsonData = JsonConvert.SerializeObject(LVL1DATA,  Formatting.Indented);

        // Записываем данные в файл
        string filePath = Application.streamingAssetsPath + "/1STLVL.json";
        File.WriteAllText(filePath, jsonData);
    }
    private void Start()
    {
        SaveToJson();
    }
    private class SaveData
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Mark { get; set; }
        public string age { get; set; }
        public string baloons { get; set; }

    }
    private class LVL2DATA
    {
        public string b1 { get; set; }
        public string b2 { get; set; }
        public string b3 { get; set; }
        public string b4 { get; set; }
        public string b5 { get; set; }
        public string b6 { get; set; }
        public string b7 { get; set; }
        public string b8 { get; set; }
        public string b9 { get; set; }
        public string b10 { get; set; }
        public string bFalse1 { get; set; }
        public string bFalse2 { get; set; }
        public string bFalse3 { get; set; }
        public string bFalse4 { get; set; }
        public string bFalse5 { get; set; }
    }
}