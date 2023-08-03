using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sample : MonoBehaviour
{
    public Text platformText;
    // Start is called before the first frame update

    void Start()
    {
        StartCoroutine(StartSample());
    }

    private IEnumerator StartSample()
    {
        yield return new WaitForSeconds(1f);

        platformText.text = "Platform: " + PlatformDetector.Platform().ToString();
    }
}
