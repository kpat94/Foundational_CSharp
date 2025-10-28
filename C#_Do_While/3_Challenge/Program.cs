int heroHealthScore = 10;
int monsterHealthScore = 10;
Random random = new Random(); 

do
{
    int heroMove = random.Next(1, 11);
    int monsterMove = random.Next(1, 11);

    monsterHealthScore -= heroMove;
    Console.WriteLine($"Hero attacked. \n Damage : {heroMove} \n Monster's Remaining Health : {monsterHealthScore}");

    if (monsterHealthScore > 0)
        heroHealthScore -= monsterMove;
    else    
         break;

    Console.WriteLine($"Monster attacked. \n Damage : {monsterMove} \n Hero's Remaining Health : {heroHealthScore}");

} while (heroHealthScore > 0);

Console.WriteLine(heroHealthScore > monsterHealthScore ? "Hero wins!" : "Monster wins!");