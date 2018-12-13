using Microsoft.AspNetCore.Mvc;
using CalculatorApp.Models;
using System.Collections.Generic;

namespace CalculatorApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(decimal leftOperator, decimal rightOperator, string @operator, decimal result)
        {
            Calculator calculator = new Calculator()
            {
                LeftOperand = leftOperator,
                RightOperand = rightOperator,
                Operator = @operator,
                Result = result
            };
            return View(calculator);
        }


        [HttpPost]
        public IActionResult Calculate(Calculator calculator)
        {
            if (calculator.RightOperand == 0 && calculator.Operator == "/")
            {
                TempData["DivideByZero"] = "Cannot divide by zero";
            }
            else
            {
                Data.CalculatorHistory.Add(calculator);
                calculator.CalculateResult();
            }

            return RedirectToAction("Index", calculator);
        }

        public IActionResult Clear()
        {
            Data.CalculatorHistory.Clear();
            TempData["HistoryCleared"] = "has been cleared";
            return RedirectToAction("History", "Home");
        }

        public IActionResult History()
        {
            return View(Data.CalculatorHistory);
        }
    }
}
