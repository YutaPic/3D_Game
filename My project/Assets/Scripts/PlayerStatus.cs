using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using System;


public class PlayerStatus : MonoBehaviour
{

    public int max_hp;
    public int hp;

    public Slider slider;
    public Text hp_text;
    public Text weapon_text;

    public enum State
    {
        Asteroid,
        Hound,
        Meteora
    }

    public State state = State.Asteroid;

    // Start is called before the first frame update
    void Start()
    {
        hp = max_hp;

        // UI
        slider.value = hp;
        hp_text.text = "HP: " + hp.ToString();
        weapon_text.text = "Weapon: " + state;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)){
            state = State.Asteroid;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2)){
            state = State.Hound;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3)){
            state = State.Meteora;
        }

        // UI
        slider.value = hp;
        hp_text.text = "HP: " + hp.ToString();
        weapon_text.text = "Weapon: " + state;
    }
    
}
