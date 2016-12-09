# ContractBasedDevelopment_cba

## Assignment

### Introduction
Consider an Account class. It should have two methods:
- Deposit(double amount) which should increase the account’s balance with
the amount, the amount should always be positive
- Withdraw(double amount) which on the other hand should decrease the
account’s balance. Also this amount should be positive. If the amount
exceeds the balance, the balance should be left untouched and an exception
should be thrown.

Create a C# class that implements the behaviour mentioned in 1 Introduction.
Use Code Contracts to enforce Design by ContractTM principles. Also create a
small program, that uses the account class.

## Short Textual Description

The code contract improves the testability of the project and can detect if 
preconditions are not met even before you run the project. This can ensure that
the preconditions are met before you test the rest of the method, so you 
don't make stupid calls in the testing classes.

In our case we ensure that when we set the field balance in the Account-class, 
it cannot be below zero. And we made sure the withdraw-method uses the field's setter. 
Other stuff that would make sense to use in the contract is that neither the withdraw 
or deposit methods should accept negative numbers and ensure that both the constructor,
field and both methods should throw some invalid argument exceptions of some
sort, when bad calls are made.
