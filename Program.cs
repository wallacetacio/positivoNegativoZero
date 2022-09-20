Console.Write("Digite um número: ");

Double num = Convert.ToDouble(Console.ReadLine());

if(num > 0){
    Console.WriteLine($"O número {num} é positivo!");
}else if(num < 0){
    Console.WriteLine($"O número {num} é negativo!");
}else {
    Console.WriteLine($"O número {num} é zero!");
}
Console.ReadKey();
