namespace AvaliacaoLp3.Models;

public class LojasViewModel
{
    public int Id { get; set; }
    public string Piso { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public string Tipo { get; set; }
    public string Email { get; set; }

    public LojasViewModel(int id, string piso, string nome, string descricao, string tipo, string email)
    {
        Id = id;
        Piso = piso;
        Nome = nome;
        Descricao = descricao;
        Tipo = tipo;
        Email = email;
    }
}