using System;
using System.Collections.Generic;

// Abstract base class for all expression nodes
abstract class ExprNode
{
    public abstract int Evaluate(Dictionary<string, int> context);
}

// Non-terminal node for addition (E → E + T)
class AddNode : ExprNode
{
    private ExprNode left;
    private ExprNode right;

    public AddNode(ExprNode left, ExprNode right)
    {
        this.left = left;
        this.right = right;
    }

    public override int Evaluate(Dictionary<string, int> context)
    {
        return left.Evaluate(context) + right.Evaluate(context);
    }
}

// Non-terminal node for multiplication (T → T * F)
class MultiplyNode : ExprNode
{
    private ExprNode left;
    private ExprNode right;

    public MultiplyNode(ExprNode left, ExprNode right)
    {
        this.left = left;
        this.right = right;
    }

    public override int Evaluate(Dictionary<string, int> context)
    {
        return left.Evaluate(context) * right.Evaluate(context);
    }
}

// Terminal node for identifiers (F → id)
class IdentifierNode : ExprNode
{
    private string name;

    public IdentifierNode(string name)
    {
        this.name = name;
    }

    public override int Evaluate(Dictionary<string, int> context)
    {
        if (context.ContainsKey(name))
            return context[name];
        throw new Exception("Undefined variable: " + name);
    }
}

// Terminal node for integer constants
class ConstantNode : ExprNode
{
    private int value;

    public ConstantNode(int value)
    {
        this.value = value;
    }

    public override int Evaluate(Dictionary<string, int> context)
    {
        return value;
    }
}

// Parser class to parse and build AST
class Parser
{
    private Queue<string> tokens;
    private Dictionary<string, int> context;

    public Parser(string expression, Dictionary<string, int> context)
    {
        this.tokens = new Queue<string>(expression.Split(' '));
        this.context = context;
    }

    public ExprNode ParseExpression()
    {
        ExprNode node = ParseTerm();
        while (tokens.Count > 0 && tokens.Peek() == "+")
        {
            tokens.Dequeue(); // Consume '+'
            ExprNode right = ParseTerm();
            node = new AddNode(node, right); // Build AddNode for 'E → E + T'
        }
        return node;
    }

    private ExprNode ParseTerm()
    {
        ExprNode node = ParseFactor();
        while (tokens.Count > 0 && tokens.Peek() == "*")
        {
            tokens.Dequeue(); // Consume '*'
            ExprNode right = ParseFactor();
            node = new MultiplyNode(node, right); // Build MultiplyNode for 'T → T * F'
        }
        return node;
    }

    private ExprNode ParseFactor()
    {
        string token = tokens.Dequeue();
        if (int.TryParse(token, out int value))
            return new ConstantNode(value); // F → integer constant

        if (char.IsLetter(token[0]))
            return new IdentifierNode(token); // F → id

        if (token == "(")
        {
            ExprNode node = ParseExpression();
            tokens.Dequeue(); // Consume ')'
            return node; // F → ( E )
        }

        throw new Exception("Unexpected token: " + token);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Expression: "3 + 5 * ( 2 + x )" where x = 4
        string expression = "3 + 5 * ( 2 + x )";
        var context = new Dictionary<string, int> { { "x", 4 } };

        Parser parser = new Parser(expression, context);
        ExprNode ast = parser.ParseExpression();

        Console.WriteLine("Result: " + ast.Evaluate(context)); // Output: Result: 28
    }
}

