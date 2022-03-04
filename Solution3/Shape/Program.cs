using System;
namespace Shape{
    interface Shape{
        double getArea();
        bool IsRightShape();
    }
    class Rectangle:Shape{
        private double length;
        public double Length { get; set; }
        private double width;
        public double Width{ get; set; }
        public Rectangle(double length,double width){
            this.length = length;
            this.width = width;
        }
        public double getArea(){
            return length * width;
        }
        public bool IsRightShape(){
            if(length<0||width<0){
                return false;
            }
            return true;
        }
    }
    class Square:Shape{
        private double sideLength;
        public double SideLength{ get; set; }
        public Square(double sideLength){
            this.sideLength = sideLength;
        }
        public double getArea(){
            return sideLength * sideLength;
        }
        public bool IsRightShape(){
            if(sideLength<0){
                return false;
            }
            return true;
        }
    }
    class Triangle:Shape{
        private double sideOne, sideTwo, sideThree;
        public double SideOne{ get; set; }
        public double SideTwo{ get; set; }
        public double SideThree{ get; set; }
        public Triangle(double sideOne,double sideTwo,double sideThree){
            this.sideOne = sideOne;
            this.sideTwo = sideTwo;
            this.sideThree = sideThree;
        }
        public double getArea(){
            double p = (sideOne + sideTwo + sideThree) / 2.0;
            return Math.Sqrt(p * (p - sideOne) * (p - sideTwo) * (p - sideThree));
        }
        public bool IsRightShape(){
            double p = (sideOne + sideTwo + sideThree) / 2.0;
            if((p-sideOne)<0||(p-sideTwo)<0||(p-sideThree)<0){
                return false;
            }
            return true;
        }
    }
    class ShapeFactory{
        public static Shape getShape(string shapeName,double length,double width,double sideLength,double sideOne,double sideTwo,double sideThree){
            Shape shape = null;
            if(shapeName=="Rectangle"){
                return new Rectangle(length, width);
            }
            else if(shapeName=="Square"){
                return new Square(sideLength);
            }
            else if(shapeName=="Triangle"){
                return new Triangle(sideOne,sideTwo,sideThree);
            }
            return shape;
        }
    }
    class Test{
        static void Main(string[] args){
            double areaSum = 0;
            Shape shape = new Rectangle(0,0);
            Random r = new Random();
            for (int i = 0; i < 10; i++){
                int shapeNum = r.Next(1, 4);
                switch(shapeNum){
                    case 1:
                        shape = ShapeFactory.getShape("Rectangle", shapeNum * 3, shapeNum * 2, 0, 0, 0, 0);
                        break;
                    case 2:
                        shape = ShapeFactory.getShape("Square", 0, 0, shapeNum * 2, 0, 0, 0);
                        break;
                    case 3:
                        shape = ShapeFactory.getShape("Triangle", 0, 0, 0, shapeNum * 2, shapeNum * 2, shapeNum * 3);
                        break;
                    default:
                        break;
                }
                if(shape.IsRightShape()){
                    areaSum = areaSum + shape.getArea();
                }
                else
                    Console.WriteLine("The shape is wrongly input.");
            }
            Console.WriteLine("The area of the ten shapes is {0}", areaSum);
            Console.ReadKey();
        }
    }
}