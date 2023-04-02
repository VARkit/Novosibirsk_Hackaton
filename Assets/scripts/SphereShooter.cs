using UnityEngine;

public class SphereShooter : MonoBehaviour
{
    public GameObject spherePrefab; // префаб сферы
    Animator animator;
    public string trigger;
    public Zapominanie Zapominanie;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void StartAnim()
    {
        animator.SetTrigger(trigger);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "MainCamera")
        {
            Zapominanie.FullVvod += " Не увернулся";
        }
    }
}