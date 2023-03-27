using Raylib_cs;
using System.Numerics;

public class Damage
{
    public static void Kill()
    {
        for (var i = 0; i < Player.bombs.Count; i++)
        {
            for (var j = Enemy.spawnedEnemies.Count - 1; j >= 0; j--)
            {
                if (Raylib.CheckCollisionCircleRec(new Vector2(Player.bombs[i].PosX, Player.bombs[i].PosY), Player.bombs[i].Size, Enemy.spawnedEnemies[j].enemyHitbox))
                {
                    Enemy.spawnedEnemies.RemoveAt(j);
                    Player.bombs.RemoveAt(i);
                    Console.WriteLine($"Deleted [{j}]");
                    Enemy.CurrentAmount--;
                    j = 0;
                }
            }
        }
    }
}
