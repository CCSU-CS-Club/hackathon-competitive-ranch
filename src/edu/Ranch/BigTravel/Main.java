package edu.Ranch.BigTravel;

import java.io.*;
import java.util.ArrayList;
import java.util.StringTokenizer;

import static java.lang.Math.abs;

/**
 * Created by Nilay on 2/25/2017.
 */
public class Main {

    private static ArrayList<Point> coordinates = new ArrayList<>();

    public static void main(String[] args){
        BufferedReader br = null;
        try {
            br = new BufferedReader(new FileReader(args[0]));
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }
        String inputText;
        int numberOfCities;
        boolean flag = true;
        try {
            while ((inputText = br.readLine()) != null) {
                if (flag) {
                    numberOfCities = Integer.parseInt(inputText);
                    flag = false;
                } else {
                    StringTokenizer st = new StringTokenizer(inputText);
                    Point p = new Point(Double.parseDouble(st.nextElement().toString()), Double.parseDouble(st.nextElement().toString()));
                    coordinates.add(p);
                }
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
//        coordinates.add(new Point(-1.0,5.0));
//        coordinates.add(new Point(1.0,6.0));
//        coordinates.add(new Point(3.0,5.0));
//        coordinates.add(new Point(2.0,3.0));

        double totalDistance = calculateAllDistance(coordinates);

        double finalDistance = totalDistance % (Math.pow(10.0, 9.0) + 7);
        //System.out.print(finalDistance);
        try {
            try (Writer writer = new BufferedWriter(new OutputStreamWriter(
                    new FileOutputStream(args[1])))) {
                writer.write((int)finalDistance + "");

            }
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    private static double calculateDistance(Point a, Point b){
        return abs(a.getX() - b.getX()) + abs(a.getY() -b.getY());
    }

    private static double calculateAllDistance(ArrayList<Point>points) {
        double totalDistance = 0;
        for (int i = 0; i < points.size(); i++) {
            for (int j = i; j < points.size(); j++) {
                totalDistance += calculateDistance(points.get(i), points.get(j));
            }
        }

        return totalDistance;
    }
}
