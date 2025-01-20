cmake_minimum_required(VERSION 3.29)
project(Labs)

set(CMAKE_CXX_STANDARD 14)

include_directories(BankCPP)
include_directories(StaffAdministrationCPP)

add_executable(Labs
    BankCPP/BankAccount.cpp
    BankCPP/BankAccount.h
    BankCPP/main.cpp
    BankCPP/Transaction.cpp
    BankCPP/Transaction.h
    StaffAdministrationCPP/Employee.cpp
    StaffAdministrationCPP/Employee.h
    StaffAdministrationCPP/main.cpp
    StaffAdministrationCPP/Manager.cpp
    StaffAdministrationCPP/Manager.h)
