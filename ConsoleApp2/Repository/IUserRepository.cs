﻿using ConsoleApp2.Entity;
 
 namespace ConsoleApp2.Reponsitory;

public interface IUserRepository
{
    User Register(User user);
    User Authenticate(string username, string password);
    User GetUserByUsername(string username);
    bool UpdateUserInformation(User user);
    bool UpdatePassword(string username, string currentPassword, string newPassword);
    List<User> GetAllUsers();
    List<User> SearchUserByName(string name);
    User SearchUserByAccountNumber(string accountNumber);
    User SearchUserByPhoneNumber(string phoneNumber);
    bool LockUser(string accountNumber);
    bool UnlockUser(string accountNumber);
    decimal GetBalance(string accountNumber);
}