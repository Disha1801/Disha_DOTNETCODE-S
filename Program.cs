// See https://aka.ms/new-console-template for more information
using CommanLibrary;
using CommanLibrary._0_CSharp_Basics;
using CommanLibrary._0_CSharp_Basics.CommonLIbrary.CSharp_Basics;
using CommanLibrary._01_OOPS;
using CommanLibrary._01_OOPS.Inheritance;
using CommanLibrary._01_OOPS.Polymorpshism;
using CommanLibrary.Practice;
using static CommanLibrary._0_CSharp_Basics.Readonly_Constant;
using static CommanLibrary._01_OOPS.APublicClassToOtherAccessModifier;
using static CommanLibrary._01_OOPS.StaticKeyword;
//using CommanLibrary._0_CSharp_Basics;
//using CommanLibrary._01_OOPS;

Console.WriteLine("Hello, World!");
Optionalparameter obj=new Optionalparameter();
obj.optionalParameter(10,20);
Console.WriteLine("Below is example of method over-loading");
obj.optionalParameter(20,30,40);
Out_Ref_Keyword obj1=new Out_Ref_Keyword();

obj1.demo();
obj1.ex1();
obj1.ex2();
Console.WriteLine("***********************************Compound Interset************************************************************");
Compound_Interest c = new Compound_Interest();
//c.Compound();
Console.WriteLine("************************************************************************************************");

//Class_Object ObjClass_Object_one= new Class_Object();
//ObjClass_Object_one.DemoClassObject_one();
//ObjClass_Object_one.DemoClassObject_two();
//Console.WriteLine(ObjClass_Object_one.Name);
//Console.WriteLine(ObjClass_Object_one.ID);
//Console.WriteLine(ObjClass_Object_one.Name_not_to_beset="SEttedinprogramclass");
//Class_Object ObjClass_Object_two = new Class_Object();


//Console.WriteLine("_______________________________");

//constantexample.circle_area();

Console.WriteLine("**************Object creation with inheritance****************");
ParentClass parent=new ParentClass();   
//I.Q=>ParentClass is type and parent is container and we are putting new value of 
//parent class type

//ChildClass child=new ChildClass();


//Most Important
//ChildClass childClassOne = new ParentClass(); Invalid(compiletime error)
//ChildClass childClassOne =(ChildClass) new ParentClass(); Invalid(Runtime error)


ParentClass parent2 =new ChildClass();
//this childclass will initialize memory of
//parentclass as well as of child class

Console.WriteLine("**********Method Overriding*****************");

MyClassOne obj11=new MyClassOne();
obj11.Show();
obj11.Show("hii");

MyClassTwo obj12=new MyClassTwo();
obj12.Show();//"parent method" will be printed 
obj12.Show("Hellooooooooo");//"Hellooooooooooooo "will be printed


//=> For line number 63:1st myclassone constructor will be called 
//2nd=>myclasstwo constructor will be called

//MyClassTwo obj13 = new MyClassOne();//Parent Instance =>compile time error


//MyClassTwo obj14 = (MyClassTwo)new MyClassOne();//this will give run time error


//parent type ka object chilld type ke object ko conatin kar sakta hain


MyClassOne obj15 = new MyClassTwo();
obj15.Show();
//IT WILL GO TO MyClassOne show method bcz we dont have Show() method in MyClassOne
obj15.Show("how are u");//this will also go to MyClassOne that is parent one

//So basically container jiska rahega uska method hi call hoga 













Console.WriteLine("*********************************************************************************************************************************" +
    "**************");
Console.WriteLine("****************************************************************************************************************************" +
    "******************************************************************************");





//Console.WriteLine("Hello, World!");
//Class1 obj = new Class1();
//obj.show("Hello");

Operator op = new Operator();
op.DemoOperator();
op.DemoArray();
Console.WriteLine("---------------------------");
op.DemoOptionalParameter(35);
op.DemoOptionalParameter(10, 25);
op.DemoOptionalParameter(10, 10, 25);
op.DemoOptionalParameter("sebastian");
op.DemoOptionalParameter("John", "Doe");

Console.WriteLine("----------------------------");
Out_Ref_keyword2 ork = new Out_Ref_keyword2();
ork.Demo();

Console.WriteLine("--------------------------------");
//Console.WriteLine("Enter the Principle: ");
//double amount = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Enter the time: ");
//double time = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Enter the rate: ");
//double rate = Convert.ToDouble(Console.ReadLine());

//CompoundInterest ci = new CompoundInterest();
//ci.Calculate(amount,time,rate);

Console.WriteLine("-------------global varibale-----------------");
Class_Object2 objo = new Class_Object2(); //execution flow:static ctor->global varibale->default ctor->method
Console.WriteLine(objo.a);
Console.WriteLine(objo.str);

objo.a = 456;
objo.str = "Hiiii";
Console.WriteLine(objo.a);
Console.WriteLine(objo.str);

Console.WriteLine("-----------------Properties----------------------");
Console.WriteLine(objo.Name);
Console.WriteLine(objo.ID);

objo.Name = "Daniel";
objo.ID = 102;

Console.WriteLine(objo.NameNotSet);
//obj.NameNotSet = "fhjgjs"; //error

Console.WriteLine(objo.Name);
Console.WriteLine(objo.ID);

Console.WriteLine("-------------------");
objo.Demo1();
objo.Demo2();

//example of indexer
Console.WriteLine("------------------Indexer------------------------");
Class_Indexer index = new Class_Indexer();
index[0] = "Hibiscus";
index[1] = "Hyacinth";
//index[2] = "Orchid";
index[3] = "Carnation";
//index[4] = "Lily";
index[5] = "Lavender";

//example of array
index.arr = new string[10];
index.arr[0] = "1";
index.arr[2] = "2";
index.arr[5] = "5";



//not ableto run foreach on the object index as it is not a collection
//foreach (var i in index)
//{
//    Console.WriteLine(i);
//}

//print indexers value using for loop
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(index[i]);
}

Console.WriteLine("-----------------------Access Modifier-----------------------");

//internal class can't be accessed outside in other project
//ClassWithOutAcsessModifier obj = new ClassWithOutAcsessModifier(); //error

ClassWithPublic classwithpublic = new ClassWithPublic(); //works fine

AClassWithPublic cwp = new AClassWithPublic();

Console.WriteLine("----------------Static keyword--------------------------");

//can't create an instance of the static class
//MyStaticClass sk = new MyStaticClass();

//this is how you callfunctions of a static class. As we can'tcreate the object explicitly and the CLR will create it and keep it when the application start first
MyStaticClass.MyFunction();

//below is not allowed for static method as you can't access static method with the reference of the class
NonStaticClass nonstatic = new NonStaticClass();
//nonstatic.StaticMethod(); //not allowed

//static method is called using the name of the class
NonStaticClass.StaticMethod(); //valid


//NonStaticClassVar nonstaticv = new NonStaticClassVar();
//nonstaticv.Id; //not allowed
Console.WriteLine(NonStaticClassVar.Id);

NonStaticClassVar.Id += 1; //valid
NonStaticClassVar nonstaticv = new NonStaticClassVar();

Console.WriteLine(NonStaticClassVar.Id);
//Console.WriteLine(nonstaticv.Id);

//Console.WriteLine("-------------------Area of a circle--------------------------");
//Area a = new Area();
//a.areaOfCircle();

Console.WriteLine("------------------------------------------------------");

//Teacher t = new Teacher() { Id = 1 };==>init does not support ,if it support in ur's the u can uncomment this
//t.Id = 101; //error,we cannot assign it later

Teacher t1 = new Teacher();
//t1.Id = 109; //error,we cannot initialize it 

Console.WriteLine("------------------Method overloading --------------------------------");
//MethorOverloading ml = new MethorOverloading();
//ml.Method("hi");

//Console.WriteLine("------------------------------------------");
//Parent p = new Parent(); //Prent constructor is called
//Console.WriteLine(p.About());//See you soon345 Rabale

//Child c = new Child(); //Parent constructor is called 
                       //Child contructor is called
//Console.WriteLine(c.About()); //See you soon345 Rabale
//Console.WriteLine(c.build()); //See you soon123 Parel

//Console.WriteLine("------------------------------------------");
//Parent1 p1 = new Parent1();
//Console.WriteLine(p1.About());

//Child1 c1 = new Child1();
//Console.WriteLine(c1.About());
//Console.WriteLine(c1.build());

Console.WriteLine("----------------object creation with inheritance-----------------------");
ParentClass pc = new ParentClass(); //valid
ChildClass cs = new ChildClass(); //valid

//ChildClass cs1 = new ParentClass(); //invalid,compile time error

//ChildClass cs2 =(ChildClass) new ChildClass(); //invalid,runtime error

ParentClass pc1 = new ChildClass(); //valid

Console.WriteLine("------------------------------------------------");
//MyClass1 mc1 = new MyClass1(3); //3 
//MyClass2 mc2 = new MyClass2(3); //in parent constructor 
                                //3

Console.WriteLine("---------------------method overriding---------------------------");
//parent class can only access its own member and properties 
//MyClass1 mc12 = new MyClass1();
//MyClass2 mc22 = new MyClass2();
//mc12.show(); //will always run from MyClass1 as it present there
//mc12.show("hii");
//mc22.show();
//mc22.show("heloooooooo");

//MyClass1 mc3 = new MyClass2();
//mc3.show();
//mc3.show("hioolloioa");

Console.WriteLine("-----------------------override and virtual-------------------------");
MyParent mp = new MyChild();
//mp.show();
//mp.show("hellllooooo");