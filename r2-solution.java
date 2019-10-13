import java.util.*;

public class Main {

    public static void main(String[] args) {
	    Scanner sc = new Scanner(System.in);                  //creates input scanner

	    String input = sc.nextLine();                         //gets input
        String[] split_input = input.split(" ");       //splits input

	    int r1 = Integer.parseInt(split_input[0]);           //parses R1
	    int s = Integer.parseInt(split_input[1]);            //parses S

	    /*
            Original Equation
            s = (r1 + r2) / 2

            Isolated r2 Equation
            r2 = 2s - r1

        */

	    int r2 = 2 * s - r1;                                 //calculates R2

	    System.out.println(r2);                              //prints r2
    }
}
