Console.WriteLine(",'\\\r\n    _.----.        ____         ,'  _\\   ___    ___     ____\r\n_,-'       `.     |    |  /`.   \\,-'    |   \\  /   |   |    \\  |`.\r\n\\      __    \\    '-.  | /   `.  ___    |    \\/    |   '-.   \\ |  |\r\n \\.    \\ \\   |  __  |  |/    ,','_  `.  |          | __  |    \\|  |\r\n   \\    \\/   /,' _`.|      ,' / / / /   |          ,' _`.|     |  |\r\n    \\     ,-'/  /   \\    ,'   | \\/ / ,`.|         /  /   \\  |     |\r\n     \\    \\ |   \\_/  |   `-.  \\    `'  /|  |    ||   \\_/  | |\\    |\r\n      \\    \\ \\      /       `-.`.___,-' |  |\\  /| \\      /  | |   |\r\n       \\    \\ `.__,'|  |`-._    `|      |__| \\/ |  `.__,'|  | |   |\r\n        \\_.-'       |__|    `-._ |              '-.|     '-.| |   |\r\n                                `'                            '-._|");

string play = "";



do
{

    Console.WriteLine("Escriba Y para jugar");
    play = Console.ReadLine().ToUpper();
    if (play == "y".ToUpper())
    {
        Console.WriteLine("Bienvenido al juego");
    }



} while (play != "y".ToUpper());



if (play == "y".ToUpper())
{
    Console.WriteLine("Elige un Pokemon entre: Sharmander(p) y Squartle(s) ");
}
string player1 = Console.ReadLine().ToUpper();
switch (player1)
{
    case "P":
        Console.WriteLine("Player 1 ha seleccionado a Sharmander");
        Console.WriteLine();
        Console.WriteLine("   _.--\"\"`-..\r\n            ,'          `.\r\n          ,'          __  `.\r\n         /|          \" __   \\\r\n        , |           / |.   .\r\n        |,'          !_.'|   |\r\n      ,'             '   |   |\r\n     /              |`--'|   |\r\n    |                `---'   |\r\n     .   ,                   |                       ,\".\r\n      ._     '           _'  |                    , ' \\ `\r\n  `.. `.`-...___,...---\"\"    |       __,.        ,`\"   L,|\r\n  |, `- .`._        _,-,.'   .  __.-'-. /        .   ,    \\\r\n-:..     `. `-..--_.,.<       `\"      / `.        `-/ |   .\r\n  `,         \"\"\"\"'     `.              ,'         |   |  ',,\r\n    `.      '            '            /          '    |'. |/\r\n      `.   |              \\       _,-'           |       ''\r\n        `._'               \\   '\"\\                .      |\r\n           |                '     \\                `._  ,'\r\n           |                 '     \\                 .'|\r\n           |                 .      \\                | |\r\n           |                 |       L              ,' |\r\n           `                 |       |             /   '\r\n            \\                |       |           ,'   /\r\n          ,' \\               |  _.._ ,-..___,..-'    ,'\r\n         /     .             .      `!             ,j'\r\n        /       `.          /        .           .'/\r\n       .          `.       /         |        _.'.'\r\n        `.          7`'---'          |------\"'_.'\r\n       _,.`,_     _'                ,''-----\"'\r\n   _,-_    '       `.     .'      ,\\\r\n   -\" /`.         _,'     | _  _  _.|\r\n    \"\"--'---\"\"\"\"\"'        `' '! |! /\r\n                            `\" \" -'");
        Console.WriteLine("PIKACHU");
        Console.WriteLine();
        break;
    case "S":
        Console.WriteLine("Player 1 ha seleccionado a Squartle");
        Console.WriteLine();
        Console.WriteLine("        _,........__\r\n            ,-'            \"`-.\r\n          ,'                   `-.\r\n        ,'                        \\\r\n      ,'                           .\r\n      .'\\               ,\"\".       `\r\n     ._.'|             / |  `       \\\r\n     |   |            `-.'  ||       `.\r\n     |   |            '-._,'||       | \\\r\n     .`.,'             `..,'.'       , |`-.\r\n     l                       .'`.  _/  |   `.\r\n     `-.._'-   ,          _ _'   -\" \\  .     `\r\n`.\"\"\"\"\"'-.`-...,---------','         `. `....__.\r\n.'        `\"-..___      __,'\\          \\  \\     \\\r\n\\_ .          |   `\"\"\"\"'    `.           . \\     \\\r\n  `.          |              `.          |  .     L\r\n    `.        |`--...________.'.        j   |     |\r\n      `._    .'      |          `.     .|   ,     |\r\n         `--,\\       .            `7\"\"' |  ,      |\r\n            ` `      `            /     |  |      |    _,-'\"\"\"`-.\r\n             \\ `.     .          /      |  '      |  ,'          `.\r\n              \\  v.__  .        '       .   \\    /| /              \\\r\n               \\/    `\"\"\\\"\"\"\"\"\"\"`.       \\   \\  /.''                |\r\n                `        .        `._ ___,j.  `/ .-       ,---.     |\r\n                ,`-.      \\         .\"     `.  |/        j     `    |\r\n               /    `.     \\       /         \\ /         |     /    j\r\n              |       `-.   7-.._ .          |\"          '         /\r\n              |          `./_    `|          |            .     _,'\r\n              `.           / `----|          |-............`---'\r\n                \\          \\      |          |\r\n               ,'           )     `.         |\r\n                7____,,..--'      /          |\r\n                                  `---.__,--.'");
        Console.WriteLine("SQUARTLE");
        Console.WriteLine();
        break;
    default:
        Console.WriteLine("No ha seleccionado ningun pokemon");
        break;
}
if (play == "y".ToUpper())
{
    Console.WriteLine("Elige un Pokemon entre: Shamander(p) y Squartle(s) ");
}
string player2 = Console.ReadLine().ToUpper();
switch (player2)
{
    case "P":
        Console.WriteLine("Player 2 ha seleccionado a Shamander");
        Console.WriteLine();
        Console.WriteLine("   _.--\"\"`-..\r\n            ,'          `.\r\n          ,'          __  `.\r\n         /|          \" __   \\\r\n        , |           / |.   .\r\n        |,'          !_.'|   |\r\n      ,'             '   |   |\r\n     /              |`--'|   |\r\n    |                `---'   |\r\n     .   ,                   |                       ,\".\r\n      ._     '           _'  |                    , ' \\ `\r\n  `.. `.`-...___,...---\"\"    |       __,.        ,`\"   L,|\r\n  |, `- .`._        _,-,.'   .  __.-'-. /        .   ,    \\\r\n-:..     `. `-..--_.,.<       `\"      / `.        `-/ |   .\r\n  `,         \"\"\"\"'     `.              ,'         |   |  ',,\r\n    `.      '            '            /          '    |'. |/\r\n      `.   |              \\       _,-'           |       ''\r\n        `._'               \\   '\"\\                .      |\r\n           |                '     \\                `._  ,'\r\n           |                 '     \\                 .'|\r\n           |                 .      \\                | |\r\n           |                 |       L              ,' |\r\n           `                 |       |             /   '\r\n            \\                |       |           ,'   /\r\n          ,' \\               |  _.._ ,-..___,..-'    ,'\r\n         /     .             .      `!             ,j'\r\n        /       `.          /        .           .'/\r\n       .          `.       /         |        _.'.'\r\n        `.          7`'---'          |------\"'_.'\r\n       _,.`,_     _'                ,''-----\"'\r\n   _,-_    '       `.     .'      ,\\\r\n   -\" /`.         _,'     | _  _  _.|\r\n    \"\"--'---\"\"\"\"\"'        `' '! |! /\r\n                            `\" \" -'");
        Console.WriteLine("SHARMANDER");
        Console.WriteLine();
        break;
    case "S":
        Console.WriteLine("Player 2 ha seleccionado a Squartle");
        Console.WriteLine();
        Console.WriteLine("        _,........__\r\n            ,-'            \"`-.\r\n          ,'                   `-.\r\n        ,'                        \\\r\n      ,'                           .\r\n      .'\\               ,\"\".       `\r\n     ._.'|             / |  `       \\\r\n     |   |            `-.'  ||       `.\r\n     |   |            '-._,'||       | \\\r\n     .`.,'             `..,'.'       , |`-.\r\n     l                       .'`.  _/  |   `.\r\n     `-.._'-   ,          _ _'   -\" \\  .     `\r\n`.\"\"\"\"\"'-.`-...,---------','         `. `....__.\r\n.'        `\"-..___      __,'\\          \\  \\     \\\r\n\\_ .          |   `\"\"\"\"'    `.           . \\     \\\r\n  `.          |              `.          |  .     L\r\n    `.        |`--...________.'.        j   |     |\r\n      `._    .'      |          `.     .|   ,     |\r\n         `--,\\       .            `7\"\"' |  ,      |\r\n            ` `      `            /     |  |      |    _,-'\"\"\"`-.\r\n             \\ `.     .          /      |  '      |  ,'          `.\r\n              \\  v.__  .        '       .   \\    /| /              \\\r\n               \\/    `\"\"\\\"\"\"\"\"\"\"`.       \\   \\  /.''                |\r\n                `        .        `._ ___,j.  `/ .-       ,---.     |\r\n                ,`-.      \\         .\"     `.  |/        j     `    |\r\n               /    `.     \\       /         \\ /         |     /    j\r\n              |       `-.   7-.._ .          |\"          '         /\r\n              |          `./_    `|          |            .     _,'\r\n              `.           / `----|          |-............`---'\r\n                \\          \\      |          |\r\n               ,'           )     `.         |\r\n                7____,,..--'      /          |\r\n                                  `---.__,--.'");
        Console.WriteLine("SQUARTLE");
        Console.WriteLine();
        break;

    default:
        Console.WriteLine("No ha seleccionado ningun pokemon");
        break;

}
Console.WriteLine();
int ataque1 = 40;
int ataque2 = 30;
int ataque3 = 30;
int player1Hp = 100;
int player2Hp = 100;
if (player1 == "p".ToUpper() && player2 == "s".ToUpper())
{
    Console.WriteLine();
    player1 = "SHAMANDER";
    Console.WriteLine("   _.--\"\"`-..\r\n            ,'          `.\r\n          ,'          __  `.\r\n         /|          \" __   \\\r\n        , |           / |.   .\r\n        |,'          !_.'|   |\r\n      ,'             '   |   |\r\n     /              |`--'|   |\r\n    |                `---'   |\r\n     .   ,                   |                       ,\".\r\n      ._     '           _'  |                    , ' \\ `\r\n  `.. `.`-...___,...---\"\"    |       __,.        ,`\"   L,|\r\n  |, `- .`._        _,-,.'   .  __.-'-. /        .   ,    \\\r\n-:..     `. `-..--_.,.<       `\"      / `.        `-/ |   .\r\n  `,         \"\"\"\"'     `.              ,'         |   |  ',,\r\n    `.      '            '            /          '    |'. |/\r\n      `.   |              \\       _,-'           |       ''\r\n        `._'               \\   '\"\\                .      |\r\n           |                '     \\                `._  ,'\r\n           |                 '     \\                 .'|\r\n           |                 .      \\                | |\r\n           |                 |       L              ,' |\r\n           `                 |       |             /   '\r\n            \\                |       |           ,'   /\r\n          ,' \\               |  _.._ ,-..___,..-'    ,'\r\n         /     .             .      `!             ,j'\r\n        /       `.          /        .           .'/\r\n       .          `.       /         |        _.'.'\r\n        `.          7`'---'          |------\"'_.'\r\n       _,.`,_     _'                ,''-----\"'\r\n   _,-_    '       `.     .'      ,\\\r\n   -\" /`.         _,'     | _  _  _.|\r\n    \"\"--'---\"\"\"\"\"'        `' '! |! /\r\n                            `\" \" -'");
    Console.WriteLine(player1);
    Console.WriteLine("Vida: 100");
    Console.WriteLine("Ataque 1: 40");
    Console.WriteLine("Ataque 2: 30");
    Console.WriteLine("Ataque 3: 30");
    Console.WriteLine();

    Console.WriteLine();
    Console.WriteLine("VS");
    Console.WriteLine();
    Console.WriteLine("        _,........__\r\n            ,-'            \"`-.\r\n          ,'                   `-.\r\n        ,'                        \\\r\n      ,'                           .\r\n      .'\\               ,\"\".       `\r\n     ._.'|             / |  `       \\\r\n     |   |            `-.'  ||       `.\r\n     |   |            '-._,'||       | \\\r\n     .`.,'             `..,'.'       , |`-.\r\n     l                       .'`.  _/  |   `.\r\n     `-.._'-   ,          _ _'   -\" \\  .     `\r\n`.\"\"\"\"\"'-.`-...,---------','         `. `....__.\r\n.'        `\"-..___      __,'\\          \\  \\     \\\r\n\\_ .          |   `\"\"\"\"'    `.           . \\     \\\r\n  `.          |              `.          |  .     L\r\n    `.        |`--...________.'.        j   |     |\r\n      `._    .'      |          `.     .|   ,     |\r\n         `--,\\       .            `7\"\"' |  ,      |\r\n            ` `      `            /     |  |      |    _,-'\"\"\"`-.\r\n             \\ `.     .          /      |  '      |  ,'          `.\r\n              \\  v.__  .        '       .   \\    /| /              \\\r\n               \\/    `\"\"\\\"\"\"\"\"\"\"`.       \\   \\  /.''                |\r\n                `        .        `._ ___,j.  `/ .-       ,---.     |\r\n                ,`-.      \\         .\"     `.  |/        j     `    |\r\n               /    `.     \\       /         \\ /         |     /    j\r\n              |       `-.   7-.._ .          |\"          '         /\r\n              |          `./_    `|          |            .     _,'\r\n              `.           / `----|          |-............`---'\r\n                \\          \\      |          |\r\n               ,'           )     `.         |\r\n                7____,,..--'      /          |\r\n                                  `---.__,--.'");

    player2 = "SQUARTLE";
    Console.WriteLine(player2);
    Console.WriteLine("Vida: 100");
    Console.WriteLine("Ataque 1: 40");
    Console.WriteLine("Ataque 2: 30");
    Console.WriteLine("Ataque 3: 30");

    Console.WriteLine();
    Console.WriteLine();

}
else
{
    player1 = "SQUARTLE";
    Console.WriteLine();
    Console.WriteLine("        _,........__\r\n            ,-'            \"`-.\r\n          ,'                   `-.\r\n        ,'                        \\\r\n      ,'                           .\r\n      .'\\               ,\"\".       `\r\n     ._.'|             / |  `       \\\r\n     |   |            `-.'  ||       `.\r\n     |   |            '-._,'||       | \\\r\n     .`.,'             `..,'.'       , |`-.\r\n     l                       .'`.  _/  |   `.\r\n     `-.._'-   ,          _ _'   -\" \\  .     `\r\n`.\"\"\"\"\"'-.`-...,---------','         `. `....__.\r\n.'        `\"-..___      __,'\\          \\  \\     \\\r\n\\_ .          |   `\"\"\"\"'    `.           . \\     \\\r\n  `.          |              `.          |  .     L\r\n    `.        |`--...________.'.        j   |     |\r\n      `._    .'      |          `.     .|   ,     |\r\n         `--,\\       .            `7\"\"' |  ,      |\r\n            ` `      `            /     |  |      |    _,-'\"\"\"`-.\r\n             \\ `.     .          /      |  '      |  ,'          `.\r\n              \\  v.__  .        '       .   \\    /| /              \\\r\n               \\/    `\"\"\\\"\"\"\"\"\"\"`.       \\   \\  /.''                |\r\n                `        .        `._ ___,j.  `/ .-       ,---.     |\r\n                ,`-.      \\         .\"     `.  |/        j     `    |\r\n               /    `.     \\       /         \\ /         |     /    j\r\n              |       `-.   7-.._ .          |\"          '         /\r\n              |          `./_    `|          |            .     _,'\r\n              `.           / `----|          |-............`---'\r\n                \\          \\      |          |\r\n               ,'           )     `.         |\r\n                7____,,..--'      /          |\r\n                                  `---.__,--.'");
    Console.WriteLine(player1);
    Console.WriteLine("Vida: 100");
    Console.WriteLine("Ataque 1: 40");
    Console.WriteLine("Ataque 2: 30");
    Console.WriteLine("Ataque 3: 30");
    Console.WriteLine();

    Console.WriteLine();
    Console.WriteLine("VS");
    Console.WriteLine();
    Console.WriteLine();
    player2 = "SHAMANDER";
    Console.WriteLine("   _.--\"\"`-..\r\n            ,'          `.\r\n          ,'          __  `.\r\n         /|          \" __   \\\r\n        , |           / |.   .\r\n        |,'          !_.'|   |\r\n      ,'             '   |   |\r\n     /              |`--'|   |\r\n    |                `---'   |\r\n     .   ,                   |                       ,\".\r\n      ._     '           _'  |                    , ' \\ `\r\n  `.. `.`-...___,...---\"\"    |       __,.        ,`\"   L,|\r\n  |, `- .`._        _,-,.'   .  __.-'-. /        .   ,    \\\r\n-:..     `. `-..--_.,.<       `\"      / `.        `-/ |   .\r\n  `,         \"\"\"\"'     `.              ,'         |   |  ',,\r\n    `.      '            '            /          '    |'. |/\r\n      `.   |              \\       _,-'           |       ''\r\n        `._'               \\   '\"\\                .      |\r\n           |                '     \\                `._  ,'\r\n           |                 '     \\                 .'|\r\n           |                 .      \\                | |\r\n           |                 |       L              ,' |\r\n           `                 |       |             /   '\r\n            \\                |       |           ,'   /\r\n          ,' \\               |  _.._ ,-..___,..-'    ,'\r\n         /     .             .      `!             ,j'\r\n        /       `.          /        .           .'/\r\n       .          `.       /         |        _.'.'\r\n        `.          7`'---'          |------\"'_.'\r\n       _,.`,_     _'                ,''-----\"'\r\n   _,-_    '       `.     .'      ,\\\r\n   -\" /`.         _,'     | _  _  _.|\r\n    \"\"--'---\"\"\"\"\"'        `' '! |! /\r\n                            `\" \" -'");
    Console.WriteLine(player2);
    Console.WriteLine("Vida: 100");
    Console.WriteLine("Ataque 1: 40");
    Console.WriteLine("Ataque 2: 30");
    Console.WriteLine("Ataque 3: 30");


    Console.WriteLine();

}


do
{


    Console.WriteLine();
    Console.WriteLine("Turno player1");
    Console.WriteLine();
    Console.WriteLine("Ataque1 (j), Ataque2 (k), Ataque3 (l),");
    player1 = Console.ReadLine();
    Console.WriteLine();





    if (player1 == "j")
    {
        int result = player1Hp - ataque1;
        player1Hp = result;
        Console.WriteLine("Jugador 1 ha utilizado Ataque1 y quita " + ataque1 + " HP");
        Console.WriteLine("La vida del player 2 es " + result);
    }
    if (player1 == "k")
    {
        int result = player1Hp - ataque2;
        player1Hp = result;
        Console.WriteLine("Jugador 1 ha utilizado Ataque2 y quita " + ataque2 + " HP");
        Console.WriteLine("La vida del player 2 es " + result
            );
    }

    if (player1 == "l")
    {
        int result = player1Hp - ataque3;
        player1Hp = result;
        Console.WriteLine("Jugador 1 ha utilizado Ataque3 y quita " + ataque3 + " HP");
        Console.WriteLine("La vida del player 2 es " + result);
    }

    if (player1Hp <= 0)
    {
        Console.WriteLine("Player 2 ha perdido");
        break;
    }
    Console.WriteLine();
    Console.WriteLine("Turno player2");
    Console.WriteLine();
    Console.WriteLine("Ataque1 (j), Ataque2 (k), Ataque3 (l),");
    Console.WriteLine();

    player2 = Console.ReadLine();
    if (player2 == "j")
    {
        int result = player2Hp - ataque1;
        player2Hp = result;
        Console.WriteLine("Jugador 2 ha utilizado Ataque1 y quita " + ataque1 + " HP");
        Console.WriteLine("La vida del player 1 es " + result);
    }
    if (player2 == "k")
    {
        int result = player2Hp - ataque1;
        player2Hp = result;
        Console.WriteLine("Jugador 2 ha utilizado Ataque2 y quita " + ataque2 + " HP");
        Console.WriteLine("La vida del player 1 es " + result);
    }
    if (player2 == "l")
    {
        int result = player2Hp - ataque1;
        player2Hp = result;

        Console.WriteLine("Jugador 2 ha utilizado Ataque3 y quita " + ataque3 + " HP");
        Console.WriteLine("La vida del player 1 es " + result);
    }

    if (player2Hp <= 0)
    {
        Console.WriteLine("Player 1 ha perdido");
        break;
    }

}
while (player1Hp >= 1 || player2Hp >= 1);