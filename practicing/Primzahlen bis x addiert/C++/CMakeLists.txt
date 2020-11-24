cmake_minimum_required(VERSION 3.7)

# set the project name
project(Primes)

# add the executable
add_executable(Primes C++Testing.cpp)

# specify the C++ standard
set(CMAKE_CXX_STANDARD 17)
set(CMAKE_CXX_STANDARD_REQUIRED True)