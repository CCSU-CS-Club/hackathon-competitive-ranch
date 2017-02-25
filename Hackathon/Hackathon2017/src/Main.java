/**
 * Created by Nilay on 2/24/2017.
 */
public class Main {

    public static void main(String[] args){
        BaseConverter baseConverter = new BaseConverter(2016,100);

        System.out.print(baseConverter.convertBase());
    }
}
