namespace estudos_c_sharp;

class Program {

    //string cor = "vermelho";
    static void Main(string[] args){
        //define o Random
        Random random = new Random();
        //dando boas vindas 
        Console.WriteLine(@"
        ***********************************
            MEU PRIMEIRO PROGRAMA EM C#
        ***********************************");
        //perguntando nome
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine()!;
        Console.WriteLine($"Olá, {nome} Seja bem-vindo!!");

        //definindo variavel de idade
        int idade;
        //perguntando a idade
        Console.WriteLine("Quantos anos você tem? ");
        //convertendo para numero
        idade = Convert.ToInt32(Console.ReadLine());
        //se for menor de 18..
        if(idade < 18){
            //exibe um texto
            Console.WriteLine("Se livrou dessa!\r\n");
            //calcula a quantidade que falta até se tonar maior de idade
            int conta = 18 - idade;
            //exibe o resultado
            Console.WriteLine($"Faltam {conta} anos para completar 18\r\n");
        }else {
            int anos = random.Next(1, 101);
            //se for maior de idade..
            Console.WriteLine($"você vai ser preso por {anos} anos\r\n");
        }

        //perguntando se o usuario deseja jogar o jogo da adivinhação
        Console.WriteLine("Deseja jogar o jogo da adivinhação? (s/n)\r\n");
        //definindo a variavel da resposta
        string resposta;
        //perguntando e pedindo a resposta em minusculas
        resposta = Console.ReadLine()!.ToLower();

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

        //se a pessoa escolher "s"
        if (resposta == "s"){
            //gera um numero de 1 a 100
            int numeroAleatorio = random.Next(1, 100);
            //mostra o número aleatório
            //Console.WriteLine(numeroAleatorio);

            //inicia um loop aleatório
            while(true){
                //pede a tentativa para o usuario
                Console.WriteLine("Digite sua tentativa\r\n");
                //pedindo o chute como numero
                int chute = Convert.ToInt32(Console.ReadLine());
        
                //fazendo a verificação para vencer
                if(chute == numeroAleatorio){
                    Console.WriteLine("conseguiu!!!");
                    break;
                //fazendo a verificação de chute a baixo do numero aleatorio gerado
                }else if(chute < numeroAleatorio){
                    Console.WriteLine("Mais para cima!");
                    Console.WriteLine("\r\n");
                //fazendo a verificação de chute a cima do numero aleatorio gerado
                }else if(chute > numeroAleatorio){
                    Console.WriteLine("Mais para baixo!");
                    Console.WriteLine("\r\n");
                }
            }
        //caso o usuario não deseje jogar
        }else{
            Console.WriteLine("Obrigado, Bye bye");
        }
    }
}