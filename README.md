# Csharp-reflections  
This repository focuses on mastering **Reflection in C#**, enabling runtime inspection, modification, and dynamic invocation of types, members, and metadata.  
It helps build a strong understanding of how C# programs can analyze and manipulate themselves during execution.

---

### 🔹 `reflection` branch  
This branch covers:

- Inspecting classes, methods, fields, and constructors at runtime  
- Accessing private and static members using Reflection  
- Dynamically creating objects and invoking methods  
- Working with custom attributes through Reflection  
- Advanced use cases like execution timing and object-to-JSON conversion  

---

## 📝 Practice Problems  

### 🔹 Basic Level  

- **Class Metadata Inspector**  
  Accept a class name from the user and display all its **methods, fields, properties, and constructors** using Reflection.

- **Private Field Access**  
  Create a `Person` class with a private field `age`. Use Reflection to read and modify its value at runtime.

- **Private Method Invocation**  
  Define a `Calculator` class containing a private method `Multiply(int a, int b)`. Invoke this method dynamically using Reflection.

- **Dynamic Object Creation**  
  Instantiate a `Student` class using `Activator.CreateInstance()` instead of the `new` keyword.

---

### 🔹 Intermediate Level  

- **Dynamic Method Executor**  
  Build a `MathOperations` class with multiple arithmetic methods. Let the user choose a method name at runtime and invoke it dynamically.

- **Custom Attribute Reader**  
  Create a custom `[Author]` attribute, apply it to a class, and retrieve its metadata using Reflection.

- **Static Field Manipulation**  
  Modify a private static field `API_KEY` inside a `Configuration` class using Reflection.

- **Constructor Discovery**  
  Retrieve and invoke different constructors of a class dynamically based on parameter types.

---

### 🔹 Advanced Level  

- **Object to JSON Converter**  
  Build a method that takes any object and generates a JSON-like string by reading its fields and properties using Reflection.

- **Execution Time Analyzer**  
  Use Reflection to invoke a method and calculate how long it takes to execute using `Stopwatch`.

- **Attribute-Based Validation System**  
  Create a custom validation attribute like `[MaxLength]` and enforce field validation at runtime using Reflection.

- **Dynamic Property Mapper**  
  Copy values from one object to another object of a different class by matching property names using Reflection.

---

## 🎯 Learning Outcomes  

By completing these exercises, you will:

- Understand runtime type inspection in C#  
- Access private, static, and hidden members safely  
- Dynamically invoke methods and create objects  
- Work with custom attributes using Reflection  
- Build generic utilities using metadata inspection  
- Apply Reflection in advanced, real-world scenarios  

---

## 👤 Author  
**Rishabh Kumar Tiwari**  
B.Tech CSE  
