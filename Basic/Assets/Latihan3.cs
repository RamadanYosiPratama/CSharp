using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int c = jumlah(50, 50);
        Debug.Log("Hasil dari A + B adlah:" + c);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int jumlah(int a, int b){
        return a + b;
    }
}
