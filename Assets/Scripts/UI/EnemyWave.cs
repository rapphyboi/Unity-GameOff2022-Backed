using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyWave : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] Image fill;
    [SerializeField] float waveIncrementerInSeconds = 5f;
    public Slider Slider { get { return slider; } }

    // Start is called before the first frame update
    void Start()
    {
        slider.value = 0;
        StartCoroutine(WaveIncrease());
    }


    IEnumerator WaveIncrease()
    {
        while (true)
        {
            slider.value++;
            if (slider.value == 125f)
            {
                yield break;
            }
            yield return new WaitForSeconds(waveIncrementerInSeconds);
        }
    }
}
