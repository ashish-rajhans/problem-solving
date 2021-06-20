#include "YetAnotherDeck.h"
#include <iostream>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;


string FindAnswers(vector<int> & cards, vector<int> & queries)
{
    string output = "";
    int q = queries.size();
    for (int i = 0; i < q; i++)
    {
        int pos = find(cards.begin(), cards.end(), queries[i]) - cards.begin();
        output += to_string(pos + 1) + " ";

        rotate(cards.begin(), cards.begin() + pos, cards.begin() + pos + 1);
    }

    return output;
}

YetAnotherDeck::YetAnotherDeck()
{
    int n, q;
    
    cin >> n >> q;

    vector<int> cards(n);

    for (size_t i = 0; i < n; i++)
    {
        cin >> cards[i];
    }

    vector<int> queries(q);

    for (size_t i = 0; i < q; i++)
    {
        cin >> queries[i];
    }
    
    cout << FindAnswers(cards, queries);
}

