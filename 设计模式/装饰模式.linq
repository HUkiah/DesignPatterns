<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	Component component = new ConcreteComponent();
	
	component = new ConcreteDecoratorA(component);
	
	component = new ConcreteDecoratorB(component);
	
	component.operate();
}

// Define other methods and classes here
public abstract class Component
{ 
	public virtual void operate()
	{
		Console.WriteLine("{0} do something!",DateTime.Now);
	}
}

public class ConcreteComponent : Component
{ 
	public override void operate()
	{
		Console.WriteLine("{0} ConcreteComponent do something!",DateTime.Now);
	}
}

public class Decorator : Component
{
	private Component component = null;
	public Decorator(Component _component)
	{
		this.component=_component;
	}
	
	public override void operate()
	{
		component.operate();
	}
}

public class ConcreteDecoratorA : Decorator
{ 
	public ConcreteDecoratorA(Component _component):base(_component)
	{
	}

	private void method1()
	{
		Console.WriteLine("{0} ConcreteDecoratorA 修饰！",DateTime.Now);
	}

	public override void operate()
	{
		this.method1();
		base.operate();
	}
}

public class ConcreteDecoratorB : Decorator
{
	public ConcreteDecoratorB(Component _component) : base(_component)
	{
	}

	private void method1()
	{
		Console.WriteLine("{0} ConcreteDecoratorB 修饰！",DateTime.Now);
	}

	public override void operate()
	{
		this.method1();
		base.operate();
	}
}