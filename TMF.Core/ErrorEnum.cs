namespace TMF.Core
{
    public enum ErrorEnum
    {
        NoError,
        Exception = 1001,
        NullReference,
        InvalidInput,
        AccessRightException = 3000,
        NoAccessRight,
        DataException = 4000,
        UniqueConstraint,
        TransactionError,
        ColumnReference,
        DuplicateRecord,
        NoRecord
    }
}
