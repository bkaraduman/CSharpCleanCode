namespace CodeRefactoring.SwitchStatements.Refactoring
{
    public class UnlimitedCustomer : Customer
    {
        public UnlimitedCustomer()
        {
        }

        public override MonthlyStatement GenerateStatement(MonthlyUsage monthlyUsage)
        {
            var statement = new MonthlyStatement
            {
                CallCost = 0,
                SmsCost = 0
            };

            statement.TotalCost = 54.90f;

            return statement;
        }
    }
}
