#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <string>
#include <iostream>
#include <bits/stdc++.h>
#include <list>
#include "lexer.h"
#include "node.h"
#include "BinaryTree.h"
#include "parser.h"

using namespace std;

int main()//(int argc, char **argv)
{
    string input; //= string(argv[1]);
    getline(cin, input);
    split(input);
    if(!lexer()){
        cout << "Hubo un error lexico" << endl;
        return 0;
        /// TODO LexicalError();
    }
    btree* syntaxTree = parse();
    cout << "Result for assigned values: " << syntaxTree->value(syntaxTree->root) << endl;

    /// TODO allPosibleTruthValues(syntaxTree);

    syntaxTree->destroy_tree();
    return 0;
}
