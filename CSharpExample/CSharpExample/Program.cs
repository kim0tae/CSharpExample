using System;
using System.Security;

interface IWeapon
{
    string WeaponName { get; set; }
    int SetDamage { get; set; }
    void Upgrade(int amount);
    int Attack();
    void Use();
}

class Player
{
    public string Name { get; set; }
    public List<IWeapon> weapons { get; set; } = new ();

    public void addWeapon(IWeapon weapon)
    {
        weapons.Add(weapon);
    }

    public void removeWeapon(IWeapon weapon)
    {
        weapons.Remove(weapon);
    }

    public void getWeapon()
    {
        string res = "";
        foreach(var weapon in weapons)
        {
            res += weapon.WeaponName + " ";            
        }
        Console.Write($"소유한 무기 정보 : {res}");
    }
}

class Sword: IWeapon
{
    public string WeaponName { get; set; }
    public int SetDamage { get; set; }
    public Sword(int setDamage, string weaponName)
    {
        SetDamage = setDamage;
        WeaponName = weaponName;
    }

    public void Upgrade(int amount)
    {
        SetDamage += amount;
    }

    public int Attack()
    {
        return SetDamage;
    }
    
    public void Use()
    {
        Console.WriteLine($"{WeaponName}으로 공격 데미지{Attack()}를 입혔습니다.");
    }
}

class Bow : IWeapon
{
    public string WeaponName { get; set; }
    public int SetDamage { get; set; }

    public Bow(int setDamage, string weaponName)
    {
        SetDamage = setDamage;
        WeaponName = weaponName;
    }

    public void Upgrade(int amount)
    {
        SetDamage += amount;
    }

    public int Attack()
    {
        return SetDamage;
    }

    public void Use()
    {
        Console.WriteLine($"{WeaponName}으로 공격 데미지{Attack()}를 입혔습니다.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {

            var selectedItem = Console.ReadLine();
        }
        return;
    }
}