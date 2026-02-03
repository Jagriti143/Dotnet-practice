

Create or alter procedure usp_Transactions
@StartDate date,
@EndDate date,
@AccountId int
as begin
select sum(Amount)as TotalDeposit,AccountId from [dbo].[Transactions] where TransactionType='Deposit' and 
AccountId=@AccountId and TransactionDate between @StartDate and @EndDate
group by AccountId

select sum(Amount) as TotalWithdraw, AccountId from [dbo].[Transactions] where TransactionType='Withdraw' and
AccountId=@AccountId and TransactionDate between @StartDate and @EndDate
group by AccountId

end

exec usp_Transactions 
    @StartDate = '2024-01-05',
    @EndDate   = '2024-02-25',
    @AccountId = 5;






select AccountId,month(TransactionDate) as BonusMonth,
year(TransactionDate) as BonusYear,
sum(Amount) as TotalDeposit
from [dbo].[Transactions] where TransactionType='Deposit'
group by AccountId, month(TransactionDate), year(TransactionDate)
having sum(Amount)>50000


insert into [dbo].[Bonus] (AccountId, BonusMonth, BonusYear, BonusAmount, CreatedDate)
select AccountId,Month(TransactionDate),Year(TransactionDate),
1000,getdate() from [dbo].[Transactions] where TransactionType='Deposit' 
group by AccountId, month(TransactionDate), year(transactiondate)
having sum(Amount)>50000



select * from [dbo].[Bonus]


create or alter proc usp_getCurrentBalance as
begin
    select c.CustomerName,a.AccountNumber,
    isnull(sum(case when t.transactiontype='deposit' then t.amount end),0)-
    isnull(sum(case when t.transactiontype='withdraw' then t.amount end),0)+
    isnull(b.bonusamount,0)as CurrentBalance from [dbo].[Accounts] as a join [dbo].[Customers] as c on a.CustomerID=c.CustomerID
    left join [dbo].[Transactions] as t on a.AccountID=t.AccountID left join [dbo].[Bonus] as b on a.AccountID=b.AccountID 
    group  by c.CustomerName,a.AccountNumber,b.BonusAmount
end
exec usp_getCurrentBalance




