// Struct is a value type whereas Class is reference type
// Structs are stored on stack whereas classes are stored on heap
// Object reference variables are stored on the stack whereas the object itself is stored on the heap.
// Value types hold their value in memory where they are declared but reference types hold a reference 
// to an object in memory
// Value types are destroyed immediately after the scope is lost whereas for reference types only the reference variable is destroyed after the scope is lost. The object is later destroyed by garbage collector.
// When copying a struct into another struct, a new copy of struct is created. so a modification on one struct will not affect another struct. Similar to value types
// int i =10; int j = i; int j = j+1; 
// i = 10, j = 11; i& j have different values

// When copying a class into another class, the get the copy of same reference variable. So a modification on one class will affect another class. Similar to reference types.
// Customer C1= new Customer();
// C1.ID = 101;
// Customer C2 = C1;
// C2.ID = 111;
// C1 = 111, C2 = 111; C1 & C2 have same values

// Structs cannot have destructors whereas class can have destructors as structs are value types.
// Structs cannot have explicit parameterless constructor whereas class can.
// Structs cant inherit from another class whereas a class can.
// Both structs and classes can inherit from interface.
// Structs are sealed types. No class or struct can inherit from struct.

