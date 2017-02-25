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

    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new FileReader(args[0]));
        String inputText;
        int numberOfCities;
        boolean flag = true;
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
//        coordinates.add(new Point(-1.0,5.0));
//        coordinates.add(new Point(1.0,6.0));
//        coordinates.add(new Point(3.0,5.0));
//        coordinates.add(new Point(2.0,3.0));

        double totalDistance = calculateAllDistance(coordinates);

        double finalDistance = totalDistance % (Math.pow(10.0, 9.0) + 7);
        //System.out.print(finalDistance);
        try (Writer writer = new BufferedWriter(new OutputStreamWriter(
                new FileOutputStream(args[1])))) {
            writer.write(Integer.parseInt(finalDistance + "") + "");

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
