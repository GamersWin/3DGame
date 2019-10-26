using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string itemName;


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Item collected: " + itemName); // вывод взятого объекта в консоль
        Destroy(this.gameObject);
        if (itemName == "cube")
        {//проверяем, является ли объект здоровьем
            PlayerCharacter player = other.GetComponent<PlayerCharacter>();
            if (player != null)
            {//проверяем, является ли объект PlayerCharacter
                player.ChangeHealth(250);
            }
        }

    }

}
