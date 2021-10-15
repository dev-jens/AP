#!/bin/bash 
read -p "Op welke map wilt u dit uitvoeren: " dir 
cd $dir

for bestand in $(ls)
do 
    read -p " wilt u het bestand $bestand kopiëren? (Y/N)" keuze

    DIR="/etc/httpd/"

    if [ -d "$DIR" ]; then
    echo ""
    else 
    mkdir kopiedir
    fi

    if [  $keuze -eq "Y" ]; then
    cp $bestand kopiedir
    elif [ $keuze -eq "N" ]
    break
    echo "script vroeg tijdig gestopt"
    fi
done

echo "het is gedaan"



