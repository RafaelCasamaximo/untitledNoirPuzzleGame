using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentManager : MonoBehaviour
{
    private static ContentManager _instance;

    public Character[] characters;


    public static ContentManager Instance{
        get{
            if(_instance == null){
                GameObject go = new GameObject("ContentManager");
                go.AddComponent<ContentManager>();
            }
            return _instance;
        }
    }

    void Awake(){
        _instance = this;
    }

    public void LoadCharacterDataFromJson(){
        JSONLoader jsonLoader = new JSONLoader("charactersData");
        characters = jsonLoader.Load();

    }


}
