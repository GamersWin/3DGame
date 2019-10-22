using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieEnemy : MonoBehaviour
{

    public void ReactToHit()
    {
        AIEnemy behaviour = GetComponent<AIEnemy>();
        if(behaviour != null)
        {
            behaviour.SetActive(false);
        }
        StartCoroutine(Die());
    }

    private IEnumerator Die()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
        yield return new WaitForSeconds(1.5f);
        Destroy(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
