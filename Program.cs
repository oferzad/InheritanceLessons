using System.Globalization;

namespace InheritanceLessons
{
    internal class Program
    {
        static int CountColor(Shape[] arr, string color)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].GetColor() == color)
                    count++;
            }
            return count;
        }

        static int MaxTriangle(Shape[] arr, int max)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Triangle)
                {
                    Triangle triangle = (Triangle) arr[i];
                    if (triangle.GetHeightLength() > max)
                        count++;
                }
                    
            }
            return count;
        }

        static double SumArea(Shape[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                //למה זה הסדר של ההתניות?
                if (arr[i] is Triangle)
                {
                    Triangle triangle = (Triangle)arr[i];
                    sum += triangle.GetArea();
                }
                else if (arr[i] is Square)
                {
                    Square square = (Square)arr[i];
                    sum += square.GetArea();
                }
                else if (arr[i] is Rectangle)
                {
                    Rectangle rectangle = (Rectangle)arr[i];
                    sum += rectangle.GetArea();
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            #region POLYMORPHISM
            //Lesson plan
            //1. SHow the story of the Shape classes and draw the UML diagram
            //2. Show the code of the Shape classes
            //3. SHow the Square code and explain the concept
            //4. Write a program that creates objects of each class and prints the area of each object
            Triangle t1 = new Triangle("blue", 10, 5);
            Rectangle r1 = new Rectangle("red", 10, 5);
            Square s1 = new Square("brown", 10);
            Console.WriteLine(t1.GetColor());
            Console.WriteLine(r1.GetArea());
            Console.WriteLine(s1.GetArea());
            //5. Explain the concept of polymorphism, including upcasting and downcasting. Write a program that demonstrates it.
            Shape shape1 = (Shape)t1;


            //6. Explain the concept of reflection and teach the is operator. Write a program that demonstrates it.
            Triangle r2;
            if (shape1 is Triangle)
                r2 =  (Triangle)shape1;

            //7. Write a program that creates an array of Shape objects and prints the area of each object (after downcastign to the appropriate type)
            Shape[] shapes = new Shape[4];
            shapes[0] = new Triangle("blue", 20, 4);
            shapes[1] = new Square("Green", 15);
            shapes[2] = new Rectangle("White", 14, 12);
            shapes[3] = new Square("Yellow", 9);

            int count = 0;
            for (int i = 0; i < shapes.Length; i++)
            {
                if (shapes[i] is Square)
                    count++;
            }
            Console.WriteLine("Number of squares is " + count);

            for (int i = 0; i < shapes.Length; i++)
            {
                if (shapes[i] is Triangle)
                {
                    Triangle temp = (Triangle)shapes[i];
                    Console.WriteLine(temp.GetHeightLength());
                }
                else
                {
                    Console.WriteLine(shapes[i].GetColor());
                }
            }
            #endregion
            #region Overloading with Polymorphism
            //Lesson plan
            //1. Make a short rehersal of the last lesson by writing several castings and ask the students to find the errors
            //2. Explain the concept of overloading with polymorphism
            //3. Draw the UML diagram of the classes and demonstrate the concept of overloading with polymorphism
            //4. Do the exercises from the page

            #endregion
            
        }

    }
}
