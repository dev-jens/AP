#!/bin/bash

# print tekst en slaag user input op
read -p "Geef een kleur in: " kleur;

# case in esac om de kleur te kiezen
case $kleur in
	red) tput setaf 1 ;;
	green) tput setaf 2 ;;
	yellow) tput setaf 3 ;;
	blue) tput setaf 4 ;;
	magenta) tput setaf 5 ;;
	cyan) tput setaf 6 ;;
	white) tput setaf 7 ;;
	normal) tput setaf 9 ;;
	*) echo Foute invoer;;
	# alle andere woorden zijn een foute invoer.
esac

# alias code: alias color="./color.sh"