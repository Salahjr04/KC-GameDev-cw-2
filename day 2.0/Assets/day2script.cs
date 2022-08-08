using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class day2script : MonoBehaviour
{
    //heroThings 
    string heroname = "mousashi";
    float heroHeight = 1.75f;
    int heroAge = 23;
    string heroSuperPower = "Sword master";
    //VillainThings
    string villainName = "Naomori";
    float vililanHeight = 2.5f;
    int villainAge = 40;
    string villainSuperPower = "Samurai master";

    
    // Start is called before the first frame update
    void Start()
    {
        int ageDifference = villainAge - heroAge;
        print ("My name is " + heroname + " my currently age and hight is " + heroAge + heroHeight);
        print("have a super power and it is " + heroSuperPower);

        print  ("I And i am " + villainName + "my currently age and hight is  " + heroAge + heroHeight);
        print("I have a super power and it is " + villainSuperPower);
        print("The age difference between us is " + ageDifference);
    }

}
