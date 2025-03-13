using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BankDataService.Data;
using BankDataService.Models;

namespace BankDataService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly DBManager _context;

        public TransactionsController(DBManager context)
        {
            _context = context;
        }

        // GET: api/Transactions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Transaction>>> GetTransactions()
        {
            if (_context.Transactions == null)
            {
                return NotFound();
            }

            try
            {
                return await _context.Transactions.ToListAsync();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error retrieving transactions: {ex.Message}");
            }
        }

        // GET: api/Transactions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Transaction>> GetTransaction(int id)
        {
            if (_context.Transactions == null)
            {
                return NotFound();
            }

            try
            {
                var transaction = await _context.Transactions.FindAsync(id);

                if (transaction == null)
                {
                    return NotFound();
                }

                return transaction;
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error retrieving transaction: {ex.Message}");
            }
        }

        // PUT: api/Transactions/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTransaction(int id, Transaction transaction)
        {
            if (id != transaction.TransactionId)
            {
                return BadRequest();
            }

            _context.Entry(transaction).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TransactionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, "Error updating transaction.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error updating transaction: {ex.Message}");
            }

            return NoContent();
        }

        // POST: api/Transactions
        [HttpPost]
        public async Task<ActionResult<Transaction>> PostTransaction(Transaction transaction)
        {
            if (transaction == null || transaction.Amount <= 0)
            {
                return BadRequest("Transaction must be valid and the amount greater than zero.");
            }

            var account = await _context.Accounts.FindAsync(transaction.AccountId);
            if (account == null)
            {
                return NotFound("Account not found.");
            }

            try
            {
                // Apply deposit or withdrawal
                if (transaction.TransactionType == "Deposit")
                {
                    account.Balance += transaction.Amount;
                }
                else if (transaction.TransactionType == "Withdrawal")
                {
                    if (account.Balance < transaction.Amount)
                    {
                        return BadRequest("Insufficient funds.");
                    }
                    account.Balance -= transaction.Amount;
                }
                else
                {
                    return BadRequest("Invalid transaction type.");
                }

                // Save the transaction and update the balance
                _context.Transactions.Add(transaction);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetTransaction", new { id = transaction.TransactionId }, transaction);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error saving transaction: {ex.Message}");
            }
        }

        // DELETE: api/Transactions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTransaction(int id)
        {
            if (_context.Transactions == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transactions.FindAsync(id);
            if (transaction == null)
            {
                return NotFound();
            }

            try
            {
                _context.Transactions.Remove(transaction);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error deleting transaction: {ex.Message}");
            }

            return NoContent();
        }

        // Check if transaction exists
        private bool TransactionExists(int id)
        {
            return (_context.Transactions?.Any(e => e.TransactionId == id)).GetValueOrDefault();
        }

        // GET: api/Transactions/account/{accountId}
        [HttpGet("account/{accountId}")]
        public async Task<ActionResult<IEnumerable<Transaction>>> GetTransactionsByAccountId(int accountId)
        {
            if (_context.Transactions == null)
            {
                return NotFound();
            }

            try
            {
                // Fetch transactions for the specified accountId
                var transactions = await _context.Transactions
                    .Where(t => t.AccountId == accountId)
                    .ToListAsync();

                return transactions;
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error retrieving transactions for account: {ex.Message}");
            }
        }
    }
}