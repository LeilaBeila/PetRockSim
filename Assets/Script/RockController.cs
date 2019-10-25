using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockController : MonoBehaviour
{
  public string RockName = "Gooby";
  public float hunger = 100f;
  public float friendship = 100f;
  public bool IsSick = false;

    float hungerScale = 2f;
    float friendScale = 2f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(RockName);  
    }

    // Update is called once per frame
    void Update()
    {
        StatusUpdate();
        IsDead();
        //Debug.Log(hunger);
    }

    void StatusUpdate()
    {
        hunger -= Time.deltaTime * hungerScale;
        friendship -= Time.deltaTime * friendScale;

        int SickChance = Random.Range(0, 500);
        if (SickChance == 1)
        {
            IsSick = true;
            hungerScale = 5f;
            friendScale = 5f;
        }

        if (IsSick == false)
        {
            hungerScale = 2f;
            friendScale = 2f;
        }
        else
        {
            hungerScale = 5f;
            friendScale = 5f;
        }

        
    }
    void IsDead()
    {
        if (hunger <= 0)
        {
            Destroy(gameObject);
        }
        else if (friendship <= 0)
        {
            Destroy(gameObject);
        }
    }

}
