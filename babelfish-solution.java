import java.util.*;

public class Main {

    public static void main(String[] args) {
	    Scanner sc = new Scanner(System.in);

	    Map<String,String> words = new HashMap<>();

	    while(true){
	    	String input = sc.nextLine();

	    	if(input.equals(""))break;

	    	String[] split_input = input.split(" ");

	    	String key = split_input[1];
	    	String value = split_input[0];

	    	words.put(key,value);
		}

		try{
	    	while(true){
	    		String input = sc.nextLine();

	    		String key = "eh";

	    		if(words.containsKey(input))key = words.get(input);

	    		System.out.println(key);
			}
		}catch(Exception e){

		}
    }
}
