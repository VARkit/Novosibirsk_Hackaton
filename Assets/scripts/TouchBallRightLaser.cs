using UltimateXR.Avatar;
using UltimateXR.Core;
using UltimateXR.Devices;
using UnityEngine;
using TMPro;
public class TouchBallRightLaser : MonoBehaviour
{
    public GameObject canv;
    public RightBallHelper RightBallHelper;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hiter")
        {
            canv.SetActive(true);
            if(RightBallHelper.prevcanv != canv && RightBallHelper.prevcanv != null)
            {
                RightBallHelper.prevcanv.SetActive(false);  
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Hiter")
        {
            RightBallHelper.prevcanv = canv;
        }
    }
}
