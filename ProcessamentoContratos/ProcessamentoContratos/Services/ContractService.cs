using ProcessamentoContratos.Entities;
using System;

namespace ProcessamentoContratos.Services
{
    class ContractService
    {
      
        private IOnlinePaymentService _onlinePayment;

        public ContractService(IOnlinePaymentService onlinePayment)
        {
            _onlinePayment = onlinePayment;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;
            for (int j = 1; j <= months; j++)
            {
                DateTime date = contract.Date.AddMonths(j);
                double updateQuota = basicQuota + _onlinePayment.Interest(basicQuota, j);
                double fullQuota = updateQuota + _onlinePayment.PaymentFee(updateQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
