using System;
using System.Collections.Generic;
using System.Text;
using CodingSeb.ExpressionEvaluator;

namespace ЧМІ_1
{
    public class Expression
    {
        public string Expr { get; set; }
        public double X { get; set; }        
        public double F { get; set; }
        public double FDiv { get; set; }
        


        ExpressionEvaluator evaluator = new ExpressionEvaluator();

        public Expression(double x, string expression)
        {
            Expr = expression;
            X = x;
            F = SolveExpression(X);
            FDiv = SolveDerivativeExpression();
            
            

        }

        public double SolveExpression(double x)
        {
            evaluator.Variables["x"] = x;

            return Convert.ToDouble(evaluator.Evaluate(Expr));
        }
        public double SolveDerivativeExpression()
        {
            evaluator.Variables["x"] = X + 0.05;
            double fDelta = Convert.ToDouble(evaluator.Evaluate(Expr));

            return (fDelta - SolveExpression(X)) / 0.05;
        }
        public double TransversalMethod(double a, double b)
        {
            return b - (SolveExpression(b) * (b - a)) / (SolveExpression(b) - SolveExpression(a));
        } 

    }
}
