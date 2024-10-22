namespace rafaelaloncofoggiatto.Models;
public class Folha
{

    public int folhaId { get; set; }
    public int quantidade { get; set; }
    public int mes { get; set; }
    public int ano { get; set; }
    public Funcionario? funcionario { get; set; }

}