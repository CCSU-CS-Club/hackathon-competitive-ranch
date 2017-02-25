package edu.Ranch.ProblemE;
import java.util.HashMap;
import java.util.regex.Pattern;

/**
 * Created by Nilay on 2/24/2017.
 */
public class BaseConverter {

    private int base, leastBase, currentLeastNumber;
    private int numberToConvert, lowerBound;
    private StringBuilder newNumber = new StringBuilder();
    private HashMap<Integer, String> baseLookup;


    public BaseConverter(int numberToConvert, int lowerBound) {
        this.lowerBound = lowerBound ;
        this.leastBase = 11;
        this.base = 11;
        this.numberToConvert = numberToConvert;
        this.currentLeastNumber = numberToConvert;
    }

    public int getLargestBase() {
        Pattern pattern = Pattern.compile("[a-zA-Z]");
        while (base<=lowerBound) {
            String currentNumber = convert(numberToConvert, base);
            if (!(currentNumber.matches(".*[a-zA-Z].*"))) {
                int runningNumber = Integer.parseInt(currentNumber);
                if(runningNumber >= lowerBound && runningNumber < numberToConvert ) {
                    if(runningNumber < currentLeastNumber ) {
                        currentLeastNumber = runningNumber;
                        leastBase = base;
                    }
                }
            }
            base++;
        }
        return leastBase;
    }
    private int calculateQuotient(int number, int base){
        return numberToConvert / base;
    }
    private int calculateRemainder(int number, int base){
        return number % base;
    }


//
    private String convert(int number, int base)
    {
        int quotient = number / base;
        int remainder = number % base;

        if (quotient == 0) // base case
        {
            return Integer.toString(remainder);
        }
        else
        {
            return convert(quotient, base) + Integer.toString(remainder);
        }
    }
    private void initHashMap(){
        baseLookup = new HashMap<Integer, String>();

        baseLookup.put(10, "A");
        baseLookup.put(11, "B");
        baseLookup.put(12, "C");
        baseLookup.put(13, "D");
        baseLookup.put(14, "E");
        baseLookup.put(15, "F");
        baseLookup.put(16, "G");
        baseLookup.put(17, "H");
        baseLookup.put(18, "I");
        baseLookup.put(19, "J");
        baseLookup.put(20, "K");
        baseLookup.put(21, "L");
        baseLookup.put(22, "M");
        baseLookup.put(23, "N");
        baseLookup.put(24, "O");
        baseLookup.put(25, "P");
        baseLookup.put(26, "Q");
        baseLookup.put(27, "R");
        baseLookup.put(28, "S");
        baseLookup.put(29, "T");
        baseLookup.put(30, "U");
        baseLookup.put(31, "V");
        baseLookup.put(32, "W");
        baseLookup.put(33, "X");
        baseLookup.put(34, "Y");
        baseLookup.put(35, "Z");
    }
}