
from pyswip import Prolog
prolog = Prolog()

prolog.assertz("abuelo(lucas,rosa)")
prolog.assertz("abuelo(lucas,miguel)")
prolog.assertz("nieto(rosa,lucas)")
prolog.assertz("nieto(miguel,lucas)")
prolog.assertz("es_primo(rosa,jesus)")
prolog.assertz("abuelo(rosa,miguel)")

#list(prolog.query("padre(lucas,X)"))==[{"X":"rosa"}, {"Y":"miguel"}]
for elemento in prolog.query("abuelo(X,Y)"):
    print(elemento["X"], "es abuelo de ", elemento["Y"])
for elemento in prolog.query("nieto(X,Y)"):
    print(elemento["X"], "es nieto de ",elemento["Y"])
for elemento in prolog.query("es_primo(X,Y)"):
    print(elemento["X"],"es primo de ", elemento["Y"])