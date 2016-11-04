package com;

import java.awt.List;
import java.util.ArrayList;
import java.util.Scanner;

public class Jogo {

	static Scanner input = new Scanner(System.in);;
	int dificuldade, idioma;
	ArrayList<Fase> listFase;
	ArrayList<LetraMarcador> listLetraCorreta;
	Fase faseAtual;
	ManipulaMarcador manipulaMarcador;

	public void run() {
		// Menu para teste da aplicação
		int opcao = 0;
		while (opcao != 3) {
			System.out.println("Menu");
			System.out.println("1 - Jogar");
			System.out.println("2 - Opções");
			System.out.println("3 - Sair");
			opcao = input.nextInt();

			switch (opcao) {
			case 1:
				System.out.println("Jogar");
				break;
			case 2:
				System.out.println("Opções");
				break;
			default:
				break;
			}
		}
	}

	public Fase getProximaFase() {
		return faseAtual.getFase();

	}

	public void desenhaAnimacao() {

	}

	public String populaFases() {
		return "test";
	}

}
