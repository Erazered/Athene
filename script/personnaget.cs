using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class personnaget : MonoBehaviour {
    


    // Start is called before the first frame update
    //variable
    private string name;
    public string surname="head";
    private int energy;
    bool shakra=true;
    float speed=2.9f;
    //table
    string[]sac={"chargeur","stylo","ordinateur"};
    int[]nombre={1,3,1};
    bool[]contenuiut={true,true,true};
    void Start() {
    

        name="erazer";
    Debug.Log(name);
     }

    // Update is called once per frame
    void Update() {    
    if(energy==100){
        Debug.Log("je suis plein");
    }
   Debug.Log(surname);    
    }
    void FixedUpdate() {
    if(name!="ballamard"){
        Debug.Log("je ne suis pas formateur");
    }
    if(energy<10){
        Debug.Log("je suis en danger");
    }    
    }void OnEnable() {
     if(energy>50){
        Debug.Log("j'ai plus de la moitier");
     }else{
        Debug.Log("made ekoti");
     } 
    }void Awake() {
     energy=100;   
    }
    void LateUpdate() {
    if(energy<=20){
        Debug.Log("je suis faible");
    }else if(energy>=50){
        Debug.Log("ca va");
    }else{
        Debug.Log("je peux continuer");
    }    
    }
    }

