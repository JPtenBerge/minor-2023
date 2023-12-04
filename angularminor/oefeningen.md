# Oefeningen

We gaan een miniversie maken van datumprikker.nl. Specifiek gaan we een webapp bouwen om onze contacten te beheren en om toekomstige evenementen in te plannen.

## Oefening 1: data tonen middels databinding

Toon een lijst van contacten in een tabel. Hou van een contact bij:

* Voornaam
* Achternaam
* E-mailadres

## Oefening 2: pipe maken die namen correct weergeeft

Namen correct weergeven is lastig. Maak een pipe die dit regelt door de voor- en achternaam van een contact samen te voegen.

```html
<td>{{contact.firstName}} {{contact.surname}}</td>
```

wordt dus:

```html
<td>{{contact | contactName}}</td>
```

## Oefening 3: unittesten

Unittest je pipe.

```sh
ng test
```

## Oefening 4: formulier met validatie

Voeg boven je tabel een formulier toe om nieuwe contacten toe te kunnen voegen. Met formuliervalidaties natuurlijk.



