﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuiltpleChoice : MonoBehaviour {

    public GameObject TextBox;
    public GameObject Choice01;
    public GameObject Choice02;
    public GameObject Choice03;
    public int ChoiceMade;

    public void ChoiceOption1 () {
        TextBox.GetComponent<Text>().text="THIS ONE WHILE MAKE YOUR LIFE GREAT!";
        ChoiceMade = 1;
    }

    public void ChoiceOption2() {
        TextBox.GetComponent<Text>().text="YOU PICK THE RIGHT ONE!";
        ChoiceMade = 2;
    }

    public void ChoiceOption3() {
        TextBox.GetComponent<Text>().text="I'M PRETTY SURE THE NEXT ONE WILL MAKE YOU PICK!";
        ChoiceMade = 3;
    }

    void Update() {
        if (ChoiceMade >= 1) {
            Choice01.SetActive(false);
            Choice02.SetActive(false);
            Choice03.SetActive(false);
        }
        
    }
}
