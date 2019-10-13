import java.util.*;

class Main {
  public static void main(String[] args) {
    Scanner sc = new Scanner(System.in);  //create class for input

    int t = sc.nextInt();                 //gets next integer value

    for(int i = 0; i < t; i++){           //loops t times
      int n_fact = fact(sc.nextInt());    //calculates n!
      int last_digit = n_fact % 10;       //gets last digit of n!
      System.out.println(last_digit);     //prints last digit
    }
  }

  public static int fact(int n){
    int fact = 1;

    for(int i = 1; i <= n; i++){
      fact *= i;
    }

    return fact;
  }
}
