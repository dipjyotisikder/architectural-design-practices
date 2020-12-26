using System;

namespace Liscov
{
    class Program
    {
        static void Main(string[] args)
        {

            Dove doveObject = new Dove();
            doveObject.eat();
            doveObject.fly();


            //Bird birdObject = new Bird();
            //birdObject.eat();


            Penguin PenguinObject = new Penguin();
            PenguinObject.eat();
            PenguinObject.walk();


            //Bird birdObjectByDove = new BirdCanFly();
            //birdObjectByDove.eat();
            //birdObjectByDove.fly();


            //Dove doveObjectByBird = (Dove)new Bird();
            //doveObjectByBird.eat();
            //doveObjectByBird.fly();
        }
    }
}
