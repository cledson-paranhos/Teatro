using System;

namespace Teatro
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] cadeiras = new int[2, 2];
            int i, y, opRetorno, opMenu, quantInteiro = 0, quantMeia = 0, quantDesc = 0;
            double valorIngresso = 50.0, valorIngressoMeio = 25.0, isento = 0.0, valorTotalCaixa = 0;

            do
            {
                //Primeiro menu de opções 

                Console.WriteLine("");
                Console.WriteLine("      TEATRO     ");
                Console.WriteLine("");

                Console.WriteLine("[1] - VENDA DE INGRESSOS");
                Console.WriteLine("[2] - CADEIRAS DISPONIVEIS");
                Console.WriteLine("[3] - CANCELAR INGRESSO");
                Console.WriteLine("[4] - FECHAMENTO DO CAIXA");

                opMenu = int.Parse(Console.ReadLine());
                switch (opMenu)
                {
                    case 1:
                        Console.WriteLine("    OPÇÕES DE PEÇAS DISPONIVEIS     ");
                        Console.WriteLine("");
                        Console.WriteLine("[1] - ROMEU E JULIETA");
                        Console.WriteLine("[2] - O VENDEDOR DE SONHOS");
                        Console.WriteLine("[3] - O LAGO DOS CISNES");
                        int opFilme = int.Parse(Console.ReadLine());
                        switch (opFilme)
                        {
                            case 1:
                                Console.WriteLine("   ESCOLHA O HORARIO   ");
                                Console.WriteLine("");
                                Console.WriteLine("[1] - HORARIO 08:00");
                                Console.WriteLine("[2] - HORARIO 14:30");
                                Console.WriteLine("[3] - HORARIO 20:00");
                                int opHorario = int.Parse(Console.ReadLine());
                                switch (opHorario)
                                {
                                    case 1:
                                        Console.WriteLine("");
                                        Console.WriteLine("   VALOR DO INGRESSO     ");
                                        Console.WriteLine("[1] - VALOR INTEIRO");
                                        Console.WriteLine("[2] - MEIA ENTRADA");
                                        Console.WriteLine("[3] - 100 % DE DESCONTO");
                                        int opValor = int.Parse(Console.ReadLine());

                                        switch (opValor)
                                        {
                                            case 1:

                                                Console.WriteLine("  VALOR DO INGRESSO R$ " + valorIngresso);
                                                quantInteiro = quantInteiro + 1;

                                                Console.WriteLine("");

                                                break;

                                            case 2:

                                                Console.WriteLine(" VALOR DO INGRESSO R$ " + valorIngressoMeio);
                                                quantMeia = quantMeia + 1;

                                                Console.WriteLine("");
                                                break;

                                            case 3:

                                                Console.WriteLine(" VALOR DO INGRESSO R$ " + isento);
                                                quantDesc = quantDesc + 1;
                                                Console.WriteLine("");
                                                break;

                                        }

                                        //Escolher cadeira
                                        do
                                        {
                                            Console.WriteLine("  AGORA SELECIONE UMA CADEIRA DISPONIVEL NO SISTEMA  ");
                                            Console.WriteLine("");
                                            Console.Write("Linha: ");
                                            i = int.Parse(Console.ReadLine());
                                            Console.Write("Coluna: ");
                                            y = int.Parse(Console.ReadLine());

                                            if (i < 2 && y < 2)
                                            {
                                                if (cadeiras[i, y] == 0)
                                                {
                                                    cadeiras[i, y] = 1;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine("    [ATENÇÃO]    ");
                                                    Console.WriteLine(" CADEIRA OCUPADA");
                                                    Console.WriteLine("");
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine("      [ATENÇÃO]    ");
                                                Console.WriteLine(" CADEIRA INEXISTENTE");
                                            }

                                            Console.WriteLine("");
                                            Console.WriteLine("   ESCOLHER MAIS CADEIRAS ?  ");
                                            Console.WriteLine("[1] - PARA COMPRAR NOVAMENTE");
                                            Console.WriteLine("[0] - PARA CONCLUIR A COMPRA!");

                                            opRetorno = int.Parse(Console.ReadLine());
                                        } while (opRetorno == 1);

                                        Console.Clear();
                                        Console.WriteLine("      TICKET DE COMPRA   ");
                                        Console.WriteLine("");

                                        //OPÇÃO DO FILME 
                                        if (opFilme == 1)
                                        {
                                            Console.WriteLine(" PEÇA ESCOLHIDA: ROMEU E JULIETA ");
                                        }
                                        else if (opFilme == 2)
                                        {
                                            Console.WriteLine(" PEÇA ESCOLHIDA: O VENDEDOR DE SONHOS");
                                        }
                                        else
                                        {
                                            Console.WriteLine(" PEÇA ESCOLHIDA: O LAGO DOS CISNES");
                                        }
                                        Console.WriteLine("");
                                        //OPÇÃO DO HORARIO
                                        if (opHorario == 1)
                                        {
                                            Console.WriteLine(" HORARIO DA PEÇA: 08:00");
                                        }
                                        else if (opHorario == 2)
                                        {
                                            Console.WriteLine(" HORARIO DA PEÇA: 14:30");
                                        }
                                        else
                                        {
                                            Console.WriteLine(" HORARIO DA PEÇA: 20:00");
                                        }
                                        Console.WriteLine("");

                                        Console.WriteLine(" CADEIRA SELECIONADA: LINHA: " + i + " COLUNA: " + y);
                                        Console.WriteLine("");

                                        if (opValor == 1)
                                        {
                                            Console.WriteLine(" VALOR DO INGRESSO: R$ " + valorIngresso);
                                        }
                                        else if (opValor == 2)
                                        {
                                            Console.WriteLine(" VALOR DO INGRESSO: R$" + valorIngressoMeio);
                                        }
                                        else
                                        {
                                            Console.WriteLine(" VALOR DO INGRESSO: R$" + valorIngresso);
                                        }
                                        Console.WriteLine("");
                                        Console.WriteLine("");
                                        Console.WriteLine(" COMPRA REALIZADA COM SUCESSO! APROVEITE  ");
                                        //break para ir para o horario 2 
                                        break;

                                    case 2: //Case do horario 2
                                        Console.WriteLine("");
                                        Console.WriteLine("   VALOR DO INGRESSO     ");
                                        Console.WriteLine("[1] - VALOR INTEIRO");
                                        Console.WriteLine("[2] - MEIA ENTRADA");
                                        Console.WriteLine("[3] - 100 % DE DESCONTO");
                                        int opValor2 = int.Parse(Console.ReadLine());

                                        switch (opValor2)
                                        {
                                            case 1:

                                                Console.WriteLine("  VALOR DO INGRESSO R$ " + valorIngresso);
                                                quantInteiro = quantInteiro + 1;

                                                Console.WriteLine("");

                                                break;

                                            case 2:

                                                Console.WriteLine(" VALOR DO INGRESSO R$ " + valorIngressoMeio);
                                                quantMeia = quantMeia + 1;

                                                Console.WriteLine("");
                                                break;

                                            case 3:

                                                Console.WriteLine(" VALOR DO INGRESSO R$ " + isento);
                                                quantDesc = quantDesc + 1;
                                                Console.WriteLine("");
                                                break;

                                        }
                                        //Escolher cadeira
                                        do
                                        {
                                            Console.WriteLine("  AGORA SELECIONE UMA CADEIRA DISPONIVEL NO SISTEMA  ");
                                            Console.WriteLine("");
                                            Console.Write("Linha: ");
                                            i = int.Parse(Console.ReadLine());
                                            Console.Write("Coluna: ");
                                            y = int.Parse(Console.ReadLine());

                                            if (i < 2 && y < 2)
                                            {
                                                if (cadeiras[i, y] == 0)
                                                {
                                                    cadeiras[i, y] = 1;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine("    [ATENÇÃO]    ");
                                                    Console.WriteLine(" CADEIRA OCUPADA");
                                                    Console.WriteLine("");
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine("      [ATENÇÃO]    ");
                                                Console.WriteLine(" CADEIRA INEXISTENTE");
                                            }

                                            Console.WriteLine("");
                                            Console.WriteLine("   ESCOLHER MAIS CADEIRAS ?  ");
                                            Console.WriteLine("[1] - PARA COMPRAR NOVAMENTE");
                                            Console.WriteLine("[0] - PARA CONCLUIR A COMPRA!");

                                            opRetorno = int.Parse(Console.ReadLine());
                                        } while (opRetorno == 1);

                                        Console.Clear();
                                        Console.WriteLine("      TICKET DE COMPRA   ");
                                        Console.WriteLine("");

                                        //OPÇÃO DO FILME 
                                        if (opFilme == 1)
                                        {
                                            Console.WriteLine(" PEÇA ESCOLHIDA: ROMEU E JULIETA ");
                                        }
                                        else if (opFilme == 2)
                                        {
                                            Console.WriteLine(" PEÇA ESCOLHIDA: O VENDEDOR DE SONHOS");
                                        }
                                        else
                                        {
                                            Console.WriteLine(" PEÇA ESCOLHIDA: O LAGO DOS CISNES");
                                        }
                                        Console.WriteLine("");
                                        //OPÇÃO DO HORARIO
                                        if (opHorario == 1)
                                        {
                                            Console.WriteLine(" HORARIO DA PEÇA: 08:00");
                                        }
                                        else if (opHorario == 2)
                                        {
                                            Console.WriteLine(" HORARIO DA PEÇA: 14:30");
                                        }
                                        else
                                        {
                                            Console.WriteLine(" HORARIO DA PEÇA: 20:00");
                                        }
                                        Console.WriteLine("");

                                        Console.WriteLine(" CADEIRA SELECIONADA: LINHA: " + i + " COLUNA: " + y);
                                        Console.WriteLine("");

                                        if (opValor2 == 1)
                                        {
                                            Console.WriteLine(" VALOR DO INGRESSO: R$ " + valorIngresso);
                                        }
                                        else if (opValor2 == 2)
                                        {
                                            Console.WriteLine(" VALOR DO INGRESSO: R$" + valorIngressoMeio);
                                        }
                                        else
                                        {
                                            Console.WriteLine(" VALOR DO INGRESSO: R$" + isento);
                                        }
                                        Console.WriteLine("");
                                        Console.WriteLine("");
                                        Console.WriteLine(" COMPRA REALIZADA COM SUCESSO! APROVEITE  ");
                                        //break para ir para o horario 3 
                                        break;

                                    case 3:
                                        Console.WriteLine("");
                                        Console.WriteLine("   VALOR DO INGRESSO     ");
                                        Console.WriteLine("[1] - VALOR INTEIRO");
                                        Console.WriteLine("[2] - MEIA ENTRADA");
                                        Console.WriteLine("[3] - 100 % DE DESCONTO");
                                        int opValor3 = int.Parse(Console.ReadLine());

                                        switch (opValor3)
                                        {
                                            case 1:

                                                Console.WriteLine("  VALOR DO INGRESSO R$ " + valorIngresso);
                                                quantInteiro = quantInteiro + 1;

                                                Console.WriteLine("");

                                                break;

                                            case 2:

                                                Console.WriteLine(" VALOR DO INGRESSO R$ " + valorIngressoMeio);
                                                quantMeia = quantMeia + 1;

                                                Console.WriteLine("");
                                                break;

                                            case 3:

                                                Console.WriteLine(" VALOR DO INGRESSO R$ " + isento);
                                                quantDesc = quantDesc + 1;
                                                Console.WriteLine("");
                                                break;

                                        }
                                        //Escolher cadeira
                                        do
                                        {
                                            Console.WriteLine("  AGORA SELECIONE UMA CADEIRA DISPONIVEL NO SISTEMA  ");
                                            Console.WriteLine("");
                                            Console.Write("Linha: ");
                                            i = int.Parse(Console.ReadLine());
                                            Console.Write("Coluna: ");
                                            y = int.Parse(Console.ReadLine());

                                            if (i < 2 && y < 2)
                                            {
                                                if (cadeiras[i, y] == 0)
                                                {
                                                    cadeiras[i, y] = 1;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine("    [ATENÇÃO]    ");
                                                    Console.WriteLine(" CADEIRA OCUPADA");
                                                    Console.WriteLine("");
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine("      [ATENÇÃO]    ");
                                                Console.WriteLine(" CADEIRA INEXISTENTE");
                                            }

                                            Console.WriteLine("");
                                            Console.WriteLine("   ESCOLHER MAIS CADEIRAS ?  ");
                                            Console.WriteLine("[1] - PARA COMPRAR NOVAMENTE");
                                            Console.WriteLine("[0] - PARA CONCLUIR A COMPRA!");

                                            opRetorno = int.Parse(Console.ReadLine());
                                        } while (opRetorno == 1);

                                        Console.Clear();
                                        Console.WriteLine("      TICKET DE COMPRA   ");
                                        Console.WriteLine("");

                                        //OPÇÃO DO FILME 
                                        if (opFilme == 1)
                                        {
                                            Console.WriteLine(" PEÇA ESCOLHIDA: ROMEU E JULIETA ");
                                        }
                                        else if (opFilme == 2)
                                        {
                                            Console.WriteLine(" PEÇA ESCOLHIDA: O VENDEDOR DE SONHOS");
                                        }
                                        else
                                        {
                                            Console.WriteLine(" PEÇA ESCOLHIDA: O LAGO DOS CISNES");
                                        }
                                        Console.WriteLine("");
                                        //OPÇÃO DO HORARIO
                                        if (opHorario == 1)
                                        {
                                            Console.WriteLine(" HORARIO DA PEÇA: 08:00");
                                        }
                                        else if (opHorario == 2)
                                        {
                                            Console.WriteLine(" HORARIO DA PEÇA: 14:30");
                                        }
                                        else
                                        {
                                            Console.WriteLine(" HORARIO DA PEÇA: 20:00");
                                        }
                                        Console.WriteLine("");

                                        Console.WriteLine(" CADEIRA SELECIONADA: LINHA: " + i + " COLUNA: " + y);
                                        Console.WriteLine("");

                                        if (opValor3 == 1)
                                        {
                                            Console.WriteLine(" VALOR DO INGRESSO: R$ " + valorIngresso);
                                        }
                                        else if (opValor3 == 2)
                                        {
                                            Console.WriteLine(" VALOR DO INGRESSO: R$" + valorIngressoMeio);
                                        }
                                        else
                                        {
                                            Console.WriteLine(" VALOR DO INGRESSO: R$" + isento);
                                        }
                                        Console.WriteLine("");
                                        Console.WriteLine("");
                                        Console.WriteLine(" COMPRA REALIZADA COM SUCESSO! APROVEITE  ");
                                        break;
                                    default:
                                        Console.WriteLine("OPÇÂO INVÁLIDA!! ");

                                        break;

                                }
                                break;

                            case 2: //PEÇA 2
                                Console.WriteLine("   ESCOLHA O HORARIO   ");
                                Console.WriteLine("");
                                Console.WriteLine("[1] - HORARIO 08:00");
                                Console.WriteLine("[2] - HORARIO 14:30");
                                Console.WriteLine("[3] - HORARIO 20:00");
                                opHorario = int.Parse(Console.ReadLine());
                                switch (opHorario)
                                {
                                    case 1:
                                        Console.WriteLine("");
                                        Console.WriteLine("   VALOR DO INGRESSO     ");
                                        Console.WriteLine("[1] - VALOR INTEIRO");
                                        Console.WriteLine("[2] - MEIA ENTRADA");
                                        Console.WriteLine("[3] - 100 % DE DESCONTO");
                                        int opValor = int.Parse(Console.ReadLine());

                                        switch (opValor)
                                        {
                                            case 1:

                                                Console.WriteLine("  VALOR DO INGRESSO R$ " + valorIngresso);
                                                quantInteiro = quantInteiro + 1;

                                                Console.WriteLine("");

                                                break;

                                            case 2:

                                                Console.WriteLine(" VALOR DO INGRESSO R$ " + valorIngressoMeio);
                                                quantMeia = quantMeia + 1;

                                                Console.WriteLine("");
                                                break;

                                            case 3:

                                                Console.WriteLine(" VALOR DO INGRESSO R$ " + isento);
                                                quantDesc = quantDesc + 1;
                                                Console.WriteLine("");
                                                break;

                                        }
                                        //Escolher cadeira
                                        do
                                        {
                                            Console.WriteLine("  AGORA SELECIONE UMA CADEIRA DISPONIVEL NO SISTEMA  ");
                                            Console.WriteLine("");
                                            Console.Write("Linha: ");
                                            i = int.Parse(Console.ReadLine());
                                            Console.Write("Coluna: ");
                                            y = int.Parse(Console.ReadLine());

                                            if (i < 2 && y < 2)
                                            {
                                                if (cadeiras[i, y] == 0)
                                                {
                                                    cadeiras[i, y] = 1;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine("    [ATENÇÃO]    ");
                                                    Console.WriteLine(" CADEIRA OCUPADA");
                                                    Console.WriteLine("");
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine("      [ATENÇÃO]    ");
                                                Console.WriteLine(" CADEIRA INEXISTENTE");
                                            }

                                            Console.WriteLine("");
                                            Console.WriteLine("   ESCOLHER MAIS CADEIRAS ?  ");
                                            Console.WriteLine("[1] - PARA COMPRAR NOVAMENTE");
                                            Console.WriteLine("[0] - PARA CONCLUIR A COMPRA!");

                                            opRetorno = int.Parse(Console.ReadLine());
                                        } while (opRetorno == 1);

                                        Console.Clear();
                                        Console.WriteLine("      TICKET DE COMPRA   ");
                                        Console.WriteLine("");

                                        //OPÇÃO DO FILME 
                                        if (opFilme == 1)
                                        {
                                            Console.WriteLine(" PEÇA ESCOLHIDA: ROMEU E JULIETA ");
                                        }
                                        else if (opFilme == 2)
                                        {
                                            Console.WriteLine(" PEÇA ESCOLHIDA: O VENDEDOR DE SONHOS");
                                        }
                                        else
                                        {
                                            Console.WriteLine(" PEÇA ESCOLHIDA: O LAGO DOS CISNES");
                                        }
                                        Console.WriteLine("");
                                        //OPÇÃO DO HORARIO
                                        if (opHorario == 1)
                                        {
                                            Console.WriteLine(" HORARIO DA PEÇA: 08:00");
                                        }
                                        else if (opHorario == 2)
                                        {
                                            Console.WriteLine(" HORARIO DA PEÇA: 14:30");
                                        }
                                        else
                                        {
                                            Console.WriteLine(" HORARIO DA PEÇA: 20:00");
                                        }
                                        Console.WriteLine("");

                                        Console.WriteLine(" CADEIRA SELECIONADA: LINHA: " + i + " COLUNA: " + y);
                                        Console.WriteLine("");

                                        if (opValor == 1)
                                        {
                                            Console.WriteLine(" VALOR DO INGRESSO: R$ " + valorIngresso);
                                        }
                                        else if (opValor == 2)
                                        {
                                            Console.WriteLine(" VALOR DO INGRESSO: R$" + valorIngressoMeio);
                                        }
                                        else
                                        {
                                            Console.WriteLine(" VALOR DO INGRESSO: R$" + isento);
                                        }
                                        Console.WriteLine("");
                                        Console.WriteLine("");
                                        Console.WriteLine(" COMPRA REALIZADA COM SUCESSO! APROVEITE  ");
                                        //break para ir para valor 2
                                        break;

                                    case 2:
                                        Console.WriteLine("");
                                        Console.WriteLine("   VALOR DO INGRESSO     ");
                                        Console.WriteLine("[1] - VALOR INTEIRO");
                                        Console.WriteLine("[2] - MEIA ENTRADA");
                                        Console.WriteLine("[3] - 100 % DE DESCONTO");
                                        int opValor2 = int.Parse(Console.ReadLine());

                                        switch (opValor2)
                                        {
                                            case 1:

                                                Console.WriteLine("  VALOR DO INGRESSO R$ " + valorIngresso);
                                                quantInteiro = quantInteiro + 1;

                                                Console.WriteLine("");

                                                break;

                                            case 2:

                                                Console.WriteLine(" VALOR DO INGRESSO R$ " + valorIngressoMeio);
                                                quantMeia = quantMeia + 1;

                                                Console.WriteLine("");
                                                break;

                                            case 3:

                                                Console.WriteLine(" VALOR DO INGRESSO R$ " + isento);
                                                quantDesc = quantDesc + 1;
                                                Console.WriteLine("");
                                                break;

                                        }
                                        //Escolher cadeira
                                        do
                                        {
                                            Console.WriteLine("  AGORA SELECIONE UMA CADEIRA DISPONIVEL NO SISTEMA  ");
                                            Console.WriteLine("");
                                            Console.Write("Linha: ");
                                            i = int.Parse(Console.ReadLine());
                                            Console.Write("Coluna: ");
                                            y = int.Parse(Console.ReadLine());

                                            if (i < 2 && y < 2)
                                            {
                                                if (cadeiras[i, y] == 0)
                                                {
                                                    cadeiras[i, y] = 1;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine("    [ATENÇÃO]    ");
                                                    Console.WriteLine(" CADEIRA OCUPADA");
                                                    Console.WriteLine("");
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine("      [ATENÇÃO]    ");
                                                Console.WriteLine(" CADEIRA INEXISTENTE");
                                            }

                                            Console.WriteLine("");
                                            Console.WriteLine("   ESCOLHER MAIS CADEIRAS ?  ");
                                            Console.WriteLine("[1] - PARA COMPRAR NOVAMENTE");
                                            Console.WriteLine("[0] - PARA CONCLUIR A COMPRA!");

                                            opRetorno = int.Parse(Console.ReadLine());
                                        } while (opRetorno == 1);

                                        Console.Clear();
                                        Console.WriteLine("      TICKET DE COMPRA   ");
                                        Console.WriteLine("");

                                        //OPÇÃO DO FILME 
                                        if (opFilme == 1)
                                        {
                                            Console.WriteLine(" PEÇA ESCOLHIDA: ROMEU E JULIETA ");
                                        }
                                        else if (opFilme == 2)
                                        {
                                            Console.WriteLine(" PEÇA ESCOLHIDA: O VENDEDOR DE SONHOS");
                                        }
                                        else
                                        {
                                            Console.WriteLine(" PEÇA ESCOLHIDA: O LAGO DOS CISNES");
                                        }
                                        Console.WriteLine("");
                                        //OPÇÃO DO HORARIO
                                        if (opHorario == 1)
                                        {
                                            Console.WriteLine(" HORARIO DA PEÇA: 08:00");
                                        }
                                        else if (opHorario == 2)
                                        {
                                            Console.WriteLine(" HORARIO DA PEÇA: 14:30");
                                        }
                                        else
                                        {
                                            Console.WriteLine(" HORARIO DA PEÇA: 20:00");
                                        }
                                        Console.WriteLine("");

                                        Console.WriteLine(" CADEIRA SELECIONADA: LINHA: " + i + " COLUNA: " + y);
                                        Console.WriteLine("");

                                        if (opValor2 == 1)
                                        {
                                            Console.WriteLine(" VALOR DO INGRESSO: R$ " + valorIngresso);
                                        }
                                        else if (opValor2 == 2)
                                        {
                                            Console.WriteLine(" VALOR DO INGRESSO: R$" + valorIngressoMeio);
                                        }
                                        else
                                        {
                                            Console.WriteLine(" VALOR DO INGRESSO: R$" + isento);
                                        }
                                        Console.WriteLine("");
                                        Console.WriteLine("");
                                        Console.WriteLine(" COMPRA REALIZADA COM SUCESSO! APROVEITE  ");
                                        //break pra ir pro valor 3 
                                        break;

                                    case 3:
                                        Console.WriteLine("");
                                        Console.WriteLine("   VALOR DO INGRESSO     ");
                                        Console.WriteLine("[1] - VALOR INTEIRO");
                                        Console.WriteLine("[2] - MEIA ENTRADA");
                                        Console.WriteLine("[3] - 100 % DE DESCONTO");
                                        int opValor3 = int.Parse(Console.ReadLine());

                                        switch (opValor3)
                                        {
                                            case 1:

                                                Console.WriteLine("  VALOR DO INGRESSO R$ " + valorIngresso);
                                                quantInteiro = quantInteiro + 1;

                                                Console.WriteLine("");

                                                break;

                                            case 2:

                                                Console.WriteLine(" VALOR DO INGRESSO R$ " + valorIngressoMeio);
                                                quantMeia = quantMeia + 1;

                                                Console.WriteLine("");
                                                break;

                                            case 3:

                                                Console.WriteLine(" VALOR DO INGRESSO R$ " + isento);
                                                quantDesc = quantDesc + 1;
                                                Console.WriteLine("");
                                                break;

                                        }
                                        //Escolher cadeira
                                        do
                                        {
                                            Console.WriteLine("  AGORA SELECIONE UMA CADEIRA DISPONIVEL NO SISTEMA  ");
                                            Console.WriteLine("");
                                            Console.Write("Linha: ");
                                            i = int.Parse(Console.ReadLine());
                                            Console.Write("Coluna: ");
                                            y = int.Parse(Console.ReadLine());

                                            if (i < 2 && y < 2)
                                            {
                                                if (cadeiras[i, y] == 0)
                                                {
                                                    cadeiras[i, y] = 1;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine("    [ATENÇÃO]    ");
                                                    Console.WriteLine(" CADEIRA OCUPADA");
                                                    Console.WriteLine("");
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine("      [ATENÇÃO]    ");
                                                Console.WriteLine(" CADEIRA INEXISTENTE");
                                            }

                                            Console.WriteLine("");
                                            Console.WriteLine("   ESCOLHER MAIS CADEIRAS ?  ");
                                            Console.WriteLine("[1] - PARA COMPRAR NOVAMENTE");
                                            Console.WriteLine("[0] - PARA CONCLUIR A COMPRA!");

                                            opRetorno = int.Parse(Console.ReadLine());
                                        } while (opRetorno == 1);

                                        Console.Clear();
                                        Console.WriteLine("      TICKET DE COMPRA   ");
                                        Console.WriteLine("");

                                        //OPÇÃO DO FILME 
                                        if (opFilme == 1)
                                        {
                                            Console.WriteLine(" PEÇA ESCOLHIDA: ROMEU E JULIETA ");
                                        }
                                        else if (opFilme == 2)
                                        {
                                            Console.WriteLine(" PEÇA ESCOLHIDA: O VENDEDOR DE SONHOS");
                                        }
                                        else
                                        {
                                            Console.WriteLine(" PEÇA ESCOLHIDA: O LAGO DOS CISNES");
                                        }
                                        Console.WriteLine("");
                                        //OPÇÃO DO HORARIO
                                        if (opHorario == 1)
                                        {
                                            Console.WriteLine(" HORARIO DA PEÇA: 08:00");
                                        }
                                        else if (opHorario == 2)
                                        {
                                            Console.WriteLine(" HORARIO DA PEÇA: 14:30");
                                        }
                                        else
                                        {
                                            Console.WriteLine(" HORARIO DA PEÇA: 20:00");
                                        }
                                        Console.WriteLine("");

                                        Console.WriteLine(" CADEIRA SELECIONADA: LINHA: " + i + " COLUNA: " + y);
                                        Console.WriteLine("");

                                        if (opValor3 == 1)
                                        {
                                            Console.WriteLine(" VALOR DO INGRESSO: R$ " + valorIngresso);
                                        }
                                        else if (opValor3 == 2)
                                        {
                                            Console.WriteLine(" VALOR DO INGRESSO: R$" + valorIngressoMeio);
                                        }
                                        else
                                        {
                                            Console.WriteLine(" VALOR DO INGRESSO: R$" + isento);
                                        }
                                        Console.WriteLine("");
                                        Console.WriteLine("");
                                        Console.WriteLine(" COMPRA REALIZADA COM SUCESSO! APROVEITE  ");

                                        break;
                                }
                                break;

                            case 3: //OPÇÃO PEÇA 3
                                Console.WriteLine("   ESCOLHA O HORARIO   ");
                                Console.WriteLine("");
                                Console.WriteLine("[1] - HORARIO 08:00");
                                Console.WriteLine("[2] - HORARIO 14:30");
                                Console.WriteLine("[3] - HORARIO 20:00");
                                opHorario = int.Parse(Console.ReadLine());
                                switch (opHorario)
                                {
                                    case 1:
                                        Console.WriteLine("");
                                        Console.WriteLine("   VALOR DO INGRESSO     ");
                                        Console.WriteLine("[1] - VALOR INTEIRO");
                                        Console.WriteLine("[2] - MEIA ENTRADA");
                                        Console.WriteLine("[3] - 100 % DE DESCONTO");
                                        int opValor = int.Parse(Console.ReadLine());

                                        switch (opValor)
                                        {
                                            case 1:

                                                Console.WriteLine("  VALOR DO INGRESSO R$ " + valorIngresso);
                                                quantInteiro = quantInteiro + 1;

                                                Console.WriteLine("");

                                                break;

                                            case 2:

                                                Console.WriteLine(" VALOR DO INGRESSO R$ " + valorIngressoMeio);
                                                quantMeia = quantMeia + 1;

                                                Console.WriteLine("");
                                                break;

                                            case 3:

                                                Console.WriteLine(" VALOR DO INGRESSO R$ " + isento);
                                                quantDesc = quantDesc + 1;
                                                Console.WriteLine("");
                                                break;

                                        }
                                        //Escolher cadeira
                                        do
                                        {
                                            Console.WriteLine("  AGORA SELECIONE UMA CADEIRA DISPONIVEL NO SISTEMA  ");
                                            Console.WriteLine("");
                                            Console.Write("Linha: ");
                                            i = int.Parse(Console.ReadLine());
                                            Console.Write("Coluna: ");
                                            y = int.Parse(Console.ReadLine());

                                            if (i < 2 && y < 2)
                                            {
                                                if (cadeiras[i, y] == 0)
                                                {
                                                    cadeiras[i, y] = 1;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine("    [ATENÇÃO]    ");
                                                    Console.WriteLine(" CADEIRA OCUPADA");
                                                    Console.WriteLine("");
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine("      [ATENÇÃO]    ");
                                                Console.WriteLine(" CADEIRA INEXISTENTE");
                                            }

                                            Console.WriteLine("");
                                            Console.WriteLine("   ESCOLHER MAIS CADEIRAS ?  ");
                                            Console.WriteLine("[1] - PARA COMPRAR NOVAMENTE");
                                            Console.WriteLine("[0] - PARA CONCLUIR A COMPRA!");

                                            opRetorno = int.Parse(Console.ReadLine());
                                        } while (opRetorno == 1);

                                        Console.Clear();
                                        Console.WriteLine("      TICKET DE COMPRA   ");
                                        Console.WriteLine("");

                                        //OPÇÃO DO FILME 
                                        if (opFilme == 1)
                                        {
                                            Console.WriteLine(" PEÇA ESCOLHIDA: ROMEU E JULIETA ");
                                        }
                                        else if (opFilme == 2)
                                        {
                                            Console.WriteLine(" PEÇA ESCOLHIDA: O VENDEDOR DE SONHOS");
                                        }
                                        else
                                        {
                                            Console.WriteLine(" PEÇA ESCOLHIDA: O LAGO DOS CISNES");
                                        }
                                        Console.WriteLine("");
                                        //OPÇÃO DO HORARIO
                                        if (opHorario == 1)
                                        {
                                            Console.WriteLine(" HORARIO DA PEÇA: 08:00");
                                        }
                                        else if (opHorario == 2)
                                        {
                                            Console.WriteLine(" HORARIO DA PEÇA: 14:30");
                                        }
                                        else
                                        {
                                            Console.WriteLine(" HORARIO DA PEÇA: 20:00");
                                        }
                                        Console.WriteLine("");

                                        Console.WriteLine(" CADEIRA SELECIONADA: LINHA: " + i + " COLUNA: " + y);
                                        Console.WriteLine("");

                                        if (opValor == 1)
                                        {
                                            Console.WriteLine(" VALOR DO INGRESSO: R$ " + valorIngresso);
                                        }
                                        else if (opValor == 2)
                                        {
                                            Console.WriteLine(" VALOR DO INGRESSO: R$" + valorIngressoMeio);
                                        }
                                        else
                                        {
                                            Console.WriteLine(" VALOR DO INGRESSO: R$" + isento);
                                        }
                                        Console.WriteLine("");
                                        Console.WriteLine("");
                                        Console.WriteLine(" COMPRA REALIZADA COM SUCESSO! APROVEITE  ");
                                        //break para ir para valor 2
                                        break;

                                    case 2:

                                        Console.WriteLine("");
                                        Console.WriteLine("   VALOR DO INGRESSO     ");
                                        Console.WriteLine("[1] - VALOR INTEIRO");
                                        Console.WriteLine("[2] - MEIA ENTRADA");
                                        Console.WriteLine("[3] - 100 % DE DESCONTO");
                                        int opValor2 = int.Parse(Console.ReadLine());

                                        switch (opValor2)
                                        {
                                            case 1:

                                                Console.WriteLine("  VALOR DO INGRESSO R$ " + valorIngresso);
                                                quantInteiro = quantInteiro + 1;

                                                Console.WriteLine("");

                                                break;

                                            case 2:

                                                Console.WriteLine(" VALOR DO INGRESSO R$ " + valorIngressoMeio);
                                                quantMeia = quantMeia + 1;

                                                Console.WriteLine("");
                                                break;

                                            case 3:

                                                Console.WriteLine(" VALOR DO INGRESSO R$ " + isento);
                                                quantDesc = quantDesc + 1;
                                                Console.WriteLine("");
                                                break;

                                        }
                                        //Escolher cadeira
                                        do
                                        {
                                            Console.WriteLine("  AGORA SELECIONE UMA CADEIRA DISPONIVEL NO SISTEMA  ");
                                            Console.WriteLine("");
                                            Console.Write("Linha: ");
                                            i = int.Parse(Console.ReadLine());
                                            Console.Write("Coluna: ");
                                            y = int.Parse(Console.ReadLine());

                                            if (i < 2 && y < 2)
                                            {
                                                if (cadeiras[i, y] == 0)
                                                {
                                                    cadeiras[i, y] = 1;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine("    [ATENÇÃO]    ");
                                                    Console.WriteLine(" CADEIRA OCUPADA");
                                                    Console.WriteLine("");
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine("      [ATENÇÃO]    ");
                                                Console.WriteLine(" CADEIRA INEXISTENTE");
                                            }

                                            Console.WriteLine("");
                                            Console.WriteLine("   ESCOLHER MAIS CADEIRAS ?  ");
                                            Console.WriteLine("[1] - PARA COMPRAR NOVAMENTE");
                                            Console.WriteLine("[0] - PARA CONCLUIR A COMPRA!");

                                            opRetorno = int.Parse(Console.ReadLine());
                                        } while (opRetorno == 1);

                                        Console.Clear();
                                        Console.WriteLine("      TICKET DE COMPRA   ");
                                        Console.WriteLine("");

                                        //OPÇÃO DO FILME 
                                        if (opFilme == 1)
                                        {
                                            Console.WriteLine(" PEÇA ESCOLHIDA: ROMEU E JULIETA ");
                                        }
                                        else if (opFilme == 2)
                                        {
                                            Console.WriteLine(" PEÇA ESCOLHIDA: O VENDEDOR DE SONHOS");
                                        }
                                        else
                                        {
                                            Console.WriteLine(" PEÇA ESCOLHIDA: O LAGO DOS CISNES");
                                        }
                                        Console.WriteLine("");
                                        //OPÇÃO DO HORARIO
                                        if (opHorario == 1)
                                        {
                                            Console.WriteLine(" HORARIO DA PEÇA: 08:00");
                                        }
                                        else if (opHorario == 2)
                                        {
                                            Console.WriteLine(" HORARIO DA PEÇA: 14:30");
                                        }
                                        else
                                        {
                                            Console.WriteLine(" HORARIO DA PEÇA: 20:00");
                                        }
                                        Console.WriteLine("");

                                        Console.WriteLine(" CADEIRA SELECIONADA: LINHA: " + i + " COLUNA: " + y);
                                        Console.WriteLine("");

                                        if (opValor2 == 1)
                                        {
                                            Console.WriteLine(" VALOR DO INGRESSO: R$ " + valorIngresso);
                                        }
                                        else if (opValor2 == 2)
                                        {
                                            Console.WriteLine(" VALOR DO INGRESSO: R$" + valorIngressoMeio);
                                        }
                                        else
                                        {
                                            Console.WriteLine(" VALOR DO INGRESSO: R$" + isento);
                                        }
                                        Console.WriteLine("");
                                        Console.WriteLine("");
                                        Console.WriteLine(" COMPRA REALIZADA COM SUCESSO! APROVEITE  ");
                                        //break para ir pro valor 3
                                        break;

                                    case 3:
                                        Console.WriteLine("");
                                        Console.WriteLine("   VALOR DO INGRESSO     ");
                                        Console.WriteLine("[1] - VALOR INTEIRO");
                                        Console.WriteLine("[2] - MEIA ENTRADA");
                                        Console.WriteLine("[3] - 100 % DE DESCONTO");
                                        int opValor3 = int.Parse(Console.ReadLine());

                                        switch (opValor3)
                                        {
                                            case 1:

                                                Console.WriteLine("  VALOR DO INGRESSO R$ " + valorIngresso);
                                                quantInteiro = quantInteiro + 1;

                                                Console.WriteLine("");

                                                break;

                                            case 2:

                                                Console.WriteLine(" VALOR DO INGRESSO R$ " + valorIngressoMeio);
                                                quantMeia = quantMeia + 1;

                                                Console.WriteLine("");
                                                break;

                                            case 3:

                                                Console.WriteLine(" VALOR DO INGRESSO R$ " + isento);
                                                quantDesc = quantDesc + 1;
                                                Console.WriteLine("");
                                                break;

                                        }
                                        //Escolher cadeira
                                        do
                                        {
                                            Console.WriteLine("  AGORA SELECIONE UMA CADEIRA DISPONIVEL NO SISTEMA  ");
                                            Console.WriteLine("");
                                            Console.Write("Linha: ");
                                            i = int.Parse(Console.ReadLine());
                                            Console.Write("Coluna: ");
                                            y = int.Parse(Console.ReadLine());

                                            if (i < 2 && y < 2)
                                            {
                                                if (cadeiras[i, y] == 0)
                                                {
                                                    cadeiras[i, y] = 1;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine("    [ATENÇÃO]    ");
                                                    Console.WriteLine(" CADEIRA OCUPADA");
                                                    Console.WriteLine("");
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine("      [ATENÇÃO]    ");
                                                Console.WriteLine(" CADEIRA INEXISTENTE");
                                            }

                                            Console.WriteLine("");
                                            Console.WriteLine("   ESCOLHER MAIS CADEIRAS ?  ");
                                            Console.WriteLine("[1] - PARA COMPRAR NOVAMENTE");
                                            Console.WriteLine("[0] - PARA CONCLUIR A COMPRA!");

                                            opRetorno = int.Parse(Console.ReadLine());
                                        } while (opRetorno == 1);

                                        Console.Clear();
                                        Console.WriteLine("      TICKET DE COMPRA   ");
                                        Console.WriteLine("");

                                        //OPÇÃO DO FILME 
                                        if (opFilme == 1)
                                        {
                                            Console.WriteLine(" PEÇA ESCOLHIDA: ROMEU E JULIETA ");
                                        }
                                        else if (opFilme == 2)
                                        {
                                            Console.WriteLine(" PEÇA ESCOLHIDA: O VENDEDOR DE SONHOS");
                                        }
                                        else
                                        {
                                            Console.WriteLine(" PEÇA ESCOLHIDA: O LAGO DOS CISNES");
                                        }
                                        Console.WriteLine("");
                                        //OPÇÃO DO HORARIO
                                        if (opHorario == 1)
                                        {
                                            Console.WriteLine(" HORARIO DA PEÇA: 08:00");
                                        }
                                        else if (opHorario == 2)
                                        {
                                            Console.WriteLine(" HORARIO DA PEÇA: 14:30");
                                        }
                                        else
                                        {
                                            Console.WriteLine(" HORARIO DA PEÇA: 20:00");
                                        }
                                        Console.WriteLine("");

                                        Console.WriteLine(" CADEIRA SELECIONADA: LINHA: " + i + " COLUNA: " + y);
                                        Console.WriteLine("");

                                        if (opValor3 == 1)
                                        {
                                            Console.WriteLine(" VALOR DO INGRESSO: R$ " + valorIngresso);
                                        }
                                        else if (opValor3 == 2)
                                        {
                                            Console.WriteLine(" VALOR DO INGRESSO: R$" + valorIngressoMeio);
                                        }
                                        else
                                        {
                                            Console.WriteLine(" VALOR DO INGRESSO: R$" + isento);
                                        }
                                        Console.WriteLine("");
                                        Console.WriteLine("");
                                        Console.WriteLine(" COMPRA REALIZADA COM SUCESSO! APROVEITE  ");
                                        break;

                                }
                                break;
                        }
                        break;

                    case 2:  //OPÇÂO CADEIRAS DISPONIVEIS 
                        Console.WriteLine("     CADEIRAS DISPONIVEIS      ");


                        for (i = 0; i < 2; i++)
                        {

                            for (y = 0; y < 2; y++)
                            {
                                if (cadeiras[i, y] == 00)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("LINHA: " + i + " COLUNA: " + y + " LIVRE");
                                    Console.WriteLine("");
                                }
                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("LINHA: " + i + " COLUNA: " + y + " OCUPADA");
                                    Console.WriteLine("");
                                }

                            }
                        }
                        break;

                    default:
                        Console.WriteLine("OPÇÂO INVÁLIDA!! ");


                        break;
                    case 3://CANCELA CADEIRA

                        Console.WriteLine("    CANCELAR INGRESSO    ");

                        Console.WriteLine("");
                        Console.Write(" Linha: ");
                        i = int.Parse(Console.ReadLine());
                        Console.Write(" Coluna: ");
                        y = int.Parse(Console.ReadLine());

                        if (cadeiras[i, y] == 1)
                        {
                            cadeiras[i, y] = 0;
                            Console.WriteLine(" LINHA: " + i + " COLUNA: " + y + " CANCELADA");

                        }
                        else
                        {
                            Console.WriteLine("CADEIRA INEXISTENTE");
                        }

                        break;

                    case 4://FECHAMENTO DO CAIXA
                        Console.Clear();

                        Console.WriteLine("    FECHAMENTO DO CAIXA      ");
                        Console.WriteLine("");
                        Console.WriteLine(" INGRESSOS INTEIROS VENDIDOS: " + quantInteiro);
                        Console.WriteLine("");
                        Console.WriteLine(" INGRESSOS MEIA ENTRADA VENDIDOS:" + quantMeia);
                        Console.WriteLine("");
                        Console.WriteLine(" INGRESSOS 100 % DE DESCONTO VENDIDOS:" + quantDesc);
                        Console.WriteLine("");
                        valorTotalCaixa = (quantInteiro * valorIngresso) + (quantMeia * valorIngressoMeio);

                        Console.WriteLine(" VALOR TOTAL DO CAIXA: R$ " + valorTotalCaixa);
                        Console.WriteLine("");

                        break;

                }

            } while (opMenu != 0);

        }
    }
}
