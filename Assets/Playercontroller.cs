using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;
using UnityEngine.UI;
[Serializable]
public class Playercontroller : MonoBehaviour


{

    public Country country;
    public List <Player> player;
    public GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        Root r = new Root();
        player = r.load();
       Debug.Log (player.Count);
       LCountry c = new LCountry();
       country = c.LoadCountry();
       text.GetComponent<Text>().text = "";

    }


   public void PlayerDescendent()
   {
      text.GetComponent<Text>().text = "";
      
       Debug.Log("achou");
       

       var result =  player.OrderByDescending(p => p.points).Take(3);
        foreach (var l in  result)
        {
            text.GetComponent<Text>().text += l.name  + " " + l.points + "\n";
             //FUNCIONA
        }
  }

 public void PLayerCountry ()
   {
     text.GetComponent<Text>().text = "";
     
       Debug.Log("achou");
   //var result = country.GroupBy(co => co).Where(p => !GroupBy(player.country).Contains(i.country));
     
     var result = player.OrderBy(c => c.countryName)
     .Where(p=>p.heroes.Count<=0);//pega\r a quantidade na list
     foreach (var l in result)  
   {
       text.GetComponent<Text>().text += l.countryName + " \n";
    }
              //FUNCIONA
   }


 public void PlayerHero ()
   {
       text.GetComponent<Text>().text = "";
    //   
    //   Debug.Log("achou");
    // // var result = player.GroupBy(p => p.heroes.).Where(g => g.Count()). Select(g => g.Key);
   // //  var result  = player.GroupBy(p => heroes ).select(group => new{heroes = group.Key, Count = group.Count() }).OrdeBayDescending(x => x.Count).First();
   // // {
   // //   text.GetComponent<Text>().text += result.heroes+ " \n";
   // }

     // TA DANDO ERRINHO BASICO
        

    }


     public void MostPLayerCountry()
   {
       text.GetComponent<Text>().text = "";
       
       Debug.Log("achou");
       text.GetComponent<Text>().text = "";

        //var result = player.GroupBy(p => p.countryName).Where(g => g.Count()).Select(g => g.Key);                          
          var result = player.GroupBy(p => p.countryName).Select(group => new { 
            country = group.Key,
            Count = group.Count () } ).OrderByDescending(x => x.Count).First();
            
 {
       text.GetComponent<Text>().text += result.country + " \n";
    }
 }  //FUNCIONA
   
   
    public void Platafom()
   {
     

     text.GetComponent<Text>().text = "";
     
       Debug.Log("achou");
       text.GetComponent<Text>().text = "pokebola";

   }

 public void PlayerTopGold()
   {
     text.GetComponent<Text>().text = "";
     
       Debug.Log("achou");
       text.GetComponent<Text>().text = "capturar";

   }



 


}



