using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace csharpp
{
    internal class Program
    {
        static void Main()

        {
            { CollectionExample4 example4 = new CollectionExample4();
                example4.StackFun();//Stack Example 

                example4.QueueFub();//Queue Example 
            }
            

            //Collection example3 : SortedList Example //non Generic and Generic 
            {
                Collection_Example3 Example3 = new Collection_Example3();
                Example3.SortedListFun();//Non-Generic Collection   

                Example3.SortedListFun1();//Generic Collection  
            }   
            
            //Collection example2 : Hashtable Example 
            {
                CollectionExample2 Example2 = new CollectionExample2();
                Example2.HasdhtableFun();
            }   
           

            //Collection Example1 : ArrayList Example 
                         { 
            CollectionExample1 Example = new CollectionExample1();
            Example.ArrayListfun();

            }

            
            /// File Handling Example6  // create, write, append, read file using short method and try catch    
            {
                SHORT_METHOD_FileHadlingCWARD_Using_Exception_try_catch_Example6 obj12 = new SHORT_METHOD_FileHadlingCWARD_Using_Exception_try_catch_Example6();
                obj12.createfile();
                obj12.addContentOnFile();
                obj12.appendContentOnFile();
                obj12.readFileOperation();
            }



            /// File Handling Example4  // create, write, append, read file using try catch 
            {
                FileHadlingCWARD_Using_Exception_try_catch_Example4 obj14 = new FileHadlingCWARD_Using_Exception_try_catch_Example4();
                //obj.readFileOperation();    

                obj14.createfile();
                obj14.addContentOnFile();
                obj14.appendContentOnFile();
                obj14.readFileOperation();

            }



            /// File Handling Example1  // create and write on file 
            {
                FileHandlingExample1 obj = new FileHandlingExample1();
                obj.createfile();
            }

            /// File Handling Example2  // create, write and append on file
            {
                FileHandlingExample2_Append obj13 = new FileHandlingExample2_Append();
                obj13.createfile();
                 obj13.addContentOnFile();
                 obj13.appendContentOnFile();
            }

            /// File Handling Example3  // read and delete file   
            {
                FileHandlingExample3_Read obj1 = new FileHandlingExample3_Read();

                obj1.readFileOperation();
                obj1.deleteFileOperation();
            }


            ///6.2 Arithmatic operations using class and object Add,Sub,Mul,Div 
            static void Main()
            {
                operationcs obj = new operationcs();
                obj.accept();
                obj.add();
                obj.sub();
                obj.mul();
                obj.div();
            }


            ///7.2 Simple Interest Calculation using class and object   
            {
                SI obj = new SI();
                obj.CalcSI();
            }

            ///9.2 Static method and non static method Example  
            {
                A str = new A();
                str.fun1();
                A.fun();

            }

            ///11.2 Swap two numbers using class and object Example 
            {
                SwapProgram.Swap();

            }///13.2 Data types in C# Example  
            {
                Datatype D = new Datatype();
                D.PDatatype();
                D.DDatatype();
            }

            { ///29.2 Employee class using class and object Example 
                EmployeeForClass obj1 = new EmployeeForClass();
                obj1.Accept(1, "John", 50000);
                obj1.Display();

            }
            ///31.2 Member function Parameter 1 No parameter no return type Example 
            {
                MemberFunction_Parameter1_no_parameter_no_return_type obj3 = new MemberFunction_Parameter1_no_parameter_no_return_type();
                obj3.squre();
            }
            ///33.2 Member function Parameter 4 Parameter with return Type Example  
            {
                MemberFunction_Parameter_4_Parameter_with_return_Type obj4 = new MemberFunction_Parameter_4_Parameter_with_return_Type();
                int d = obj4.squre(32);
                Console.WriteLine(d);
            }
            { ///34.2 Constructor Example1  Default Constructor 
                ConstructorExample1 obj5 = new ConstructorExample1(12);
                { }
            }
            { ///35.2 Constructor Example2  Parameterized Constructor 
                ConstructorExample2 obj6 = new ConstructorExample2(4, 5);
                { }
            }
            { ///36.2 Constructor Example3  Copy Constructor 
                ConstructorExample3 obj7 = new ConstructorExample3(12, 17);
                ConstructorExample3 obj8 = new ConstructorExample3(obj7);
                { }
            }

            ///37.2 Property Example1  Auto-Implemented Property    
            {
                PropertyExample1 obj9 = new PropertyExample1();
                obj9.Width = 20;//aerrer
                Console.WriteLine(obj9.Width);//getter  

                obj9.Height = 30;//setter
                Console.WriteLine(obj9.Height);//getter 

            }
            ///40.4 Inheritance Example1  Single Inheritance    
            {
                inheritanceC obj6 = new inheritanceC();
                obj6.fun();
                obj6.fun2();
                obj6.fun();


            }
            ///41.3 inheritance object reference Example2  Multilevel Inheritance  

            {
                AbstractClassExample1 obj7 = new AbstractCHILDClass2();
                obj7.Accept(12, 32);
                obj7.rectangle();
                obj7.Display();

                AbstractClassExample1 obj8 = new AbstractCHILDClass2();
                obj8.Accept(12, 3);
                obj8.trangle();
                obj8.Display();

            }

            ///42.6 Access Specifire Example1  Public Access Specifire  
            {
                AcsessSpecifire obj9 = new AcsessSpecifire();
                obj9.fun5();//public    
            }

            {
                ///43.3 interface object reference Example3  Interface   
               /* FIRST obj10 = new INTERFACE_implement_Example3();
                obj10.fun1();
                obj10.fun2();

                SECOND obj11 = new INTERFACE_implement_Example3();
                obj11.fun1();
                obj11.fun2();
                obj11.fun3();*/
            }
            { ///44.3 Method Overriding Example1  Method Overriding 
                BILLOverriding obj12 = new BILLOverriding();
                Console.WriteLine(obj12.calcBill(13333));

            }
            ///46.6 Exception handling negative number exceptipn Example5  User defined Exception
            {
                int num;
                try
                {
                    Console.WriteLine("Enter Number");
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num < 0)
                    { 

                        throw new Exception_handling_negative_number_exceptipn_Example5();


                    }
                    Console.WriteLine("Number is " + num);

                }
                catch (Exception_handling_negative_number_exceptipn_Example5 ex)
                {
                    Console.WriteLine(ex.Message);
                }


            }

            
        }
    }
}