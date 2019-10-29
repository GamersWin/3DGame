using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //библиотека для работы со сценами
using UnityEngine.UI;

public class PlayerCharacter : MonoBehaviour
{
    private int _health = 500;
    private int maxHealth = 1000;
    public Slider slider;

    public void Hurt(int damage)
    {
        _health -= damage;//уменьшение здоровья игрока
        slider.value = _health;
        if (_health <= 0)
        {
            SceneManager.LoadScene("SampleScene");//Перезагрузить сцену SamleScene
        }
        Debug.Log("Health: " + _health);
    }

    public void ChangeHealth(int value)
    {
        _health += value;
        slider.value = _health;
        if (_health > maxHealth)
        {
            _health = maxHealth;
        }
        Debug.Log(_health + "/" + maxHealth);
    }
}
