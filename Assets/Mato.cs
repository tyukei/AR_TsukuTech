using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Mato : MonoBehaviour
{
    [SerializeField] GameObject explosionPrefab;
    [SerializeField] private TextMeshProUGUI Text;
    [SerializeField] AudioClip se;

    void OnCollisionEnter(Collision collision){
        Debug.Log(collision.gameObject.name); // ぶつかった相手の名前を取得
        if(collision.gameObject.name == "Bullet(Clone)"){
            Instantiate (explosionPrefab, transform.position, Quaternion.identity);
            AudioSource.PlayClipAtPoint(se, transform.position);
            Data.Instance.score++;
            Text.text = "Hit: "+Data.Instance.score+"times";
        }else{
            Debug.Log("Hit other");
        }
    }
}

