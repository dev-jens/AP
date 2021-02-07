#!/bin/bash
clear;
echo gelieve het getal 1 in te geven om een bestand te maken;
echo of geeft het getal 2 in om een bestand te verwijderen;
read choice;

if [ $choice -eq 1 ]; then
	echo U wilt iets aanmaken;
	read -p "Welk bestand wilt u aanmaken? " filename;
	touch "${filename}" && echo Bestand aangemaakt;
else if [ $choice -eq 2 ]; then
	echo U wilt iets verwijderen;
	read -p "Welk bestand wilt u verwijderen? " filename;
	rm "${filename}" && echo Bestand verwijdert;
else
	echo opdracht bestaat niet;
fi
fi