using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えたッッ");

    }
    public void Defence(int damege)
    {
        this.hp -= damege;
        Debug.Log(damege + "針のダメージ受けた");
        Debug.Log("残り" + this.hp);
    }
    public void Magic(int needMP)
    {
        if (this.mp >= needMP)
        {
            this.mp -= needMP;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");

        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}

public class BossClassKadai : MonoBehaviour
{

    // Use this for initialization
    void Start(){
            Boss kiraYoshikage = new Boss();
           
            for (int i = 0; i < 11; i++){
                 kiraYoshikage.Magic(3);
            }
        kiraYoshikage.Magic(5);
    }
            
    // Update is called once per frame
    void Update()
    {

    }
}
