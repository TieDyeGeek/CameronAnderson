using System;
using System.Collections.Generic;
using CameronAnderson.Wordle;

namespace CameronAnderson.Pages.Wordle;

public class Alphabet
{
	public Letter A = new Letter('a');
	public Letter B = new Letter('b');
	public Letter C = new Letter('c');
	public Letter D = new Letter('d');
	public Letter E = new Letter('e');
	public Letter F = new Letter('f');
	public Letter G = new Letter('g');
	public Letter H = new Letter('h');
	public Letter I = new Letter('i');
	public Letter J = new Letter('j');
	public Letter K = new Letter('k');
	public Letter L = new Letter('l');
	public Letter M = new Letter('m');
	public Letter N = new Letter('n');
	public Letter O = new Letter('o');
	public Letter P = new Letter('p');
	public Letter Q = new Letter('q');
	public Letter R = new Letter('r');
	public Letter S = new Letter('s');
	public Letter T = new Letter('t');
	public Letter U = new Letter('u');
	public Letter V = new Letter('v');
	public Letter W = new Letter('w');
	public Letter X = new Letter('x');
	public Letter Y = new Letter('y');
	public Letter Z = new Letter('z');


	public List<WordleLetter> Flatten()
	{
		var letters = new List<WordleLetter>();

		letters.AddRange(A.ToWordleLetters());
		letters.AddRange(B.ToWordleLetters());
		letters.AddRange(C.ToWordleLetters());
		letters.AddRange(D.ToWordleLetters());
		letters.AddRange(E.ToWordleLetters());
		letters.AddRange(F.ToWordleLetters());
		letters.AddRange(G.ToWordleLetters());
		letters.AddRange(H.ToWordleLetters());
		letters.AddRange(I.ToWordleLetters());
		letters.AddRange(J.ToWordleLetters());
		letters.AddRange(K.ToWordleLetters());
		letters.AddRange(L.ToWordleLetters());
		letters.AddRange(M.ToWordleLetters());
		letters.AddRange(N.ToWordleLetters());
		letters.AddRange(O.ToWordleLetters());
		letters.AddRange(P.ToWordleLetters());
		letters.AddRange(Q.ToWordleLetters());
		letters.AddRange(R.ToWordleLetters());
		letters.AddRange(S.ToWordleLetters());
		letters.AddRange(T.ToWordleLetters());
		letters.AddRange(U.ToWordleLetters());
		letters.AddRange(V.ToWordleLetters());
		letters.AddRange(W.ToWordleLetters());
		letters.AddRange(X.ToWordleLetters());
		letters.AddRange(Y.ToWordleLetters());
		letters.AddRange(Z.ToWordleLetters());

		return letters;
	}
}

