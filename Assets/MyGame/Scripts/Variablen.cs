using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Himmelsrichtungen
{
    Nord,
    Sued,
    West,
    Ost
}

public class Variablen : MonoBehaviour
{
    Color farbe;
    int anzTueren;
    int food;
    int bird;
    bool fahren;
    string name;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Himmelsrichtungen.Nord + "" + Himmelsrichtungen.Sued + "" + Himmelsrichtungen.West + "" + Himmelsrichtungen.Ost);

        //Beispiel 1
        name = "meow";
        Debug.Log("Hallo" + name);

        //Beispiel 2
        anzTueren = 6;
        food = 9;
        bird = 2;
        Debug.Log(anzTueren + food  + bird);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
