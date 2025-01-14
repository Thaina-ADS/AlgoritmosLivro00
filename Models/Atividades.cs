// Pets : Id, Nome, Raça, Espécie, Sexo, Idade
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

// INICIO ATIVIDADE 7 ------------------------------------------------------------------
/* CONTEXTO: Fazer a leitura de quatro valores numéricos inteiros representados pelas variáveis A, B, C e D. Apresentar apenas os valores que sejam divisíveis por 2 e 3.
 * 
 * ENTENDIMENTO: 
 * 1. Leitura de quatro valores numericos
 * 2. Apresentar os valores que sejam divisíveis por 2 e 3.
 */

namespace AtividadeLivro108109.Models
{
    public class Divisiveis
    {
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }
        public int Numero3 { get; set; }
        public int Numero4 { get; set; }

        public Divisiveis(int numero1, int numero2, int numero3, int numero4)
        {
            Numero1 = numero1;
            Numero2 = numero2;
            Numero3 = numero3;
            Numero4 = numero4;
        }
    }
}




// FIM ATIVIDADE 7 ---------------------------------------------------------------------



// INICIO ATIVIDADE 6 ------------------------------------------------------------------
/* CONTEXTO: Ler três valores inteiros representados pelas variáveis A, B e C e apresentar os valores lidos dispostos em ordem crescente. Dica: utilizar tomada de decisão sequencial
 * e as ideias trabalhadas nos exercícios "g" (propriedade distributiva) e "f" (troca de valores) do Capítulo 3.
 * 
 * ENTENDIMENTO:
 * 1. Ler tres valores inteiros A, B, C
 * 2. Apresentar os valores lidos dispostos em ordem crescente
 * */

//namespace AtividadesLivro108109.Models
//{
//    public class ValoresCrescentes
//    {
//        public int Quarenta { get; set; }
//        public int Vinte { get; set; }
//        public int Dez { get; set; }

//        public string Bia { get; set; }
//        public string Ana { get; set; }
//        public string Dani { get; set; }

//        public ValoresCrescentes(int quarenta, int vinte, int dez, string bia, string ana, string dani)
//        {
//            Quarenta = quarenta;
//            Vinte = vinte;
//            Dez = dez;

//            Bia = bia;
//            Ana = ana;
//            Dani = dani;    
//        }

//        public int[] IdadesCrescentes(int quarenta, int vinte, int dez)
//        {
//            int[] idadesCrescente = { quarenta, vinte, dez };
//            Array.Sort(idadesCrescente);

//            return idadesCrescente;
//        }

//        public string[] NomesCrescentes(string bia, string ana, string dani)
//        {
//            string[] nomesCrescente = { bia, ana, dani };
//            Array.Sort(nomesCrescente);

//            return nomesCrescente;
//        }


//    }
//}



// FIM ATIVIDADE 6 ---------------------------------------------------------------------



// INICIO ATIVIDADE 5 ------------------------------------------------------------------
/* CONTEXTO: Efetuar a leitura de três valores numéricos (representados pelas variáveis A, B e C) e processar o cálculo da equação completa de segundo grau, utilizando a fórmula 
 * de Bhaskara (considerar para a solução real, delta < 0 - não há solução real, delta > 0 - há duas soluções reais e diferentes e delta = 0 - há apenas uma solução real). Lembre-se
 * de que é completa a equação de segundo grau que possui todos os coeficientes A, B e C diferentes de zero. O programa deve apresentar respostas para todas as condições 
 * estabelecidas para delta
 * 
 * ENTENDIMENTO:
 * 
 * 1. Leitura tres valores numericos (A, B, C)
 * 2. Processar o cálculo da equação completa de segundo grau, utilizando Bhaskara
 * 3. Considerações: 
 *      delta < 0 - não há solução real
 *      delta > 0 - há duas soluções reais
 *      delta = 0 - há apenas uma solução real
 * 4.Equação de segundo grau deve ser completa A, B e C diferentes de zero
 * 5. Apresentar respostas para todas as condições estabelecidas para delta
 **/


//namespace AtividadesLivro108109.Models
//{
//    public class EquacaoSegundoGrau
//    {
//        public double A { get; set; }
//        public double B { get; set; }
//        public double C { get; set; }

//        public EquacaoSegundoGrau(double a, double b, double c) 
//        {
//            A = a;
//            B = b; 
//            C = c;  
//        }

//        public string CalcularBhaskara(double a, double b, double c)
//        {

//            double delta = (b * b) - (4 * a * c);

//            if (delta < 0)
//            {
//                return "Não há soluções reais.";
//            }else if (delta == 0)
//            {
//                double x = - b / (2 * a);
//                return $"Há apenas uma solução real: {x}";
//            }else
//            {
//                double raizDelta = (delta);
//                double x1 = (- b + raizDelta) / (2 * a);
//                double x2 = (- b - raizDelta) / (2 * a);

//                return $"Há duas soluções reais e diferentes: {x1} e {x2}";
//            }
//        }   
//    }
//}

// FIM ATIVIDADE 5 ---------------------------------------------------------------------


// INICIO ATIVIDADE 4 ------------------------------------------------------------------
/* Ler os valores de quatro notas escolares bimestrais de um aluno representadas pelas variáveis N1, N2, N3 e N4. Calcular a média aritmética (variável MD1) desse aluno e apresentar a
 * mensagem "Aprovado" se a média obtida for maior ou igual a 7; caso contrário, o programa deve solicitar a quinta nota (nota de exame, representada pela variável NE) do aluno e 
 * calcular uma nova média aritmética (variável MD2) entre a nota de cinco, apresentar a mensagem "Aprovado em exame", caso contrário, apresentar a mensagem "Reprovado". Informar, 
 * após a apresentação das mensagens, o valor da média obtida pelo aluno
 * 
 * ENTENDIMENTO: 
 * 
 * 1. Ler quatro notas (N1,N2,N3,N4)
 * 2. Calcular a média aritmética (variavel MD1)
 * 3. Apresentar mensagem "Aprovado" se a média for igual ou maior a 7
 * 4. Caso contrário, solicitar a quinta nota (nota exame, variavel NE)
 * 5. Calcular uma nova media aritmetica (variavel MD2) entre a nota de cinco
 * 6. Apresentar a mensagem "Aprovado em exame", caso contrario, apresentar a mensagem "Reprovado"
 * 7. Informar após a apresentação das mensagens, o valor da media obtida.
 * */

//namespace AtividadesLivro108109.Models
//{
//    public class CalculandoMedia
//    {
//        public int Id { get; set; }
//        public decimal Nota1 { get; set; }
//        public decimal Nota2 { get; set; }
//        public decimal Nota3 { get; set; }
//        public decimal Nota4 { get; set; }

//        public CalculandoMedia(decimal nota1, decimal nota2, decimal nota3, decimal nota4)
//        {
//            Nota1 = nota1;
//            Nota2 = nota2;
//            Nota3 = nota3;
//            Nota4 = nota4;
//        }

//        public decimal MediaFinal1(decimal nota1, decimal nota2, decimal nota3, decimal nota4)
//        {
//            decimal mediaFinal = (nota1 + nota2 + nota3 + nota4) / 4;
//            return mediaFinal;
//        }

//        public string VerificaAprovacao(decimal nota1, decimal nota2, decimal nota3, decimal nota4)
//        {
//            decimal mediaFinal = MediaFinal1(nota1, nota2, nota3, nota4);
//            if (mediaFinal >= 7)
//            {
//                return "Aprovado!";
//            } else
//            {
//                decimal mediaFinal2 = mediaFinal / 2;

//                if (mediaFinal2 >= 5)
//                {
//                    return "Aprovado em exame!";
//                } else
//                {
//                    return "Reprovado.";
//                }
//            } 
//        }
//    }
//}

// FIM ATIVIDADE 4 ---------------------------------------------------------------------


// INICIO ATIVIDADE 3 ------------------------------------------------------------------

// CONTEXTO: Realizar a leitura dos valores de quatro notas escolares bimestrais de um aluno representandas pelas variáveis N1, N2, N3, N4. Calcular a média aritmética (variável MD)
// desse aluno e apresentar a mensagem "Aprovado" se a média obtida for maior ou igual à 5; caso contrário, apresentar a mensagem "Reprovado". Informar também, após a apresentação 
// das mensagens, o valor da média obtida pelo aluno.

// 1. Leitura de 4 notas escolares de um aluno (N1,N2,N3,N4)
// 2. Calcular média aritmética (variavel MD)
// 3. Apresentar a mensagem "Aprovado" se a média obtida for maior ou igual a 5. Caso contrário "Reprovado".
// 4. Informar o valor da média obtida


//namespace AtividadesLivro108109.Models
//{

//    public class MediaAluno
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public decimal Nota1 { get; set; }
//        public decimal Nota2 { get; set; }
//        public decimal Nota3 { get; set; }
//        public decimal Nota4 { get; set; }

//        public MediaAluno(string name, decimal nota1, decimal nota2, decimal nota3, decimal nota4)
//        {
//            Name = name;
//            Nota1 = nota1;
//            Nota2 = nota2;
//            Nota3 = nota3;
//            Nota4 = nota4;
//        }

//        public decimal ObterMediaAluno(decimal Nota1, decimal Nota2, decimal Nota3, decimal Nota4)
//        {
//            decimal mediaAluno = (Nota1 + Nota2 + Nota3 + Nota4) / 4;
//            return mediaAluno;
//        }

//        public string VerificarAprovacao(decimal Nota1, decimal Nota2, decimal Nota3, decimal Nota4)
//        {
//            decimal media = ObterMediaAluno(Nota1, Nota2, Nota3, Nota4);
//            if (media >= 5)
//            {
//                return "Aprovado";
//            }else
//            {
//                return "Reprovado";
//            }
//        }
//    }
//}

// FIM ATIVIDADE 3 ---------------------------------------------------------------------




// INICIO ATIVIDADE 2 -------------------------------------------------------
// Efetuar a leitura de um valor numerico inteiro positivo ou negativo representado pela variavel N e apresentar o valor lido como sendo positivo. Dica: se o valor
// lido for menor que zero, ele deve ser multiplicado por -1.

// 1. Um valor inteiro positivou ou negativo (N)
// 2. Apresentar o valor lido como sendo positivo.
// 3. Se o valor lido for menor que zero, ele deve ser multiplicado por -1

//{
//    public class ValoresPositivoNegativo
//    {
//        public int ValorVariavelN { get; set; }

//        public ValoresPositivoNegativo(int valorN) 
//        {
//            ValorVariavelN = valorN;
//        }

//        public int TornarValorPositivo(int valorN)
//        {
//            if (valorN < 0)
//            {
//                return valorN * -1;
//            }
//            return valorN;
//        }

//    }
//}

// FIM ATIVIDADE 2 ----------------------------------------------------------------




// INICIO ATIVIDADE 1 -------------------------------------------------------------

//{
//    public class ValoresUm
//    {
//        // 1. DoisValores : ValorA, ValorB


//        public int ValorA { get; set; }
//        public int ValorB { get; set; }



//        // Construtor passando parâmetros de um método
//        public ValoresUm(int valorA, int valorB)
//        {
//            ValorA = valorA;
//            ValorB = valorB;    
//        }
//        public int Subtracao(int valorA, int valorB)
//        {
//            if (valorA > valorB) {
//                return (valorA - valorB);
//            }
//            else
//            {
//                return (valorB - valorA);
//            }        
//        }

//    }
//}


// FIM ATIVIDADE 1 -------------------------------------------------------