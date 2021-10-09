using E_Loan.BusinessLayer.Interfaces;
using E_Loan.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace E_Loan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClerkController : ControllerBase
    {
        /// <summary>
        /// Creating the field of ILoanClerkServices and injecting in ClerkController constructor
        /// </summary>
        private readonly ILoanClerkServices _clerkServices;
        public ClerkController(ILoanClerkServices loanClerkServices)
        {
            _clerkServices = loanClerkServices;
        }
        /// <summary>
        /// call the default get method to get all loan application, applied by customer.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<LoanMaster>> GetAllApplication()
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// See the status of not recived application, To make as recived if application is valid
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("not-received")]
        public async Task<IEnumerable<LoanMaster>> NotRecivedLoanApplication()
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Show/Get the status and list recived loan application, to precess further for manager.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("received")]
        public async Task<IEnumerable<LoanMaster>> RecivedLoanApplication()
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Start the loan process after verify, //Make sure loan status is "recived" before process loan application
        /// Make the loan application as recived and check is it recived.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="loanId"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("process-loan/{loanId}")]
        public async Task<IActionResult> ProcessLoan([FromBody] LoanProcesstrans loanProcesstrans, string loanId)
        {
            //do code here
            throw new NotImplementedException();

            //Use this line of code to show any error message or you can use custome exception message.
            //return StatusCode(StatusCodes.Status500InternalServerError, new Response
            //{ Status = "Error", Message = $"Loan Id with = {loanId} cannot be Processed" });
        }
    }
}
