using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class code : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string HeroName = "Mickey";
        float HeroHeight = 160.5f;
        int HeroAge = 100;
        string HeroSuperpower = "flying";
        string VillainName = "Anfal";
        float VillainHeight = 50.5f;
        int VillainAge = 200;
        string VillainSuperpower = "lies without getting caught";
        float AgeDifference = HeroAge - VillainAge;

        print(" The hero's name is" + HeroName);
        print(" The hero's age is" + HeroAge);
        print("The Hero's superpower is" + HeroSuperpower);
        print("The Villain's name is" + VillainName);
        print("The villain's age is" + VillainAge);
        print("The villain's height is" + VillainHeight);
        print("The villain's superpower is" + VillainSuperpower);
        print("the age difference is" + AgeDifference);

        HeroHeight = HeroHeight+5;
        VillainSuperpower = "None";

        print(" The hero's name is" + HeroName);
        print(" The hero's age is" + HeroAge);
        print("The Hero's superpower is" + HeroSuperpower);
        print("The Villain's name is" + VillainName);
        print("The villain's age is" + VillainAge);
        print("The villain's height is" + VillainHeight);
        print("The villain's superpower is" + VillainSuperpower);
        print("the age difference is" + AgeDifference);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
