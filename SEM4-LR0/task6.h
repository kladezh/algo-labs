#pragma once
#include <iostream>
#include <sstream>
#include <string>
#include <algorithm>
#include <vector>

const std::string VOWEL_LETTERS = "aeyuioAEYUIO";
const std::string PUNCT_MARKS = " .,:;-?!%\'\"`";

bool is_vowel_letter(const char letter);
void print_sentense(const std::vector<std::string>& words);

void task6();