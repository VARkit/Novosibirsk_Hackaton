using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MishenColLVL0 : MonoBehaviour
{
    public GameObject spheres;
    public float time;
    public int counter;
    public bool go_counter;
    public int sph_cnt;
    public TextMeshProUGUI text;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "laser")
        {
            counter += 1;
            if(counter == 10)
            {
                spheres.SetActive(true);
            }
        }
    }
    private void Update()
    {
        if(go_counter)
        {
            time += Time.deltaTime;
            text.text = time.ToString();
        }
        if(sph_cnt == 8)
        {
            go_counter = false;
        }
    }
}
