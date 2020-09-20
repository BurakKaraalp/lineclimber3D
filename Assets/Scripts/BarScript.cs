using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarScript : MonoBehaviour
{
    public GameObject bar;
    Color32 lerpedColor = Color.white;
    Color32 white32 = Color.white;
    Color32 black32 = new Color32(14,154,167,255);
    void Update()
    {
        float value = Synchronize();
        lerpedColor = Color32.Lerp(white32, black32, value);
        bar.gameObject.GetComponent<Image>().fillAmount = value;
        bar.gameObject.GetComponent<Image>().color = lerpedColor;
        
        
    }
    public float Synchronize()
    {
        float[] stats = GetComponent<Follow>().CallPathInt();
        float value = stats[0]/stats[1];
        return value;
    }
}
