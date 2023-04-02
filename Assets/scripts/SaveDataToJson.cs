using UnityEngine;
using System.IO;
using Newtonsoft.Json;
using UltimateXR.Mechanics.Weapons;

public class SaveDataToJson : MonoBehaviour
{
    public int maark;
    public string Name;
    public string Gender;
    public int age;
    public string baloons;
    public string[] normals;
    public string[] crackens;
    public string[] Zapom;
    public int sceneIndex;
    public void SaveToJson()
    {
        // Создаем объект, который будет содержать наши данные
        
        // Преобразуем данные в формат JSON


        // Записываем данные в файл
        if(sceneIndex == 1)
        {
            string filePath = Application.dataPath + "/1STLVL.json";
            var LVL1DATA = new SaveData
            {
                age = "Возраст испытуемого: " + age.ToString(),
                Name = "ФИО испытуемого: " + Name,
                Mark = "Оценка по математике испытуемого: " + maark.ToString(),
                Gender = "Пол испытуемого: " + Gender,
                baloons = "время за которое были сбитых шаров: " + baloons.ToString(),
            };
            string jsonData = JsonConvert.SerializeObject(LVL1DATA,  Formatting.Indented);
            File.WriteAllText(filePath, jsonData);
        }
        else if (sceneIndex == 2)
        {
            string filePath = Application.dataPath + "/2NdLVL.json";
            var LVL2DATA = new LVL2DATA
            {
                b1 = "Разницы масс участника под номером 1 (справа налево): " + normals[0],
                b2 = "Разницы масс участника под номером 2 (справа налево): " + normals[1],
                b3 = "Разницы масс участника под номером 3 (справа налево): " + normals[2],
                b4 = "Разницы масс участника под номером 4 (справа налево): " + normals[3],
                b5 = "Разницы масс участника под номером 5 (справа налево): " + normals[4],
                b6 = "Разницы масс участника под номером 6 (справа налево): " + normals[5],
                b7 = "Разницы масс участника под номером 7 (справа налево): " + normals[6],
                b8 = "Разницы масс участника под номером 8 (справа налево): " + normals[7],
                b9 = "Разницы масс участника под номером 9 (справа налево): " + normals[8],
                b10 = "Разницы масс участника под номером 10 (справа налево): " + normals[9],

                bFalse1 = "Время сбития шаров из обманки под норером 1: " + crackens[0],
                bFalse2 = "Время сбития шаров из обманки под норером 2: " + crackens[1],
                bFalse3 = "Время сбития шаров из обманки под норером 3: " + crackens[2],
                bFalse4 = "Время сбития шаров из обманки под норером 4: " + crackens[3],
                bFalse5 = "Время сбития шаров из обманки под норером 5: " + crackens[4],

            };
            string LVL2 = JsonConvert.SerializeObject(LVL2DATA, Formatting.Indented);
            File.WriteAllText(filePath, LVL2);
        }
        else if(sceneIndex == 3)
        {
            string filePath = Application.dataPath + "/3RDLVL.json";
            var LVL3DATA = new LVL3DATA
            {
                m1 = Zapom[0],
                m2 = Zapom[1],
                m3 = Zapom[2],
                m4 = Zapom[3],
                m5 = Zapom[4],
                m6 = Zapom[5],
                m7 = Zapom[6],
                m8 = Zapom[7],
                m9 = Zapom[8],
            };
            string LVL3 = JsonConvert.SerializeObject(LVL3DATA, Formatting.Indented);
            File.WriteAllText(filePath, LVL3);
        }
        
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

    private class LVL3DATA
    {
        public string m1 { get; set; }
        public string m2 { get; set; }
        public string m3 { get; set; }
        public string m4 { get; set; }
        public string m5 { get; set; }
        public string m6 { get; set; } 
        public string m7 { get; set; }
        public string m8 { get; set; }
        public string m9 { get; set; }


    }
}