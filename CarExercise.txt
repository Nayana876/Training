public class Car
{
	public string manufacturer = string.Empty;
	public string color = "blue";
	public string model = string.Empty; 
	public string type = string.Empty;
	public string dateManf = string.Empty;
	private int rate;
	private int modelNo;
	private int number;
	private int pdtNo;
	private int no {get; set;}
	
    public Car(){}
    public int ModelNo
	{
		get {return modelNo;}
		set {modelNo=value;}
	}
	public int Number
	{
		get {return number;}
		set {number=value;}
	}
	public int PdtNo
	{
		get {return pdtNo;}
		set {pdtNo=value;}
	}

    public string Type{
		get {return type;}
		set {type=value;}
	}
	public string Manufacturer{
		get {return manufacturer;}
		set {manufacturer=value;}
	}
	public string Color{
		get {return color;}
		set {color=value;}
	}
	public string Model{
		get {return model;}
		set {model=value;}
	}
	public string date{
		get {return dateManf;}
		set {dateManf=value;}
	}
	public static void Main(string[] args){
		Car c1=new Car();
		c1.ModelNo=1223;
		
		Console.WriteLine(c1.number+" "+c1.no+" "+c1.Color+" "+c1.model);
		
	}
}

