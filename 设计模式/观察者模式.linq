<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	try
	{
		var testSubject = new ConcreteSubject();
		var testObserver = new ConcreteObserver();
		var testTomato= new TomatoObserver();
		testSubject.registerObserver(testObserver);
		testSubject.registerObserver(testTomato);
		testSubject.setDescription("123");
	}
	catch (Exception ex)
	{
		ex.Dump();
	}
}

// Define other methods and classes here
//抽象主题
public interface Subject
{
	void registerObserver(Observer o);
	void removeObserver(Observer o);
	void notifyObserver();
}

//抽象观察者l
public interface Observer
{
	void Update(string description);
}

public class ConcreteSubject : Subject
{
	private List<Observer> observers { get; set; }
	public string description {get;set;}

	public ConcreteSubject()
	{
		observers = new List<Observer>();
		description=string.Empty;
	}

	public void registerObserver(Observer o)
	{
		this.observers.Add(o);
	}

	public void removeObserver(Observer o)
	{
		this.observers.Remove(o);
	}

			public void setDescription(string str)
			{
				description=str;
				notifyObserver();
			}

	public void notifyObserver()
	{
		foreach (var o in observers)
		{
			o.Update(description);
		}
	}
}

public class ConcreteObserver : Observer
{

	public void Update(string description)
	{
		Util.display(description);
	}


}

public class TomatoObserver:Observer
{
	public void Update(string description)
	{
		Util.display("tomato"+description);
	}
}

public static class Util
{
	public static void display(string str)
	{
		Console.WriteLine("Observer:" + str);
	}
}

