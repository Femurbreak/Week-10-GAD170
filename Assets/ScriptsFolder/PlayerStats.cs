using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public HPBar hpBar;
    float hpValue = 100f;
    float hpMax = 100f;

    public bool poisoned = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(poisoned == true)
        {
            takeDamage(0.05f);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            hpValue -= 20f;
            hpBar.SetValue(hpValue);
        }
    }void takeDamage(float damage)
    {
        hpValue -= damage;
        hpBar.SetValue(hpValue);
    }

    void heal(float healing)
    {
        hpValue += healing;
        hpBar.SetValue(hpValue);
    }
}
