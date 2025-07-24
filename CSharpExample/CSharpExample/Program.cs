using System;

interface IWeapon
{
    string WeaponName { get; set; }
    int SetDamage { get; set; }
    int Attack();
    void Use();
}

class Sword: IWeapon
{
    public string WeaponName { get; set; }
    public int SetDamage { get; set; }
    public Sword(int setDamage)
    {
        SetDamage = setDamage;
    }

    public int Attack()
    {
        return SetDamage;
    }
    
    public void Use()
    {
        Console.WriteLine($"{WeaponName}으로 공격 데미지{Attack}를 입혔습니다.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("hello world");
        return;
    }
}