//사용자 입력(Console.ReadLine)
Console.Write("당신의 학교는?:\t");
string highschool = Console.ReadLine();
Console.WriteLine(highschool + "은 개쩌는 학교");
//문자열 연결
string first = "그래그래";
string last = "반갑다";
string message = first + ", " + last;
Console.WriteLine(message);
//문자열 보간
string name = "정민규";
Console.WriteLine($"반갑다, {name}");
//문자열 메서드
Console.WriteLine("hello".ToUpper());//ToUpper은 모든 텍스트를 대문자로 변환
Console.WriteLine("HELLO".ToLower());//ToLower은 모든 텍스트를 소문자로 변환
Console.WriteLine("c#".Replace("#", "++"));//Replace는 특정 문자를 바꿈("원래 문자", "바꿀 문자")
Console.WriteLine("abcdefghijklmnopqrstu".Length);//Length는 문자 수를 반환.

