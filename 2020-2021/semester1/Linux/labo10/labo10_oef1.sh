#!/bin/bash

clear;
echo Kies een commando;
read -p "chmod, chown, tree, cd: " choice;
case $choice in
	"chmod")
		echo Hiermee pas je de rechten van een bestand aan.;
	;;
	"chown")
		echo Hiermee pas je de eigenaars van een bestand aan.;
	;;
	"tree")
		echo "Hiermee laat je de bestanden en directories zien in een boomstructuur";
	;;
	"cd")
		echo Hiermee beweeg je naar de ingegeven bestemming.;
		echo Indien er geen bestemming ingegeven is, ga je 1 mapje naar boven.;	
	;;
esac