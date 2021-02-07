  
#!/bin/bash

clear;
num="42";
read -p "Raad het getal (0-100): " answer;

while [ $answer -ne $num ] ; do
	echo "Fout!";
	if [ $answer -gt $num ] ; then
		echo Het getal is kleiner;
	else
		echo Het getal is groter;
	fi
	read -p "Probeer opnieuw (0-100): " answer;
done

echo "Juist!";