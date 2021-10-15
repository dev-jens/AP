#!/bin/bash 

until chown $username:$groupname $filename 2>> ErrorFile.txt
do
 read -p "Geef een username: " username
 read -p "Geef een groepnaam: " groupname
 read -p "Geef een filenaam: " filename
done
