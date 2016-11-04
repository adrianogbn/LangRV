package com;

import java.util.Scanner;

public class Main {
	public static void main(String[] args) {
		Jogo jogo = new Jogo();

		// Inicializa componentes da GUI
		desenhaTela();

		// Iniciar jogo
		jogo.run();
	}

	public static void desenhaTela() {
		System.out.println("Bem-vindo!");
	}

}
