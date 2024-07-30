namespace estudos_c_sharp;

class Program {

    //string cor = "vermelho";
    static void Main(string[] args){
        Console.WriteLine(@"
        ***********************************
            MEU PRIMEIRO PROGRAMA EM C#
        ***********************************");

        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine($"Olá, {nome} Seja bem-vindo!!");

        int idade;
        Console.WriteLine("Quantos anos você tem? ");
        idade = Convert.ToInt32(Console.ReadLine());

        if(idade < 18){
            Console.WriteLine("Se livrou dessa!");
        }else {
            Console.WriteLine("Já pode ser preso!");
        }

        Console.WriteLine("Deseja jogar o jogo da adivinhação? (s/n)");
        string resposta;
        resposta = Console.ReadLine();

        /*
        for(int i = 0; i < 11; i++){
            Console.WriteLine("Conseguii!!!!");
        } {este é um loop for}
        */

        /*
        int i = 0;
        while(i < 10){
            Console.WriteLine("Ainda não");
            i++;
            if(i == 10){
                Console.WriteLine("Consegui!!");
            }
        } {este é um loop while}
        */

        /*
        Program meuObj = new Program();
        Console.WriteLine(meuObj.cor);

        {este código é um exemplo de POO}
        */

        Random random = new Random();

        int numeroAleatorio = random.Next(1, 100);
        Console.WriteLine(numeroAleatorio);
        if (resposta == "s"){
            while(true){
                Console.WriteLine("Digite sua tentativa");
                int chute = Convert.ToInt32(Console.ReadLine());
        
                if(chute == numeroAleatorio){
                    Console.WriteLine("conseguiu!!!");
                    break;
                }if(chute < numeroAleatorio){
                    Console.WriteLine("Mais para cima!");
                    Console.WriteLine("\r\n");
                }if(chute > numeroAleatorio){
                    Console.WriteLine("Mais para baixo!");
                    Console.WriteLine("\r\n");
                }
            }
        }else{
            Console.WriteLine("Obrigado, Bye bye")
        }
        

    }


}
