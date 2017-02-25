package edu.Ranch.ProblemE;

import java.io.*;
import java.util.StringTokenizer;

/**
 * Created by Nilay on 2/24/2017.
 */
public class Main {

    public static void main(String[] args) {
        String inputText;
        int numberToConvert = 0, lowerBound = 0;
        try {
            BufferedReader br = new BufferedReader(new FileReader(args[1]));
            inputText = br.readLine();
            StringTokenizer st = new StringTokenizer(inputText);

            numberToConvert = (int) st.nextElement();
            lowerBound = (int) st.nextElement();

        } catch (FileNotFoundException e1) {
            e1.printStackTrace();
        } catch (IOException e1) {
            e1.printStackTrace();
        }
        BaseConverter baseConverter = new BaseConverter(numberToConvert,lowerBound);

        int output = baseConverter.getLargestBase();

        try (Writer writer = new BufferedWriter(new OutputStreamWriter(
                new FileOutputStream(args[2]), "utf-8"))) {
            writer.write(output);
        } catch (UnsupportedEncodingException e) {
            e.printStackTrace();
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
