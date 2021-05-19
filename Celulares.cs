namespace CelularFuncionalidade
{
    public class Celulares
    {
        public string modelo;
        public string cor;
        public float tamanho;
        public bool ligado;

        public void Ligar() 
        {
            if (!ligado) {
                ligado = true;
            }
        }

        public void Desligar() {
            if (ligado) {
                ligado = false;
            }
        }
        public string FazerLigacao() {
            return "Ligando...";
        }

        public string EnviarMensagem() {
            return "Mensagem Envidada";
        }
    }
}