using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;
using System;
[Serializable]


public class Country
    {
        public List<string> country;
    }
       
       
        [Serializable]
public class Hero
    
    
    {
        public int id ;
        public string name ;
        public int level ;
        public int heroClassIndex ;
        public string heroClassName ;
        public int gold ;
    }
        [Serializable]
         public class Player

    {
        public int id ;
        public string name ;
        public string email ;
        public string username ;
        public int points ;
        public int platformIndex ;
        public string platformName ;
        public int countryIndex ;
        public string countryName ;
        public List<Hero> heroes ;
        
       
        public string playertostring()
        {
            string result = "";
            result += $"nome {name} ";
            result += $"email {email} ";
            result += $"username {username}";
            result += $"points {points}";
            result += $"platformIndex {platformIndex} ";
            result += $"platformName {platformName}";
            result += $"countryIndex {countryIndex} ";
            result += $"countryName {countryName}";
            result += $"heroes {heroes}";
            return result;
        
        }
         


    }
     public class Root 
 {
     public   List <Player> players = new List <Player>();
        public  List <Player> load()
        
        {
             string path = "/Resources/raguze.json";
            var content = File.ReadAllText(Application.dataPath + path);
            //List<Player> p = new List<Player>();
            //p = JsonUtility.FromJson<List<Player>>(content);
           JsonUtility.FromJsonOverwrite(content,this);

            Debug.Log (players.Count);
            Debug.Log (JsonUtility.ToJson(this,true));
        
            return players;
         }
       
         }

        public class LCountry
{
           public  Country country = new Country();  
        public Country LoadCountry()

        {
            string path = "/Resources/paises.json";
            var content = File.ReadAllText(Application.dataPath + path);
             JsonUtility.FromJsonOverwrite(content,this);
            return country;
        }



}
