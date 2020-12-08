namespace Encapsulamento.Classes
{
    public class MasterCard : Cartao
    {
        private string parcelas;

        public void ExibirLimite(){
            System.Console.WriteLine(this.limite);
        }
    }
}