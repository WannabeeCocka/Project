using Raylib_cs;
using System.Numerics;


Raylib.InitWindow(1024, 576, "dungeon");
Raylib.SetTargetFPS(60);

int frames=0, time=0;   


float speed = 5f;



Texture2D avatarImage = Raylib.LoadTexture("Cheems.png");

Rectangle character = new Rectangle(0, 0, avatarImage.width, avatarImage.height);
Rectangle enemyRect = new Rectangle(0, 280, 450, 16);
Rectangle enemyRect2 = new Rectangle(550, 280, 200, 16);
Rectangle Vertical1 = new Rectangle(450, 280, 16, 200 );


string currentScene = "menu";


while (Raylib.WindowShouldClose() == false)

{

    if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
    {
        character.x += speed;
    }
    if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
    {
        character.x -= speed;
    }
    if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
    {
        character.y -= speed;
    }
    if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
    {
        character.y += speed;
    }

   



    if (Raylib.IsKeyPressed(KeyboardKey.KEY_R))
    {
        currentScene = "game";
    }

 
//
    if (currentScene == "menu")
    {
        if (Raylib.GetKeyPressed() > 0)
        {
            currentScene = "game";
        }
    }
// Inte skrivit själv


    if (Raylib.CheckCollisionRecs(character, enemyRect))
    {

        currentScene = "gameover";
    }
    
    if (Raylib.CheckCollisionRecs(character, enemyRect2))
    {

        currentScene = "gameover";
    }
    
    if (Raylib.CheckCollisionRecs(character, Vertical1))
    {

        currentScene = "gameover";
    }


    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.BEIGE);



    if (currentScene == "menu")
    {
    
        Raylib.DrawText("Press any key to continue", 188, 500, 50, Color.BLACK);

        Raylib.ClearBackground(Color.RAYWHITE);
    }

    if (currentScene == "game")
    {
        Raylib.DrawTexture(avatarImage,
             (int)character.x,
             (int)character.y,
             Color.WHITE
        );
        Raylib.DrawRectangleRec(enemyRect, Color.GRAY);
        Raylib.DrawRectangleRec(enemyRect2, Color.GRAY);
        Raylib.DrawRectangleRec(Vertical1, Color.GRAY);
    }
    if (currentScene == "gameover")
    {
        Raylib.ClearBackground(Color.BLACK);
        Raylib.DrawText("GAME OVER", 281, 100, 70, Color.RED);
        Raylib.DrawText("Press R to restart", 281, 400, 50, Color.WHITE);
        
       

       { 
        Raylib.SetTargetFPS(60);
          frames++;
          if(frames==60) {
                   time++; 
  }
}
       if(time == 1) 
        {
       Raylib.DrawText("LOSER!!!", 350, 200, 70, Color.DARKBLUE);
    }}

while (currentScene == "menu") {

    
}


    Raylib.EndDrawing();
}


Console.ReadLine();

