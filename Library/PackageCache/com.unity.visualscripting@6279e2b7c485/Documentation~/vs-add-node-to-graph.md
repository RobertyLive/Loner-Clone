       public static string Name(this UnaryOperator @operator)
        {
            return GetHandler(@operator).name;
        }

        public static string Name(this BinaryOperator @operator)
        {
            return GetHandler(@operator).name;
        }

        public static string Verb(this UnaryOperator @operator)
        {
            return GetHandler(@operator).verb;
        }

        public static string Verb(this BinaryOperator @operator)
        {
            return GetHandler(@operator).verb;
        }

        public static object Operate(UnaryOperator @operator, object x)
        {
            if (!unaryOperatorHandlers.ContainsKey(@operator))
            {
                throw new UnexpectedEnumValueException<UnaryOperator>(@operator);
            }

            return unaryOperatorHandlers[@operator].Operate(x);
        }

        public static object Operate(BinaryOperator @operator, object a, object b)
        {
            if (!binaryOpeatorHandlers.ContainsKey(@operator))
            {
                throw new UnexpectedEnumValueException<BinaryOperator>(@operator);
            }

            return bina