# TODO-listan toiminnot ja niiden testaaminen

Pojektista löydät TodoList- ja TodoTask luokat sekä ohjelman pääohjelman. Tutustu ohjelmakoodiin ja sen toimintoihin. Tee olemassa oleville metoideille yksikkötestit. Jos ohjelma ei toimi oikein, niin jatkokehitä luokkia ja metodien toimintaa. Esimerkiksi nyt ohjelman TodoTask-recordissa on vain kaksi ominaisuutta Id ja IsCompleted. Hyvässä todo-apissa on varmasti muitakin tietoja, joten kehitä recordia tarpeen mukaan tai muuta se tarpeen vaatiessa luokaksi! Alla on valmiina oleva koodi, jota olisi syytä jatkokehittää.
```c#
public record TodoTask(string TaskDescription) // ota selvää recordin toiminnasta
    {
        public int Id { get; init; } //init makes property immutable which means you cannot change value with set afterwards.
        public bool IsCompleted { get; init; }
        // mitä muuta tänne olisi tarpeen lisätä? Olisivatko deadline, tehtävän kuvaus ym. hyödyllisiä.


```

Tee sovellukseen uusi projekti TodoListTests. Projektin löydät kun etsit projektin luomisvaiheessa hakusanalla MSTest. Nykyään on käytössä myös muita testausframeworkkeja, jotka toimivat lähet samalla tavalla. Voit siis halutessasi luoda myös NUnit ja XUnit tyyppisen testiprojektin. 


