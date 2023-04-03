using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class MishenColLVL0 : MonoBehaviour
{
    public GameObject spheres;
    public float time;
    public int counter;
    public bool go_counter;
    public int sph_cnt;
    public TextMeshProUGUI text;
    public AudioSource AudioSource;
    public AudioClip AudioClip;
    public AudioClip AudioClipEnd;
    public AudioClip CommandFire;
    public SaveDataToJson SaveDataToJson;
    Renderer Renderer;
    public bool plzdelete;
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "laser")
        {
        
            counter += 1;
            if(counter == 10)
            {
                StartCoroutine(firewait());
                counter = 11;
            }
            else if (counter <= 10)
            {
                Renderer.material.SetColor("_Color", new Color(Renderer.material.color.r, Renderer.material.color.g, Renderer.material.color.b, Renderer.material.color.a - 0.1f));
            }
        }
    }
    private void Start()
    {
        Renderer = GetComponent<Renderer>();
    }
    private void Update()
    {
        if (go_counter)
        {
            time += Time.deltaTime;
            text.text = "Время: " + Mathf.Round(time).ToString();
        }
        if(sph_cnt == 8)
        {
            go_counter = false;
            StartCoroutine(littlewait());
            sph_cnt = 9;
            SaveDataToJson.baloons = Mathf.Round(time).ToString();
        }
    }
    IEnumerator firewait()
    {
        AudioSource.clip = CommandFire;
        AudioSource.Play();
        yield return new WaitForSeconds(11);
        AudioSource.clip = AudioClip;
        AudioSource.Play();
        yield return new WaitForSeconds(1);
        spheres.SetActive(true);
        go_counter = true;

    }
    IEnumerator littlewait(){
        yield return new WaitForSeconds(0.5f);
        AudioSource.clip = AudioClipEnd;
        AudioSource.Play();
        gameObject.GetComponent<MeshCollider>().enabled = false;
    }
}
