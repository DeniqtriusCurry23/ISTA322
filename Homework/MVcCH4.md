## Discussion Questions CH4  
#### Deniqtrius Curry  
#### Apr 18, 2018  

1. Using automatic properties means you only need to write 'public string Whatever { get; set; }' instead of writing the private field, the whole get and set 
properties and how they relate to it.  

2. The object initializer lets you assign values to the parameters without calling the object name for each parameter, you can simply call the actual 
parameter name and assign a value to it inside the curly brackets. 

3. The purpose of extension methods are to add methods to classes that you cant modify. 

4. 'this' keyword in front of the first parameter. 

5. Example: 
	public static Filter(this Class results)
	{
		// if else statements;
	}
	return filter;
	
int filt = objectName.Filter() 

6. The syntax is like this: foreach (Product prod in products.Filter(prod => prod.Category == "Soccer") { }  
Where prod is the parameter that you dont need to specify a type for, prod.Category is the field and it returns a bool if its equal to "Soccer".  

7. The difference is that an annonymously typed variable cant be declared, dont have a type and cant be used anywhere but locally. Dynamically typed 
is the same but can be used in any method or anything, it just tells the compiler to ignore it. 

8. SQL query notation can only use FROM, (ORDERBY/WHERE), and SELECT clauses. Dot notation can use different more specific methods that can mimic sql clauses, 
for example the .Take(value) which takes the top value numbers acts like the Top(value) clause in SQL and doesnt have an equivolent in SQL query notation in C#. 

9. Await keyword tells the compiler to wait for the result of the async method and then carry on executing other statements 
in the same method.

10. async designates the method as asyncronous and await references the async method and waits on its return statement for a value in order to continue.