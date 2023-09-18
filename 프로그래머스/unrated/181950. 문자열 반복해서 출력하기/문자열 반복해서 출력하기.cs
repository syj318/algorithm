using System;

public class Example
{
    public static void Main()
    {
        String[] input; //문자열 배열 input 선언

        Console.Clear();
        input = Console.ReadLine().Split(' '); //입력 받고, 입력된 문자열을 공백 문자를 기준으로 나누어 문자열 배열로 저장

        String s1 = input[0]; //입력된 문자열 배열의 첫번째 요소를 (input[0]) s1 문자열 변수에 저장 (String s1)
        int a = Int32.Parse(input[1]); //엽력된 문자열 배열의 두번째 요소를 정수로 변환하여 a 변수에 저장
        
        for (int i=0; i<a; i++) //a번 반복하는 for 루프
        { Console.Write(s1); } //s1에 저장된 문자열을 a번 출력
    }
}
