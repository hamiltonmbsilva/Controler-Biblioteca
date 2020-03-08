namespace WebApi.Uteis
{
    public class ReturnMessage<TEntity>
    {
        public bool Erro { get; set; }
        public string Mensagem { get; set; }
        public TEntity Dados { get; set; }
    }
}
