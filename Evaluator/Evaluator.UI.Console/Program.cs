// See https://aka.ms/new-console-template for more information
using Evaluator.Logic;

Console.WriteLine("Expresion Evaluator");
var expresion = "4*5/(4+6)";
Console.WriteLine($"{expresion} = {MyEvaluator.Evaluate(expresion)}");

