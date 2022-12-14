# SQL Script

A korábbi ágazati informatika éretsséginél egy .txt fájlban adták meg az adatokat az SQL feladatban.
A program célja, hogy a legegyszerűbb módon létrhozzon minden megadott táblához egy INSERT INTO scriptet. 
Maximálisan 10 oszlopos adatbázist tud kezelni.

 * * *

# Funkciók

  * 10 oszlop kezelése
  * fájl megnyitási helyének kiválasztása grafikus felületen
  * script mentési helyének grafikus kiválasztása
  * egyéni táblanév választás
  * gyors script készítés, insert után a jellemzők beírásával
  * az utolsó <em>INSERT</em> sor után ; használata <code>if (item.ID != data.Last().ID)</code>
  * állítható szeparátor karakter <code>;</code> vagy <code>\t</code> (tabulátor)

<footer>Szabadon használható, módosítható</footer>

* * *
### Bővítés esetén

<b>Tables.cs</b>
  * először új jellemző lértehozása: <code> public string PropertyName { get; private set; } </code>
  * konstruktor létrehozása: 

<pre><code>
        public Table(string id, string prop1, ....) // az összes kezelni kívánt jellemző
        {
            ID = id;
            P1 = prop1;
            ...
            ...
        }
</code></pre>

<b>Program.cs</b>
 * az elágazás létrehozása az adott jellemzőszám kezeléséhez:

<pre><code>
    if (propCount == JellemzőkSzáma)
            {

                foreach (var item in File.ReadAllLines(path).Skip(1))
                {
                    m = item.Split(';');
                    data.Add(new Table(m[0], m[1], .... m[x])); // a jellemzők számától függően hozzá kell adni a <em>data</em> listához az adatokat
                }

                foreach (var item in data)
                {
                    if (item!= data.Last())
                    {
                        sql.Add($"({item.ID}, '{item.P1}'),"); //jellemzők hozzáadása, ezek lesznek az <em>INSERT VALUES</em> sorai
                    }
                    else sql.Add($"({item.ID}, '{item.P1}');"); //fenti sor másolása, ez az utolsó sor lesz a scriptben
                }
            }
</code></pre>


