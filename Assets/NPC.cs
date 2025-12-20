using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //здоровье NPC
    int health = 5;

    //уровень NPC
    int level = 1;

    // cкорость NPC
    float speed = 1.2f;
    // Start is called before the first frame update
    void Start()
    {
        health += level;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
