import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class AOC {
    public static void main(String[] args) {
        int count = 0;
        List <Integer> values = new ArrayList<Integer>();
        try {
            File file = new File("C:\\Users\\cwkam\\development\\AOCDay1\\src\\input.txt");
            Scanner scan = new Scanner(file);
            while (scan.hasNextLine()) {
                String data = scan.nextLine();
                int value = Integer.parseInt(data);
                values.add(value);
            }
            for (int i = 0; i < values.size() - 1; i++) {
                if (values.get(i+1) > values.get(i)) {
                    count++;
                }
            }
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }

    }
}
