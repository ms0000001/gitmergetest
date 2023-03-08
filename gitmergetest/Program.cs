using System;

namespace gitmergetest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rular rular = new Rular(10);
            rular.Run();
        }
    }

    public class Rular
    {
        private const float ONE_INCH = 2.54f;
        public int Centimeter { get; set; } = 0;
        public float Inch
        {
            get { return Centimeter* ONE_INCH; }
            // { 2023.03.08. [KMS3] private SetInch 함수를 새로 추가
            private set { this.SetInch(value); }
        }
        public Rular(int cmValue) { Centimeter = cmValue; }
        public void Run()
        {
            Console.WriteLine($"{this.Centimeter}cm 는 {this.Inch}inch 입니다.");
        }

        private void SetInch(float inchValue) { Centimeter = (int)(inchValue / ONE_INCH); }
            // } 2023.03.08. [KMS3] private SetInch 함수를 새로 추가
    }
}