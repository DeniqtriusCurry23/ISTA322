# Dicussion Questions C#CH17
## Deniqtrius Curry
### April 15,2018

1. A type parameter is like a type placeholder for a method or class to tell the compiler what type it accepts. 

2. A type parameter tells the compiler what type the method or class is going to accept. 

3. A generic type can have 1 type. 

4. The difference is that a generalized class is an instance of object type whereas a generic class creates an entirely new class everytime its called. 

5. A constraint is a bracket <T> where T is the constraint which can inherit from an interface to constrain it to make sure that the type used for T can impliment the interface. 

6. A generic method is a method that accepts parameters of type T. Its defined like: public void MethodName<T>(T arg) 

7. It means you cant assign two objects of the same interface to each other. 

8. Covariance means putting the out keyword infront of the T in the interface definition which allows for two objects of that interface to be assigned to each other as long 
as their types match. 

9. Covariance only works with reference types. 

10. Contravariance uses the in keyword and equate two objects of interface type if one is object. 