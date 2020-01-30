using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan6 : MonoBehaviour
{

    int[] intArray;//Deklarasikan array terlebih dahulu

    // Start is called before the first frame update
    void Start()
    {
        intArray = new int[4];//inisialisasi Array
        intArray[0] = 10;//Memasukkan Nilai Array
        intArray[1] = 20;        
        intArray[2] = 30;
        intArray[3] = 40;

        Debug.Log("Menampilkan Semua Array");
        foreach (int a in intArray) {
            Debug.Log(a);
        }
        Debug.Log("Nilai Index ke dua adalah" + intArray[2]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
