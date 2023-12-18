// For more information see https://aka.ms/fsharp-console-apps
open System

let areaSize = 20

let colorBackground = ConsoleColor.White
let texturePacman = "@"
let colorPacman = ConsoleColor.Yellow
let textureEnemy = "$"
let colorEnemy = ConsoleColor.Red
let textureCoin = "*"
let colorCoin = ConsoleColor.Blue

Console.BackgroundColor <- colorBackground
Console.ForegroundColor <- colorPacman

// Console.WriteLine(texturePacman)
Console.Write("first\nsecond")