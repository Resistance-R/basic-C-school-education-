using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    void Start()
    {
        //플레이어 관련 변수
        int lev = 1;
        float exp = 1.1f;
        string name = "asdf";
        bool isDead = false;

        Debug.Log(lev);
        Debug.Log(exp);
        Debug.Log(name);
        Debug.Log(isDead);

        //배열
        string[] enemy = {"slime", "Demon", "madman"};

    Debug.Log(enemy[0]);
    Debug.Log(enemy[1]);
    Debug.Log(enemy[2]);       

    List<string> items = new List<string>();
    items.Add("BuckShot");
    items.Add("Slug");

    Debug.Log(items[0]);
    Debug.Log(items[1]);
            
    items.RemoveAt(0);
    Debug.Log(items[0]);

   Debug.Log(lev * exp);

   if (lev == 2)
   {
    Debug.Log("u can enter");
   }

   else if(lev == 1)
   {
    Debug.Log("nooooob!");
   }

   else
   {
    Debug.Log("U cant go here");
   }

 float hp = 100f;

  for(int count = 0; count < 10; count++)
  {
    hp++;
    Debug.Log("healing"+ " " + hp);
  }

  while (hp > 0)
  {
    hp--;
    Debug.Log("hit!" + " " + hp);
  }
   
}
}