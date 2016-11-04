package com;

import java.util.ArrayList;

public class ManipulaMarcador {

	private ArrayList<LetraMarcador> listLetraMarcador;
	
	public ArrayList<LetraMarcador> identificaLetras() {
		return listLetraMarcador;
	}
	
	public boolean contemPalavra(String palavra) {
		return listLetraMarcador.contains(palavra);
	}
	
	public ArrayList<LetraMarcador> letrasCorretas() {
		return listLetraMarcador;
	}
}
