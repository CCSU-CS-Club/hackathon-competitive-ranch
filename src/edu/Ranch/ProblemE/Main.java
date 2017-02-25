package edu.Ranch.ProblemE;

import java.io.*;
import java.util.StringTokenizer;

/**
 * Created by Nilay on 2/24/2017.
 */
public class Main {

    public static void main(String[] args) {
        String inputText;
        long numberToConvert = 0, lowerBound = 0;
        try {
            BufferedReader br = new BufferedReader(new FileReader(args[0]));
            inputText = br.readLine();
            StringTokenizer st = new StringTokenizer(inputText);

            numberToConvert = Long.parseLong(st.nextElement().toString());
            lowerBound = Long.parseLong(st.nextElement().toString());

        } catch (FileNotFoundException e1) {
            e1.printStackTrace();
        } catch (IOException e1) {
            e1.printStackTrace();
        }
        BaseConverter baseConverter = new BaseConverter(numberToConvert,lowerBound);

        long output = baseConverter.getLargestBase();

        try (Writer writer = new BufferedWriter(new OutputStreamWriter(
                new FileOutputStream(args[1])))) {
            writer.write(output + "");
        } catch (UnsupportedEncodingException e) {
            e.printStackTrace();
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

}
