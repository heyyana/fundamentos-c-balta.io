using System;
using System.Data;
using System.Diagnostics;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Guid();
           //InterString();
           //CompText();
           //SeWitch();  
           //Equals();
           //Indice();
           //MetodosAdicionais();
           //ManString();
           //StrBuilder();
        }

        static void Guid(){

            var id = Guid.NewGuid();
            id.ToString();
            id = new Guid("e587bb10-1501-41e3-8afe-478f60a88cff");          
            
            if(id == Guid.NewGuid())
            Console.WriteLine(id.ToString().Substring(0,8));

        }
    
        static void InterString()
        {
            var price = 10.2;
            
            //var text = "O preço do produto é: " + price + " apenas na promoção" ;           
            // var text = string.Format("O preço do produto é {0} apenas na promoção {1}", price, true);

            var text = $"O preço do produto é {price} apenas na promoção";
            Console.WriteLine(text);
        }

        static void CompText()
        {
            //var text = "Testando"; 
            //Console.WriteLine(text.CompareTo("Testando"));

            var text = "Esse texto é um teste";
            Console.WriteLine(text.Contains("teste"));
            Console.WriteLine(text.Contains("Teste", StringComparison.OrdinalIgnoreCase));    

        }
    
        static void SeWitch()
        {
            var text = "Este texto é um teste";

            Console.WriteLine(text.StartsWith("Este"));
            Console.WriteLine(text.StartsWith("este", StringComparison.OrdinalIgnoreCase)); 
            Console.WriteLine(text.StartsWith("este")); 
            Console.WriteLine(text.StartsWith("texto"));

            Console.WriteLine("-----------------------------------------------------------------------------");

            Console.WriteLine(text.EndsWith("teste"));    
            Console.WriteLine(text.EndsWith("Teste", StringComparison.OrdinalIgnoreCase)); 
            Console.WriteLine(text.EndsWith("Teste")); 
            Console.WriteLine(text.EndsWith("xpro"));

        }

        static void Equals()
        {
            var text = "Este texto é um teste";
            Console.WriteLine(text.Equals("Esse texto é um teste"));
            Console.WriteLine(text.Equals("esse texto é um teste"));
            Console.WriteLine(text.Equals("Esse texto é um teste", StringComparison.OrdinalIgnoreCase));
        } 
    
        static void Indice()
        {
            var text = "Este texto é um teste";
            Console.WriteLine(text.IndexOf("é"));
            Console.WriteLine(text.IndexOf("um"));
            Console.WriteLine(text.LastIndexOf("s"));            
        }
    
        static void MetodosAdicionais()
        {
            var text = "Este texto é um teste";

            //converter todo o texto para minusculo.
            Console.WriteLine(text.ToLower());

            //converter todo o texto para maiusculo.
            Console.WriteLine(text.ToUpper());

            // inserir na quinta posição o texto nas aspas.
            Console.WriteLine(text.Insert(5,"AQUI"));

            //a partir dos Quinto caractere remover os proximos             
            Console.WriteLine(text.Remove(5,5));

            //quantidade de caracteres que uma string tem
            Console.WriteLine(text.Length);

        }
    
        static void ManString()
        {
            var text = "Este texto é um teste";

            //troca uma palavra por outra, com case sensitive
            Console.WriteLine(text.Replace("Este", "isto"));
            
            //troca todo o e minusculo por X maiusculo
            Console.WriteLine(text.Replace("e", "X"));

            //divide o texto
            var divisao = text.Split("");
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);
            Console.WriteLine(divisao[3]);

            var resultado = text.Substring(5, 5);
            Console.WriteLine(resultado);

            //remove todos os espaços do começo e do final da string
            Console.WriteLine(text.Trim());
        }
    
        static void StrBuilder()
        {
            var text = new StringBuilder();

            text.Append("Este texto é um teste");
            text.Append("Este texto é um teste");
            text.Append("Este texto é um teste");
            text.Append("Este texto é um teste");
            text.Append("Este texto é um teste");

            Console.WriteLine(text);            
        }
    }
}