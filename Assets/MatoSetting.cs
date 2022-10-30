using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatoSetting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //generate mato
        Instantiate (this.gameObject, new Vector3(10f,0f,10f), Quaternion.identity);
        Instantiate (this.gameObject, new Vector3(0f,0f,10f), Quaternion.identity);
        Instantiate (this.gameObject, new Vector3(-10f,0f,10f), Quaternion.identity);
    }
}
