using System;

[Serializable]
public class Spaceship
{
    public string name;

    public float health;
    public float damage;
    public float crit;

    public int priceGold;
    public int priceDiamond;

    public bool isEnable;

    public int level;
    public const int levelMax = 10;

    public Spaceship()
    {

    }

    public void LevelUp()
    {
        level++;
        damage *= 105 / 100;
        health *= 105 / 100;
        if(level == 5 || level == 10)
        {
            crit *= 2;
        }
        if (level > levelMax)
        {
            level = levelMax;
        }
    }
}
