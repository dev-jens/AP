#!/bin/bash

function ReadUserInput {
 read -p "Geef een username: " username
 read -p "Geef een groepnaam: " groupname
 read -p "Geef een filenaam: " filename
}

until chown $username:$groupname $filename 2>> ErorsFile.txt
do
 ReadUserInput
done
