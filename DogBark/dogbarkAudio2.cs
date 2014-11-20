//Name space Declaration
using System;
using System.Runtime.InteropServices;


public class Test {
	//Main Program Execution
	[STAThread]
	public static void Main() {
		Test t=new Test();
		Console.WriteLine("Started...\t" + DateTime.Now);
		Console.WriteLine("---------------------------------------");
		t.Run();
		Console.WriteLine("---------------------------------------");
		Console.WriteLine("Fini...\t\t" + DateTime.Now);
	}
	public void Run() {
		// Instantiate Dog objects
		// Declare an instance of the Dog class
		Dog milo;

		// Allocate memory for the dog object
		milo = new Dog();
		Console.WriteLine ("New dog milo. defualt constuctor milo.Name =" + milo.Name + ".");
		
		milo.About();
		milo.Bark();
		milo.About();

		// Declare and Allocate in one like
		Dog fido = new Dog("fido");
		Console.WriteLine ("\nNew dog " + fido.Name + ".");
		fido.BarkWav = "bark01.wav";
		fido.BarkSound = "BowWowWow!";
		fido.About();
		fido.Bark();
		Console.WriteLine ("Number of times " + fido.Name + " has barked = " + fido.BarkCount);

		Dog rover = new Dog("rover", "arf!!!");
		Console.WriteLine ("\nNew dog " + rover.Name + ".");
		rover.BarkWav = "bark.wav";
		rover.Age = 2;
		rover.Weight = 14;
		rover.About();
		rover.Bark();
		rover.Bark();
		rover.Bark();
		Console.WriteLine ("Number of times " + rover.Name + " has barked = " + rover.BarkCount);
	
	}
}

//Dog class definition
public class Dog {
	private string name;		// the dog's name
	private int age;			// the dog's age
	private int weight;			// the dog's weight
	private string barkSound;		// the dog's bark
	private string barkWav;		// the dog's bark
	private int barkCount;

	static private int dogCount;

	public Dog() {
		barkSound = "Woof!!!";
		barkWav = "bark02.wav";
	}
	public Dog(string newName) {
		name = newName;
		barkSound = "Woof!!!";
		barkWav = "bark02.wav";
	}
	public Dog(string newName, string newBarkSound ) {
		name = newName;
		barkSound = newBarkSound;
		barkWav = "bark02.wav";
	}

	public Dog(string newName, string newBarkSound, string newBarkWav ) {
		name = newName;
		barkSound = newBarkSound;
		barkWav = newBarkWav;
	}

	public string Name {
		get {
			return name;
		}
		set {
			name = value;
		}
	}
	public int Age {
		get {
			return age;
		}
		set {
			age = value;
		}
	}
	public int Weight {
		get {
			return weight;
		}
		set {
			weight = value;
		}
	}
	public string BarkSound {
		get {
			return barkSound;
		}
		set {
			barkSound = value;
		}
	}
	public string BarkWav {
		get {
			return barkWav;
		}
		set {
			barkWav = value;
		}
	}
	public int BarkCount {
		get {
			return barkCount;
		}
	}
	public int DogCount {
		get {
			return dogCount;
		}
	}


	public void About() { 
		Console.WriteLine ("\nThe dogs name is " + this.name + ".");
		Console.WriteLine ("It is " + this.age + " years old.");
		Console.WriteLine ("It weighs " + this.weight + " lb(s).");
		Console.WriteLine ("Its bark sounds like '" + this.barkSound + "'");
		Console.WriteLine ("It has barked " + this.barkCount + " time(s)" );
	}

	public void Bark() { 
		Console.WriteLine (this.barkSound);
		PlayWav.PlaySound(this.barkWav, true);
		this.barkCount++ ;
	}
	public void Eat() {
		//put eat code here 
	}
}	



public class PlayWav
{
	/*
	public static void Main(String[] args)
	{	
		//Write Line to Console
		PlaySound(args[0], true);
		
	}*/

	public PlayWav() {
	}

	
	[DllImport("winmm.dll")]
    private static extern int sndPlaySoundA(string lpszSoundName, int uFlags);
    
    public static int PlaySound(string sSoundFile, bool bSynchronous) {
    	return PlaySound(sSoundFile, bSynchronous, true);
    }
    
    public static int PlaySound(string sSoundFile, bool bSynchronous, bool bIgnoreErrors) {
    	return PlaySound(sSoundFile, bSynchronous, false, false, false, false, bIgnoreErrors);
    }
    
    public static int PlaySound(string sSoundFile, bool bSynchronous, bool bNoDefault, 
    	bool bLoop, bool bNoStop, bool bMemory, bool bIgnoreErrors) {
    	int SND_SYNC = 0;
    	int SND_ASYNC = 1;
    	int SND_NODEFAULT = 2;
    	int SND_MEMORY = 4;
    	int SND_LOOP = 8;
    	int SND_NOSTOP = 16;
    	if (!System.IO.File.Exists(sSoundFile)) {
    		string WinDir = System.Environment.GetEnvironmentVariable("WINDIR");
    		if (WinDir.Substring(WinDir.Length - 1, 1) != "\\") WinDir += "\\";
    		if (System.IO.File.Exists(WinDir + "media\\" + sSoundFile)) {
    			sSoundFile = WinDir + "media\\" + sSoundFile;
    		} else if (System.IO.File.Exists(WinDir + "media\\" + sSoundFile + ".wav")) {
    			sSoundFile = WinDir + "media\\" + sSoundFile + ".wav";
    		}
    	}
    	if (!System.IO.File.Exists(sSoundFile) && !bIgnoreErrors) {
    		throw new Exception("Sound file doesn't exist.");
    	} else {
    		int Snd_Options = 0;
    		if (bSynchronous) {
    			Snd_Options = SND_SYNC;
    		} else {
    			Snd_Options = SND_ASYNC;
    		}
    		if (bNoDefault) Snd_Options += SND_NODEFAULT;
    		if (bLoop) Snd_Options += SND_LOOP;
    		if (bNoStop) Snd_Options += SND_NOSTOP;
    		if (bMemory) Snd_Options += SND_MEMORY;
    		return sndPlaySoundA(sSoundFile, Snd_Options);
    	}
	}
}

	
