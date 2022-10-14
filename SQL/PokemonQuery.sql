Select Numero, Nombre, p.Descripcion, UrlImagen, e.Descripcion AS Tipo, d.Descripcion as Debilidad
from POKEMONS P, ELEMENTOS E, ELEMENTOS D
WHERE E.ID = P.IdTipo
and D.id = p.IdDebilidad
Select Numero, Nombre, p.Descripcion, UrlImagen, e.Descripcion AS Tipo, d.Descripcion as Debilidad from POKEMONS P, ELEMENTOS E, ELEMENTOS D WHERE E.ID = P.IdTipo and D.id = p.IdDebilidad