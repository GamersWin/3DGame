using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AIEnemy : MonoBehaviour
{
    public float speed = 1.0f; //скорость врага
    public int damage = 5; //урон, наносимый персонажу
    public float maxDistance = 10.0f; //максимальная дистанция обнаружения героя
    public float minDistance = 1.0f;

    public Text text;

    public float distance; //переменная для опр – я дистанции между игроком и врагом
    public Transform target; //объект, за которым будет следить враг
    private bool _alive;

    public PlayerCharacter player;

    private void Start()
    {
        text.text = "Hello" + damage;
        _alive = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (_alive)
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
            if (distance < minDistance)
            {
                player.Hurt(damage);
            }
        }
    }

    public void SetActive(bool alive)
    {
        _alive = alive;
    }

}
