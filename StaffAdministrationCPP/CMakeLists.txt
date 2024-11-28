cmake_minimum_required(VERSION 3.29)
project(StaffAdministration)

set(CMAKE_CXX_STANDARD 98)

add_executable(StaffAdministration main.cpp
        Employee.cpp
        Employee.h
        Manager.cpp
        Manager.h)
