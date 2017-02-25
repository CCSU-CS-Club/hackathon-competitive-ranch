package edu.Ranch.GameOfSweets;

import java.io.*;
import java.util.ArrayList;
import java.util.StringTokenizer;

import static java.lang.Math.abs;

/**
 * Created by Nilay on 2/25/2017.
 */
public class Main {
    public static void main(String[] args) {
        ArrayList<Integer> numbers = new ArrayList<>();
        BufferedReader br = null;
        try {
            br = new BufferedReader(new FileReader(args[0]));
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }
        String inputText;
        int numberOfCards = 0;
        boolean flag = true;
        try {
            while ((inputText = br.readLine()) != null) {
                if (flag) {
                    numberOfCards = Integer.parseInt(inputText);
                    flag = false;
                } else {

                    StringTokenizer st = new StringTokenizer(inputText);
                    while (numberOfCards > 0) {
                        numbers.add(Integer.parseInt(st.nextElement().toString()));
                        numberOfCards--;
                    }
                }
            }
            int answer = findDifference(numbers);
            try {
                try (Writer writer = new BufferedWriter(new OutputStreamWriter(
                        new FileOutputStream(args[1])))) {
                    writer.write(answer + "");

                }
            } catch (IOException e) {
                e.printStackTrace();
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    private static int findDifference(ArrayList<Integer> nums){
        ArrayList<Integer> differences = new ArrayList<>();
        int runningDifference = 0;
        for(int i = 0; i<nums.size(); i++){
            for(int j = i + 1; j < nums.size(); j++){
                runningDifference = abs(nums.get(i) - nums.get(j));
                if(!differences.contains(runningDifference)){
                    differences.add(runningDifference);
                }
            }
        }

        return differences.size();
    }
}

