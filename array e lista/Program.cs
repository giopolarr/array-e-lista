//*double[] n = new double [3]; //array

//Console.WriteLine("Digite sua nota: ");
//n[0] = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Digite sua nota: ");
//n[1]= Convert.ToDouble(Console.ReadLine());

//n[2] = (n[0] + n[1]) / 2;


//Console.WriteLine(n[2]); 

List<string> list = new List<string>();
list.Add("pedro");// adicionar elemento na lista
list.Add("cassiane");
list.Add("enzo");

Console.WriteLine(list[0]);
Console.WriteLine(list.Count); // tamanho da lista
list.Insert(0, "pedro"); // insere um elemento em uma posição que deseja mudar


foreach (string str in list)
{
    Console.WriteLine(str);
}

Console.ReadKey();

