using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{

    public int health = 5;

  //уровень NPC
    public int level = 1;

//скорость npc
    public float speed = 1.2f;


    // Start is called before the first frame update
    void Start() 
    {
        health += level;
        
    }

    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position=newPosition;
    }
}
