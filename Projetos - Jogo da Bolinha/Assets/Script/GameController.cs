using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
    public TMP_Text textCount;
    public static int count;

    public ParticleSystem ps;

    void Update()
    {
        textCount.text = count.ToString();

        
    }
}
