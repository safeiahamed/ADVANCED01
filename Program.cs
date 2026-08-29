namespace AssignmentAdv_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //What is a generic class? Why use generics?
            //Ans->Class that allow you to write classes with type parameters
            //Why->-Type Safe , Code Reusability, Better Performance, Cleaner Code
            #endregion

            #region Q2
            //Write a generic class Container<T> with Add and Get methods
            Container<int> C1 = new Container<int>();
            C1.Add(1);
            C1.Get();
            #endregion

            #region Q3
            //Q3:What are multiple type parameters? Write Pair<TKey,TValue >
            //Can use multiple type of parameters

            Pair<int, string> pair = new Pair<int, string>(1, "hello");

            #endregion

            #region Q4
            //What is a generic method? Write Swap<T> method.
            //allows you to use different Data types
            int a = 10;
            int b = 5;
            Swap<int>(ref a, ref b);

            #endregion

            #region Q5
            //Write a generic method FindMax<T> that finds maximum value
            int x = 10;
            int y = 5;
            FindMax<int>(x, y);
            #endregion

            #region Q6
            //What is a generic interface? Write IRepository<T>
            //allow type of parameter
            IRepository<int> repository = null;
            #endregion

            #region Q7
            //What is the 'struct' constraint? Write an example.
            //it allow you to use value type only
            StructTest<int> test = new StructTest<int>(3);
            #endregion

            #region Q8
            //What is the 'class' constraint? Write an example.
            //it allow you to use refernce type only
            ClassTest<string> classTest = new ClassTest<string>("hello");
            #endregion

            #region Q9
            //What is the 'new()' constraint? Write an example.
            //Class must contain Parameterless constructor
            // parameterLessTest<T> class

            #endregion

            #region Q10
            //What is the interface constraint? Write an example
            //T must implement interface
            //Class InterfaceTest

            #endregion

            #region Q11
            //What is the base class constraint? Write an example.
            //T or it is derived types must inherit from Bais Class
            // Class ClassTest2
            #endregion

            #region Q12
            //How do you apply multiple constraints? Write an example.
            // Where T : Base class,new()
            //ex: class multipleConstraintsTest
            #endregion

            #region Q13
            //What does the 'default' keyword do in generics?
            //it return default value for Type T[0 for value type, null for reference type]
            #endregion

            #region Q14
            //Write a SafeList<T> that returns default when the index is invalid
            SafeList<int> safeList= new SafeList<int>();
            safeList.Add(1);
            safeList.Add(2);
            safeList.GetById(-1);

            #endregion

            #region Q15
            //What is covariance? Explain the 'out' keyword
            //It allows a generic type with a more derived type to be assigned to a generic type with a base type
            //when the type is used as output
            //out → Output → Covariance
            #endregion

            #region Q16
            //What is contravariance? Explain the 'in' keyword
            //It allows a generic type with a base type to be assigned to a generic type with a derived type
            //when the type is used as input
            //in  → Input  → Contravariance
            #endregion

            #region Q17
            //What is the difference between covariance and contravariance ?
            //Covariance uses the out keyword it is used when the generic type is used as an output
            //Contravariance uses the in keyword it is used when the generic type is used as an input
            #endregion

            #region Q18
            //How do static members work in generic types?
            //there is independent copy for each type[like Counter]
            #endregion

            #region Q19
            //How can you inherit from a generic class?
            //you can inherit from a generic class easily by define the type of T of Base class
            #endregion

            #region Q20
            /*Complete Exercise - Create a generic Cache<TKey,
              TValue>with Add, Get, Remove, Contains, and expiration support.
            */
            Cache<int,string> cache = new Cache<int,string>();
            cache.Add(1, "hello");
            cache.Add(2, "ali");
            cache.Add(3, "Ahmed");
            Console.WriteLine(cache.Get(3));
            cache.Remove(3);
            #endregion


        }
        #region Q4
        public static void Swap<T>(ref T a, ref T b)
        {
            T c = a;
            a = b; b = c;
        }

        #endregion

        #region Q5
        //Write a generic method FindMax<T> that finds maximum value
        public static T FindMax<T>(T a, T b) where T : IComparable<T>
        {
            if (a.CompareTo(b) > 0) return a;
            return b;

        }
        #endregion

    }
}

