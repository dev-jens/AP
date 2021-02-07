#!/bin/bash
clear;
echo Dit is mijn home directory;
cd /home/luca/;
ls;
mkdir /home/luca/basher;
cd /home/luca/basher/;
touch bash1.txt bash2.txt bash3.txt && echo Files created;
echo mijn eerste script > bash1.txt;
echo mijn eerste script > bash2.txt;
echo mijn eerste script > bash3.txt;
echo Dit is de basher directory;
ls;
echo Dit is bash1.txt
cat bash1.txt;