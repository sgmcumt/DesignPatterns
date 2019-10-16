using System;
using System.Collections.Generic;
using System.Text;

namespace OperationLibrary
{
    /// <summary>
    /// 运算类
    /// </summary>
    public class Operation
    {

        /// <summary>
        /// 数字A
        /// </summary>
        public double NumberA { get; set; } = 0;

        /// <summary>
        /// 数字B
        /// </summary>
        public double NumberB { get; set; } = 0;

        /// <summary>
        /// 得到运算结果
        /// </summary>
        /// <returns></returns>
        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }

        /// <summary>
        /// 检查输入的字符串是否准确
        /// </summary>
        /// <param name="currentNumber"></param>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static string CheckNumberInput(string currentNumber, string inputString)
        {
            string result = "";
            if (inputString == ".")
            {
                if (currentNumber.IndexOf(".") < 0)
                {
                    if (currentNumber.Length == 0)
                        result = "0" + inputString;
                    else
                        result = currentNumber + inputString;
                }
            }
            else if (currentNumber == "0")
            {
                result = inputString;
            }
            else
            {
                result = currentNumber + inputString;
            }

            return result;
        }


    }

    /// <summary>
    /// 加法类
    /// </summary>
    class OperationAdd : Operation
    {
        public override double GetResult()
        {
            return NumberA + NumberB;
        }
    }

    /// <summary>
    /// 减法类
    /// </summary>
    class OperationSub : Operation
    {
        public override double GetResult()
        {
            return NumberA - NumberB;
        }
    }

    /// <summary>
    /// 乘法类
    /// </summary>
    class OperationMul : Operation
    {
        public override double GetResult()
        {
            return NumberA * NumberB;
        }
    }

    /// <summary>
    /// 除法类
    /// </summary>
    class OperationDiv : Operation
    {
        public override double GetResult()
        {
            if (NumberB == 0)
                throw new Exception("除数不能为0。");
            return NumberA / NumberB;
        }
    }

    /// <summary>
    /// 平方类
    /// </summary>
    class OperationSqr : Operation
    {
        public override double GetResult()
        {
            return NumberB * NumberB;
        }
    }

    /// <summary>
    /// 平方根类
    /// </summary>
    class OperationSqrt : Operation
    {
        public override double GetResult()
        {
            if (NumberB < 0)
                throw new Exception("负数不能开平方根。");
            return Math.Sqrt(NumberB);
        }
    }

    /// <summary>
    /// 相反数类
    /// </summary>
    class OperationReverse : Operation
    {
        public override double GetResult()
        {
            return -NumberB;
        }
    }

    /// <summary>
    /// 运算类工厂
    /// </summary>
public class OperationFactory
{
    public static Operation CreateOperate(string operate)
    {
        Operation oper = null;
        switch (operate)
        {
            case "+":
                {
                    oper = new OperationAdd();
                    break;
                }
            case "-":
                {
                    oper = new OperationSub();
                    break;
                }
            case "*":
                {
                    oper = new OperationMul();
                    break;
                }
            case "/":
                {
                    oper = new OperationDiv();
                    break;
                }
            case "sqr":
                {
                    oper = new OperationSqr();
                    break;
                }
            case "sqrt":
                {
                    oper = new OperationSqrt();
                    break;
                }
            case "+/-":
                {
                    oper = new OperationReverse();
                    break;
                }
        }

        return oper;
    }
}

}
