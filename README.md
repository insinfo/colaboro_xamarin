# Colaboro é o App test em Xamarin


para trocar a "origin" de um repositorio GIT use os comandos abaixo

git remote rm origin <br>
git remote add origin git@github.com:aplikacjainfo/proj1.git <br>
git config master.remote origin <br>
git config master.merge refs/heads/master <br>
git branch --set-upstream-to=origin/master <br>
