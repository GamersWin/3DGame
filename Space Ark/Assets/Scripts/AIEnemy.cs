using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIEnemy : MonoBehaviour
{
    public float speed = 1.0f; //скорость врага
    public float damage = 1.0f; //урон, наносимый персонажу
    public float maxDistance = 10.0f; //максимальная дистанция обнаружения героя
    public float minDistance = 1.0f;

    public float distance; //переменная для опр – я дистанции между игроком и врагом
    public Transform target; //объект, за которым будет следить враг

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, target.position); //определяем дистанцию
        if (distance > maxDistance)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);//непрерывно движемся вперед в каждом кадре
        }
        if (distance < maxDistance && distance > minDistance)
        {
            transform.rotation = Quaternion.Slerp(transform.localRotation, Quaternion.LookRotation(target.position - transform.position), speed * Time.deltaTime);
            transform.position = Vector3.Lerp(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}
