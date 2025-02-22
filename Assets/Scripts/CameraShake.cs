﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public IEnumerator Shake (float duration, float magnitude)
    {
        if(Time.timeScale == 1) {
            Vector3 originalPos = transform.localPosition;

            float elapsed = 0f;

            while (elapsed < duration)
            {
                float x = Random.Range(-1, 1f) * magnitude;
                float z = Random.Range(-1, 1f) * magnitude;

                transform.localPosition = new Vector3(x, originalPos.y, originalPos.z);

                elapsed += Time.deltaTime;

                yield return null;
            }

            transform.localPosition = originalPos;
        }
        
    }
}
