using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HitRed : MonoBehaviour {
    
    [SerializeField]
    private TextMeshProUGUI Text;

  // 当たった時に呼ばれる関数
    void OnCollisionEnter(Collision collision)
    {
      	Data.Instance.score++;
        Debug.Log("HitRed"); // ログを表示する
        Text.text = "HitRed: "+Data.Instance.score+"times";

        // Destroy(this.gameObject,1f);
        // StartCoroutine(MatoAppear());
    }

      private IEnumerator MatoAppear()
     {
        yield return new WaitForSeconds(1.0f);
        Instantiate (this.gameObject, new Vector3(4.332f,0f,0f), Quaternion.identity);
     }
}