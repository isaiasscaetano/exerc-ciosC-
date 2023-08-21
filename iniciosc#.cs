using system.collection;
using system.collection.generic;
using Unityengine;

public class EnemyAI : MonoBehaviour
{
    float health;
    int speed;
    string enemyname;

    enemyweapon weapon;

    int[] intArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    list<int> intlist = new list<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    void movement()
    {
        foreach (int intNmbers in intArray)
        {

        }

        for (int i = 0; i < intArray.length 10; i++)
        {
            int currentNumber = intArray[i];
        }

        for (int i = 0; i < intlist.count; i++)
        {
            int currentNumber = intlist[1];
        }

        if (speed >= 0 || health > 0)
        {

        }
    }

    void dead()
    {
        if (helth <= 0)

    }

    void attack()
    {
        weapon.damenge = 30;
        weapon.fire = 0.4f;
        weapon.shoot();
    }
}

public class enemyweapon
{


   public float damege;
   public float firerate;

    public void shoot()
    {

    }
}
    

    



