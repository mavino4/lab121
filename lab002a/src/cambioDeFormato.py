'''
import subprocess
subprocess.run('dir -name *.java  > list.txt')
'''

import os
import re
import unicodedata


def elimina_tildes(s):
   return ''.join((c for c in unicodedata.normalize('NFD', s) if unicodedata.category(c) != 'Mn'))

#Creando lista de archivos.
os.system("dir -name *.java  > list.txt")
lista = open('list.txt','r')
archivos = []
for line in lista: 
  out = re.findall("\S*.java$",line)
  if out != []:
    archivos.append(out)
print(archivos)

for file in archivos:
  archivo=open(file[0],'r+',encoding = 'utf8')
  destino=open(file[0][:-4]+"txt",'w+',encoding = 'utf8')
  print(archivo)
  for line in archivo:
    line = elimina_tildes(line)
    line = line.replace('¿','')
    destino.write(line)
    