using UnityEngine;
using System.IO;
using Newtonsoft.Json;
using UltimateXR.Mechanics.Weapons;

public class SaveDataToJson : MonoBehaviour
{
    public int mark;
    public string Name;
    public string Gender;
    public int age;
    public string baloons;
    public string[] normals;
    public string[] crackens;
    public int sceneIndex;
    public void SaveToJson()
    {
        // Создаем объект, который будет содержать наши данные
        
        // Преобразуем данные в формат JSON


        // Записываем данные в файл
        if(sceneIndex == 0)
        {
            string filePath = Application.dataPath + "/1STLVL.json";
            var LVL1DATA = new SaveData
            {
                age = "Возраст испытуемого: " + age.ToString(),
                Name = "ФИО испытуемого: " + Name,
                Mark = "Оценка по математике испытуемого: " + mark.ToString(),
                Gender = "Пол испытуемого: " + Gender,
                baloons = "время за которое были сбиты8 шаров: " + baloons.ToString(),
            };
            string jsonData = JsonConvert.SerializeObject(LVL1DATA,  Formatting.Indented);
            File.WriteAllText(filePath, jsonData);
        }
        else if (sceneIndex == 1)
        {
            string filePath = Application.dataPath + "/2NdLVL.json";
            var LVL2DATA = new LVL2DATA
            {
                b1 = "Разницы масс участника под номером 1): " + normals[0],
                b2 = "Разницы масс участника под номером 2): " + normals[1],
                b3 = "Разницы масс участника под номером 3): " + normals[2],
                b4 = "Разницы масс участника под номером 4): " + normals[3],
                b5 = "Разницы масс участника под номером 5): " + normals[4],
                b6 = "Разницы масс участника под номером 6): " + normals[5],
                b7 = "Разницы масс участника под номером 7): " + normals[6],
                b8 = "Разницы масс участника под номером 8): " + normals[7],
                b9 = "Разницы масс участника под номером 9): " + normals[8],
                b10 = "Разницы масс участника под номером 10): " + normals[9],

                bFalse1 = "Время сбития шаров из обманки под норером 1: " + crackens[0],
                bFalse2 = "Время сбития шаров из обманки под норером 2: " + crackens[1],
                bFalse3 = "Время сбития шаров из обманки под норером 3: " + crackens[2],
                bFalse4 = "Время сбития шаров из обманки под норером 4: " + crackens[3],
                bFalse5 = "Время сбития шаров из обманки под норером 5: " + crackens[4],

            };
            string LVL2 = JsonConvert.SerializeObject(LVL2DATA, Formatting.Indented);
            File.WriteAllText(filePath, LVL2);
        }
        
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