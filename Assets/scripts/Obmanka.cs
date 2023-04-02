using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.PlayerLoop;

public class Obmanka : MonoBehaviour
{
    public GameObject[] spheres;
    public Transform[] targetPositions;
    public float speed = 1.0f;

    public GameObject sphere;
    public float time;

    public float counter;
    bool razlet;

    public AudioSource AudioSource;
    public AudioClip pohvala;
    bool isplaying;
    bool ispohvalaplaying;

    public SaveDataToJson SaveDataToJson;
    public int num;
    private void Update()
    {
        if (razlet && counter != spheres.Length)
        {
            spheres[0].transform.position = Vector3.MoveTowards(spheres[0].transform.position, targetPositions[0].position, speed);
            spheres[1].transform.position = Vector3.MoveTowards(spheres[1].transform.position, targetPositions[1].position, speed);
            spheres[2].transform.position = Vector3.MoveTowards(spheres[2].transform.position, targetPositions[2].position, speed);
            time += Time.deltaTime;
            if (!isplaying)
            {
                AudioSource.Play();
                isplaying = true;
            }
        }
        else if (razlet && counter == spheres.Length && !ispohvalaplaying)
        {
            AudioSource.clip = pohvala;
            SaveDataToJson.crackens[num] = Mathf.Round(time).ToString();
            AudioSource.Play();
            ispohvalaplaying = true;

        }


    }


    

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hiter")
        {
            razlet = true;
            sphere.SetActive(false);
        }
    }
}
