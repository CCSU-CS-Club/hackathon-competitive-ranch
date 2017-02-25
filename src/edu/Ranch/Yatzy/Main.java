package edu.Ranch.Yatzy;

import java.util.ArrayList;
import java.util.Random;
import java.util.Scanner;

/**
 * Created by Nilay on 2/25/2017.
 */
public class Main {
    public static void main(String[] args) {
        int totalNumberOfPlayer = 0;
        Scanner scan = new Scanner(System.in);
        System.out.println("Hello, Welcome to Yatzy. Please type the number of players you want to play with.");
        totalNumberOfPlayer = scan.nextInt();
        ArrayList<Player> players = new ArrayList<>();
        for (int i = 1; i <= totalNumberOfPlayer; i++) {
            System.out.println("Please type the name of player number: " + 1);
            Player player = new Player();
            player.setName(scan.next());
            players.add(player);
        }

        for (Player p : players) {
            System.out.print(p.getName() + " is now rolling the dice");
            Random rand = new Random(System.currentTimeMillis());
            int first = rand.nextInt(7);
            int second = rand.nextInt(7);
            int third = rand.nextInt(7);
            int fourth = rand.nextInt(7);
            int fifth = rand.nextInt(7);

            System.out.println("You rolled: ");
            System.out.println("First: " + first);
            System.out.println("Second: " + second);
            System.out.println("Third: " + third);
            System.out.println("Fourth: " + fourth);
            System.out.println("Fifth: " + fifth);

            System.out.println("Please: ");
        }
    }
}