#include iostream.h


using namespace std;

int main()
{
	char* nume[20] = { "Arad", "Bucuresti", "Craiova", "Drobeta", "Eforie", "Fagaras", "Giurgiu", "Harsova", "Iasi", "Lugoj", "Mehadia", "Neamt", "Oradea", "Pitesti", "Rm Valcea", "Sibiu", "Timisoara", "Urziceni", "Vaslui", "Zerind" };
	// 0        1            2         3          4           5        6           7        8       9          10       11         12       13         14           15          16			17         18       19}
	int a[20][20], i, j, k, l, n = 20; int solutie[20], nr_solutie = 0;// nr_solutie este numarul de elemente din vectorul soutie[20]
	//matricea de adiacenta
	for (i = 0; i < n; i++)
		for (j = 0; j < n; j++)
			a[i][j] = 0;
	a[0][15] = 1;
	a[0][16] = 1;
	a[0][19] = 1;
	a[1][5] = 1;
	a[1][6] = 1;
	a[1][13] = 1;
	a[1][17] = 1;
	a[2][3] = 1;
	a[2][13] = 1;
	a[2][14] = 1;
	a[3][10] = 1;
	a[4][7] = 1;
	a[5][15] = 1;
	a[7][17] = 1;
	a[8][11] = 1;
	a[8][18] = 1;
	a[9][10] = 1;
	a[9][16] = 1;
	a[12][15] = 1;
	a[12][19] = 1;
	a[13][14] = 1;
	a[14][15] = 1;
	a[17][18] = 1;
	for (i = 0; i < n; i++)
		for (j = 0; j < n; j++)
			if (a[i][j] == 1)
				a[j][i] = 1;
	// lista oraselor conectate de orasul l
	cout << "Introduceti orasul caruia ii cautam orasele cu care este conectat ";
	cin >> l;
	for (i = 0; i < n; i++)
		if (a[i][l] == 1)
			cout << nume[i] << "  ";

int noduri[20], vizitat[20], oras_start = 0, oras_dest = 1, nr_noduri = 0, gasit = 0, nod, parinte[20];
// nr_noduri = numarul de elemente din lista de noduri
//Algoritm de cautare in adancimelatime
for (i = 0; i < n; i++)
	vizitat[i] = 0;  //Toate orasele sunt nevizitate.
noduri[0] = oras_start;  //Adaugam in lista noduri orasul de plecare
nr_noduri++;
vizitat[oras_start] = 1; //Marcam orasul de plecare ca vizitat
while ((gasit == 0) && (nr_noduri != 0))  //Cat timp solutie negasita si noduri diferita de vida executa
{
	nod = noduri[0]; //nod = scoate_din_fata(noduri) //stocam primul element din noduri in variabila nod    
	for (i = 0; i < nr_noduri - 1; i++)
		noduri[i] = noduri[i + 1];      //Eliminam primul element din lista de noduri
	nr_noduri--;
	if (nod == oras_dest)         //Daca testare_tinta[problema] se aplica la stare(nod) atunci 
		gasit = 1;              // Solutia este gasita //facem variabila booleana gasit adevarata 
}
		else
		{
			for (i = 0; i < n; i++)
				if ((a[nod][i] == 1) && (vizitat[i] == 0))      //Adaugam la final in noduri orasele nevizitate care sunt conectate de nod                 
				{
					noduri[nr_noduri] = i;    //adaugam orasul i (nevizitat si conectat cu nod) pe pozitia nr_noduri in lista de noduri
					nr_noduri++;
					vizitat[i] = 1;    //Orasele adaugate sunt marcate ca vizitate
					parinte[i] = nod;  // Se retine pentru oricare din orasele adaugate nodul parinte ca fiind nod
				}

		}
}
//construirea vectorului solutie

if (gasit == 1)
{
	while (oras_dest != oras_start)
	{
		solutie[nr_solutie] = oras_dest;
		oras_dest = parinte[oras_dest];
		nr_solutie++;
	}
	solutie[nr_solutie] = oras_start;
	// afisarea solutiei / drumului
	for (i = nr_solutie; i >= 0; i--)
		cout << nume[solutie[i]] << "  ";
}
}
//algoritm de cautare in adancime
for (i = 0; i < n; i++)
	vizitat[i] = 0;  //Toate orasele sunt nevizitate.
noduri[0] = oras_start;  //Adaugam in lista noduri orasul de plecare
nr_noduri++;
vizitat[oras_start] = 1; //Marcam orasul de plecare ca vizitat
while ((gasit == 0) && (nr_noduri != 0))  //Cat timp solutie negasita si noduri diferita de vida executa
{
	nod = noduri[0]; //nod = scoate_din_fata(noduri) //stocam primul element din noduri in variabila nod    
	for (i = 0; i < nr_noduri - 1; i++)
		noduri[i] = noduri[i + 1];      //Eliminam primul element din lista de noduri
	nr_noduri--;
	if (nod == oras_dest)         //Daca testare_tinta[problema] se aplica la stare(nod) atunci 
		gasit = 1;              // Solutia este gasita //facem variabila booleana gasit adevarata 
}
		else
		{
		for (i = 0; i < n; i++)
			if ((a[nod][i] == 1) && (vizitat[i] == 0))      //Adaugam la final in noduri orasele nevizitate care sunt conectate de nod                 
			{
				noduri[nr_noduri] = i;    //adaugam orasul i (nevizitat si conectat cu nod) pe pozitia nr_noduri in lista de noduri
				nr_noduri++;
				vizitat[i] = 1;    //Orasele adaugate sunt marcate ca vizitate
				parinte[i] = nod;  // Se retine pentru oricare din orasele adaugate nodul parinte ca fiind nod
			}

		}
}
//cautare limita
adancime[oras_start] = 0; // pentru fiecare nod se retine si adancimea la care se afla, incepand cu radacina care este la 0
adancime[i] = adancime[nod] + 1;
if ((a[nod][i] == 1) && ((vizitat[i] == 0) || ((vizitat[i] == 1) && (adancime[i] > adancime[nod] + 1))))      //Adaugam la inceput in noduri orasele nevizitate care sunt conectate de nod   
										// SAU orasele care au fost vizitate, dar adancimea veche (adancime[i])  este mai mare decat adancimea noua (adancime[nod] +1
	if (adancime[nod] <= limita)
	{
		Constantin Cristian Dinu8 : 48 AM
			if (gasit == 1)
			{
				cout << "  Solutia s-a gasit la limita " << limita;
			}
			else
				cout << "Nu s-a gasit solutia la limita " << limita;
		while ((gasit == 0) && (limita < n))
		{
			limita++;