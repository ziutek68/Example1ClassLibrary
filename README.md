## Example1ClassLibrary

Przykład biblioteki, gotowej do wywołania z pozomiu aplikacji produkcyjno-logistycznych pakietu Rekord.ERP.
Składa sie z dwóch projektów:
* Example1ClassLibrary - właściwy projekt, który tworzy nasz przykładowy DLL
* LaunchExample1CL - prosty programik do uruchamiania tej DLL-ki pod testy

Dzięki zastosowania własnej technologii do kastomizacji aplikacji opartej na XML, można m.in. podłączać pliki DLL napisane w środowisku Visual Studio. 
Wymagane środowisko do kompilacji to ASP.NET 4 a klasy dostępne z tego pakietu muszą być oznaczone [ComVisible(true)] i posiadać metodę Execute z 3 parametrami, tak jak w tym przykładzie. Dwa parametry są wejściowe, tekstowe. 

Pierwszy to stała lista parametrów takich jak:  
* ALIAS - alias do bazy danych firebird
* USERNAME - login użytkownika
* PASSWORD - zakodowane hasło do bazy
* HANDLE - handler aplikacji wywołującej
* DBPATH - ścieżka do bazy firebird
* SHAREDCLIHANDLE - 
* NAZWAFIRMY - nazwa firmy
* MIASTOFIRMY - siedziba firmy
* APLIKACJA - nazwa aplikacji wywołującej

Drugi to lista definiowana w XML. Trzeci parametr to tekst zwracany do Delphi. Tu też oczekujemy listy w formacie nazwaparametru=wartosc. Funkcja zwraca kod o typie integer. Gdy 0 to wszystko OK, gdy wartość ujemna to wyświetlony jest komunikat o błędzie. Więcej na [forum firmy Rekord](https://forum.rekord.com.pl/)

## Licencja
Ten przykład można nieodpłatnie używać, dystrybuować oraz modyfikować [licencja MIT]
[Rekord SI](https://www.rekord.com.pl)
