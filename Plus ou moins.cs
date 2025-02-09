﻿using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;

        while (playAgain)
        {
            Console.Clear(); 
            PlayGame();

            Console.Write("Voulez-vous rejouer ? (o/n): ");
            char response = Console.ReadKey().KeyChar;
            Console.WriteLine();

            playAgain = (response == 'o' || response == 'O');
        }
    }

    static void PlayGame()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 101); 
        int attempts = 10;
        int currentAttempt = 1;

        Console.WriteLine("Bienvenue dans le jeu 'Plus ou Moins! J'ai pensé à un nombre entre 1 et 100.");
        Console.WriteLine($"Vous avez {attempts} essais pour le deviner. Commençons. Bonne chance !");

        while (currentAttempt <= attempts)
        {
            Console.Write($"Tentative {currentAttempt}: Veuillez entrer votre estimation: ");

            int userGuess;
            if (!int.TryParse(Console.ReadLine(), out userGuess))
            {
                Console.WriteLine("Entrée invalide. Veuillez entrer un entier valide.");
                continue; 
            }

            if (userGuess < randomNumber)
            {
                Console.WriteLine("Trop bas! Essayez encore.");
            }
            else if (userGuess > randomNumber)
            {
                Console.WriteLine("Trop haut! Essayez encore.");
            }
            else
            {
                Console.WriteLine($"Félicitations! Vous avez deviné le nombre ({randomNumber}) en {currentAttempt} tentatives. Vous êtes le GOAT!");
                return;
            }

            currentAttempt++;
        }

        Console.WriteLine($"Désolé, vous n'avez pas deviné. Le nombre correct est {randomNumber}.");
    }
}