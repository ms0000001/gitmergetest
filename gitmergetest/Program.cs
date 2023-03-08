using System;
using System.Globalization;

namespace gitmergetest
{
    internal class Program
    {

    //{ 2023.03.08.[KMS] Rular 클래스 코드 위치 변경

        static void Main(string[] args)
        {
            //{  2023.03.08. [KMS2] 유저 입력 기능을 추가
            string userInput = string.Empty;
            Console.WriteLine("이 프로그램은 cm를 inch로 변환하는 프로그램입니다.");
            Console.Write("cm값 입력 : ");
            userInput= Console.ReadLine();

            int cmInput = 0;
            int.TryParse(userInput, out cmInput);

            Rular rular = new Rular(cmInput);
            //}  2023.03.08. [KMS2] 유저 입력 기능을 추가
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
            private set { Centimeter = (int)(value / ONE_INCH); }
        }
        public Rular(int cmValue) { Centimeter = cmValue; }
        public void Run()
        {
            Console.WriteLine($"{this.Centimeter}cm 는 {this.Inch}inch 입니다.");
        }
    }
    //} 2023.03.08.[KMS] Rular 클래스 코드 위치 변경
}