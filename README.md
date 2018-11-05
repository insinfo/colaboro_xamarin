# Colaboro


para trocar a "origin" de um repositorio GIT 

$ git remote rm origin
$ git remote add origin git@github.com:aplikacjainfo/proj1.git
$ git config master.remote origin
$ git config master.merge refs/heads/master
git branch --set-upstream-to=origin/master