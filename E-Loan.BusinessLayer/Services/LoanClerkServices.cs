using E_Loan.BusinessLayer.Interfaces;
using E_Loan.BusinessLayer.Services.Repository;
using E_Loan.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace E_Loan.BusinessLayer.Services
{
    public class LoanClerkServices : ILoanClerkServices
    {
        /// <summary>
        /// Creating the ILoanClerkRepository field/instance and injecting in LoanClerkServices constuctor
        /// </summary>
        private readonly ILoanClerkRepository _clerkRepository;
        public LoanClerkServices(ILoanClerkRepository loanClerkRepository)
        {
            _clerkRepository = loanClerkRepository;
        }
        /// <summary>
        /// Get/Show all loan application
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<LoanMaster>> AllLoanApplication()
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Show not recived loan application, and use to process further.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<LoanMaster>> NotReceivedLoanApplication()
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Start the loan process after all status verifaction by loan clerk.
        /// Mkae sure loan application is frist in "Recived" Status.
        /// </summary>
        /// <param name="loanProcesstrans"></param>
        /// <returns></returns>
        public async Task<LoanProcesstrans> ProcessLoan(LoanProcesstrans loanProcesstrans)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Make/update the status of "Recived" loan application before start the loan process
        /// </summary>
        /// <param name="loanId"></param>
        /// <returns></returns>
        public async Task<bool> ReceivedLoan(string loanId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Sho/get all loan application that is in recived ststus
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<LoanMaster>> ReceivedLoanApplication()
        {
            //do code here
            throw new NotImplementedException();
        }
    }
}
