Random random = new();

int heroHealth = 10;
int monsterHealth = 10;

do
{
    int heroAttack = random.Next(2, 10);
    monsterHealth -= heroAttack;
    Console.WriteLine($"Monster is damaged and lost {heroAttack} and carry {monsterHealth} health currently.");

    if (monsterHealth <= 0) continue;

    int monsterAttack = random.Next(2, 10);
    heroHealth -= monsterAttack;
    Console.WriteLine($"Hero is damaged and lost {monsterAttack} and carry {heroHealth} health currently.");
} while (heroHealth > 0 && monsterHealth > 0);

Console.WriteLine(heroHealth > monsterHealth ? "HERO IS VICTORIOUS!" : "MONSTER IS VICTORIOUS!");