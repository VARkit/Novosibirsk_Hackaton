using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLVL : MonoBehaviour
{
    public int index;
    public SaveDataToJson SaveDataToJson;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SaveDataToJson.SaveToJson();
            SceneManager.LoadScene(index);
        }
    }
}
