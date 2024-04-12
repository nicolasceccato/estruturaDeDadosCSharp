namespace Estruturas.Vetor;

public class Vetor
{
    private string[] Elementos;

    public Vetor(int capacidade)
    {
        this.Elementos = new string[capacidade];
    }

    public void adiciona(string elemento)
    {
        for (int i = 0; i < this.Elementos.Length; i++)
        {
            if (Elementos[i] == null)
            {
                Elementos[i] = elemento;
                break;
            }
        }
    }
}