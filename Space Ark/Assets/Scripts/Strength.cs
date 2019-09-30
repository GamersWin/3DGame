using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strength : MonoBehaviour
{
    public int health = 10; //значение прочности предмета
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage(int value)
    {
        health -= value;
        if(health <= 0)
        {// если прочность предмета меньше 0
            Destroy(gameObject); // уничтожаем объект методом Destroy()
        }
    }
}
