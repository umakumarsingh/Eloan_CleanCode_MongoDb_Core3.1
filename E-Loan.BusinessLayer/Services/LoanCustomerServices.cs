using E_Loan.BusinessLayer.Interfaces;
using E_Loan.BusinessLayer.Services.Repository;
using E_Loan.Entities;
using System;
using System.Threading.Tasks;

namespace E_Loan.BusinessLayer.Services
{
    
    public class LoanCustomerServices : ILoanCustomerServices
    {
        /// <summary>
        /// Creating instance/field of ILoanCustomerRepository and injecting into LoanCustomerSevices Constructor
        /// </summary>
        private readonly ILoanCustomerRepository _customerRepository;
        public LoanCustomerServices(ILoanCustomerRepository loanCustomerRepository)
        {
            _customerRepository = loanCustomerRepository;
        }
        /// <summary>
        /// Applay for mortage or new loan application
        /// </summary>
        /// <param name="loanMaster"></param>
        /// <returns></returns>
        public async Task<LoanMaster> ApplyMortgage(LoanMaster loanMaster)
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Check the status of applied loan application by user
        /// </summary>
        /// <param name="loanId"></param>
        /// <returns></returns>
        public async Task<LoanMaster> AppliedLoanStatus(string loanId)
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Update the loan application before its sent to loan clerk.
        /// Before update make sure loanApplication is in "Not Recived" status.
        /// </summary>
        /// <param name="loanMaster"></param>
        /// <returns></returns>
        public async Task<LoanMaster> UpdateMortgage(string loanId, LoanMaster loanMaster)
        {
            var result = await _customerRepository.UpdateMortgage(loanId, loanMaster);
            return result;
        }
    }
}
