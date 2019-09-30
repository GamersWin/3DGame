using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public int damage = 2; //переменная наносимого урона
    public float range = 50.0f; // переменная дальности луча
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //блокируем курсор мыши
        Cursor.visible = false; //скрываем курсор мыши
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {//нажимаем на левую кнопку мыши
            Vector3 point = new Vector3(cam.pixelWidth / 2, cam.pixelHeight / 2, 0);
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(point); //создание луча методом ScreenPointToRay().
            if (Physics.Raycast(ray, out hit, range))
            {
                Debug.Log(hit.transform.name); // выводим имя объекта, в который попадает луч
                Strength objectVase = hit.transform.GetComponent<Strength>();
                if(objectVase != null)
                {
                    objectVase.Damage(damage);
                }
            }
        }
    }

    private void OnGUI()
    {
        float posX = cam.pixelWidth / 2;
        float posY = cam.pixelHeight / 2;
        GUI.Label(new Rect(posX, posY, 12, 12), "*"); //команда GUI.Label() отображает символ *
    }
}
