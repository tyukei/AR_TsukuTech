using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToutorialContoroller : MonoBehaviour
{
    [SerializeField] private float waitTime = 3f;
    [SerializeField] private GameObject tutorialObject;
    private void Start()
    {
        // コルーチンの起動
        StartCoroutine(DelayCoroutine());
    }

    // コルーチン本体
    private IEnumerator DelayCoroutine()
    {
        tutorialObject.SetActive(true);

        // 3秒間待つ
        yield return new WaitForSeconds(waitTime);

        // 3秒後に原点にワープ
        tutorialObject.SetActive(false);
    }
}
