public class Journal{
    List<Entry> entries = new List<Entry> ();


    
    public void createEntry(){
        Entry testentry = new Entry();
        testentry.newEntry();
        entries.Add(testentry);
    }
    



    public void display(){
        foreach (Entry entry in entries){
            entry.display();

        }
        
    }

    public void menu(){

        while (true){
            Console.WriteLine("[1] Display entries");
            Console.WriteLine("[2] Add new Entry");
            Console.WriteLine("[3] Load");
            Console.WriteLine("[4] Save");
            Console.WriteLine("[5] Quit");
            string choice = Console.ReadLine();


            if(choice == "1"){
                display();
            }
            else if(choice == "2"){
                createEntry();

            }
            else if(choice == "3"){

            }
            else if (choice == "4"){
                save();
            }
            else if (choice == "5"){
                break;
            }
        }

    }

    public void save(){
        string fileName = " ";
        Console.Write("What file do you want to save to? (be spiciphic): ");
        fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // You can add text to the file with the WriteLine method
            foreach (Entry entry in entries){
                
                outputFile.WriteLine(entry.write());
            }
            
           
        }
    }

    public void load(){
        Console.Write("what file do you want to load from");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string date = parts[0];
            string prompt = parts[1];
            string text = parts[2];

            Entry entry = new Entry();





            entries.Add(entry);
        }
    }


    //display
    // save journal to file location
    // load journal from file 
    // provide menu
    
}
