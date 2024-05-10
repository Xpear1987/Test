using System;

class Pessoa
{
    // Atributos

    public double peso, altura;

    // IMC
    public double Calculo()
    {
        return peso / (altura * altura);
    }
    public string Situacao(double imc)
    {
        
        string retorno;

        if (imc < 18.5)
        {
            retorno = "abaixo do peso";
        }
        else if (imc < 25)
        {
            retorno = "peso normal";
        }
        else if (imc < 30)
        {
            retorno = "acima do peso";
        }
        else if (imc < 35)
        {
            retorno = "obesidade I";
        }
        else if (imc < 40)
        {
            retorno = "obesidade II";
        }
        else
        {
            retorno = "obesidade III";
        }

        return retorno;

    }

    public void Mensagem()
    {
        double obterCalculo = Calculo();

        string obterSituacao = Situacao(obterCalculo);

        Console.WriteLine("Seu IMC é de " + obterCalculo);
        Console.WriteLine("Sua situação é " + obterSituacao);
    }

}
