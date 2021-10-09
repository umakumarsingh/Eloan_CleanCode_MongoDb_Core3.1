using E_Loan.BusinessLayer.Interfaces;
using E_Loan.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace E_Loan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        /// <summary>
        /// Creating the field of ILoanCustomerServices and injecting in CustomerController constructor
        /// </summary>
        private readonly ILoanCustomerServices _customerServices;
        public CustomerController(ILoanCustomerServices loanCustomerServices)
        {
            _customerServices = loanCustomerServices;
        }
        /// <summary>
        /// Get loan status for customer while or before updating loan application.
        /// Get the loan application status by loanId
        /// </summary>
        /// <param name="loanId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("loan-status/{loanId}")]
        public async Task<ActionResult<LoanMaster>> AppliedLoanStatus(string loanId)
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Applay new loan or mortage supply all value for LoanMaster and return object as result of loanmaster object
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("apply-mortage")]
        public async Task<ActionResult<LoanMaster>> ApplayMortage([FromBody] LoanMaster model)
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Update loan/mortage if not recived by loan clerk then perforn actual update,
        /// Check loan status is "Recived" return a error message, and finnaly return Ok(Result) or ststus code
        /// </summary>
        /// <param name="model"></param>
        /// <param name="loanId"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("update-mortage/{loanId}")]
        public async Task<ActionResult<LoanMaster>> UpdateMortage(string loanId, [FromBody] LoanMaster model)
        {
            //do code here
            throw new NotImplementedException();

            //Use this line of code to show any error message or you can use custome exception message.
            //return StatusCode(StatusCodes.Status500InternalServerError, new Response
            //{ Status = "Error", Message = $"Loan Id with = {loanId} cannot be Updated" });
        }
    }
}
