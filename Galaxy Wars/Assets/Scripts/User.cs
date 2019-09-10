using UnityEngine;
using System;

[Serializable]
public class User
{
    const string PATH_JSON_FILE = "Setting/user.json";
    const string PATH_DEFAULT_FILE = "Setting/default.json";

    public string name;

    public int[] screenStar; // số sao đạt được của các màn chơi (5 màn)
    public int indexComplete; // màn lớn nhất đã vượt qua

    public Spaceship[] alphaSpaceship; // x4 
    public Spaceship[] betaSpaceship;
    public Spaceship[] GammaSpaceship;

    public int gold, diamod, meda;

    public Spaceship spaceshipSelect = new Spaceship();
    public User(){
        LoadData();
    }
    private void LoadData()
    {
        try
        {
            string jsonString = System.IO.File.ReadAllText(PATH_JSON_FILE);
            this.LoadFromJson(jsonString);
        }
        catch
        {
            try
            {
                string jsonString = System.IO.File.ReadAllText(PATH_DEFAULT_FILE);
                this.LoadFromJson(jsonString);
            }
            catch
            {
                Debug.Log("Khong load dc");
            }
        }
    }
    public bool Save()
    {
        try
        {
            string jsonString = userToJsonString();
            System.IO.File.WriteAllText(PATH_JSON_FILE, jsonString);
            return true;
        }
        catch
        {
            return false;
        }
    }
    public string userToJsonString()
    {
        return JsonUtility.ToJson(this);
    }
    private void LoadFromJson(string jsonString)
    {
        JsonUtility.FromJsonOverwrite(jsonString, this);
    }
}
