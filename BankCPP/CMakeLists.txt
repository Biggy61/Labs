cmake_minimum_required(VERSION 3.29)
project(BankCPP)

set(CMAKE_CXX_STANDARD 26)

add_executable(BankCPP main.cpp
        BankAccount.cpp
        BankAccount.h
        Transaction.cpp
        Transaction.h)
