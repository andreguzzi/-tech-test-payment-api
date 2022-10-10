namespace tech_test_payment_api_main.Models
{
    public enum EnumStatusRequest
    {
        //De: Aguardando pagamento  Para: Pagamento Aprovado
        //De: Aguardando pagamento   Para: Cancelada
        //De: Pagamento Aprovado    Para: Enviado para Transportadora
        //De: Pagamento Aprovado   Para: Cancelada
        //De: Enviado para Transportador. Para: Entregue

        AguardandoPagamento,
        PagamentoAprovado,
        Cancelada,
        EnviadoParaTransportador,
        Entregue

    }
}