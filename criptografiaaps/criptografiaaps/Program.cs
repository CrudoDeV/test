﻿using System;

namespace criptografiaaps
{
    class MainClass
    {
        public static void Main(string[] args)

        {
            String Texto = String.Empty;
            String Tipo;
            Console.WriteLine("ASCII codificados no formato base64 MIME ");
            Console.WriteLine("Exemplo abaixo da codificação usada;");
            Console.WriteLine(" - Texto original:Descarte Consciente - 20/11/2018 - terça-feira;");
            Console.WriteLine(" - Texto convertido para base64: RGVzY2FydGUgQ29uc2NpZW50ZSAyMC8xMS8yMDE4IC0gVGVyP2EtZmVpcmE= ", Texto);
            Console.WriteLine(" - É Permitido letras e números");

            Console.WriteLine("Tema APS:Descarte Consciente");
            Console.WriteLine("Digite Algo para ser Criptografado:  ");
            Texto = Console.ReadLine();
            Texto = Criptografar(Texto);

            Console.WriteLine("Texto Criptografado: {0} ", Texto);
            //Ação criada para gerar uma escolha entre S ou N para Descriptografar.
            Console.WriteLine("Descriptografar Texto? Y or N:");
            Tipo = Console.ReadLine();
            //condição 
            if (Tipo.Equals("Y"))
            {
                Console.WriteLine(Descriptografar(Texto));

            }
            if (Tipo.Equals("N"))
            {
                Console.WriteLine("Obrigado por Utilizar a Aplicação :)");

            }
            Console.ReadLine();
        }

        public static String Criptografar(String valor)
        {//String para Criptografar o texto.
            String chaveCripto;
            Byte[] cript = System.Text.ASCIIEncoding.ASCII.GetBytes(valor);
            chaveCripto = Convert.ToBase64String(cript);
            return chaveCripto;

        }
        public static String Descriptografar(String valor)
        {//String para Descriptografar.
            String chaveCripto;
            Byte[] cript = Convert.FromBase64String(valor);
            chaveCripto = System.Text.ASCIIEncoding.ASCII.GetString(cript);
            return chaveCripto;

        }

    }
}

