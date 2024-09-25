using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{

    [SerializeField]
    private float speed;
    [SerializeField]
    private float hp;
    // Start is called before the first frame update
    void Start()
    {
        speed = 10;
        hp =100;
    }

    // Update is called once per frame
    void Update()
    {
        print($"hp :{hp}");
        print($"speed : {speed}");
    }
}
