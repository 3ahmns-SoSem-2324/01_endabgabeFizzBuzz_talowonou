Spielbeschreibung
Dieses Spiel basiert auf dem bekannten Kinderreim-Spiel "FizzBuzz". Ziel des Spiels ist es, herauszufinden, ob eine zufällig generierte Zahl durch 3, 5, sowohl 3 als auch 5, oder weder 3 noch 5 teilbar ist. Spieler interagieren mit dem Spiel über die Tastatur oder Makey Makey, um ihre Antworten einzugeben.

Spielziel
Das Ziel des Spiels ist es, die Teilbarkeit der generierten Zahl korrekt zu identifizieren. Dies fördert das Verständnis von Teilbarkeitsregeln und trainiert das schnelle Erkennen dieser Regeln in Zahlen.

Spielanleitung:

Steuerung
Leertaste (Space): Eine neue zufällige Zahl zwischen 1 und 1000 wird generiert.
Linkspfeil (Left Arrow): Überprüft, ob die Zahl durch 3 teilbar ist ("Fizz").
Aufwärtspfeil (Up Arrow): Überprüft, ob die Zahl durch 5 teilbar ist ("Buzz").
Rechtspfeil (Right Arrow): Überprüft, ob die Zahl durch sowohl 3 als auch 5 teilbar ist ("FizzBuzz").
Abwärtspfeil (Down Arrow): Überprüft, ob die Zahl weder durch 3 noch durch 5 teilbar ist.

Spielablauf
Drücke die Leertaste, um eine neue zufällige Zahl zu generieren.
Drücke einen der Pfeiltasten, um zu überprüfen, ob die Zahl die jeweilige Teilbarkeitsregel erfüllt:
Linkspfeil für Teilbarkeit durch 3.
Aufwärtspfeil für Teilbarkeit durch 5.
Rechtspfeil für Teilbarkeit durch sowohl 3 als auch 5.
Abwärtspfeil für keine Teilbarkeit durch 3 oder 5.
Die Hintergrundfarbe des Spiels ändert sich je nach Richtigkeit deiner Antwort:
Grün: Richtig
Rot: Falsch

Bei Nutzung von Makey Makey:
Anstatt der Pfeiltasten wird ein leitfähiges Material verwenden. Bei meinem Fall Gabeln.
Somit wird jede einzelne Taste durch eine Gabel ersetzt, die durch Berührung ausgelöst wird.

Testergebnisse
Drei Testpersonen im Alter von 14, 16 und 17 Jahren haben das Spiel getestet und ihr Feedback gegeben.
Allgemeine Benutzerfreundlichkeit:
Die Benutzeroberfläche wurde von den Testern als intuitiv bis mittel intuitiv bewertet. Während die Anweisungen und Hinweise im Spiel von den meisten als hilfreich bis sehr hilfreich empfunden wurden.
Spielerlebnis:
Das Spiel wurde allgemein als unterhaltsam empfunden. Die Herausforderung des Spiels wurde unterschiedlich wahrgenommen: ein Tester fand es einfach, während die anderen es als mittel bis herausfordernd beschrieben. Die Motivation, das Spiel wiederholt zu spielen, war bei den meisten Testern hoch, wobei ein Tester eine mittlere Motivation angab.
Fehlerbehandlung und Feedback:
Die Klarheit des Feedbacks im Spiel wurde von den Testern als klar bis sehr klar beschrieben.

Verbesserungen und Vorschläge:
Die Tester gaben mehrere Verbesserungsvorschläge:
Mehr Schwierigkeit inform von mehr Teilbarkeitsregeln hinzufügen
Besonders gut gefiel den Testern die Herausforderung und die klare, schnelle Rückmeldung des Spiels. Ein Tester lobte die App als großartige Übungsmöglichkeit für Mathematik.

Zusammenfassend lässt sich sagen, dass das Spiel gut angenommen wurde, aber noch Potenzial für Verbesserungen hat.

Startszene

Die Szene, die gestartet werden muss, enthält ein GameObject mit dem angehängten Manager-Skript sowie die entsprechenden UI-Elemente (Number, infoText, check) und das Hintergrund-Element (background).# 01_endabgabeFizzBuzz_talowonou


```mermaid
graph TD;
    A(Start)
    B(GenerateRandomNumber)
    C(Update)
    D(Space Key)
    E(Left Arrow)
    F(Up Arrow)
    G(Right Arrow)
    H(Down Arrow)
    I(Debug.Log)
    J(background.color)
    K(check.text/infoText.text)
    L(randomNum)
    M(Number.text)

    A --> L
    A --> B
    A --> J
    A --> M
    B --> L
    C --> D
    C --> E
    C --> F
    C --> G
    C --> H
    D --> L
    D --> M
    D --> J
    D --> J
    D --> K
    E --> L
    E --> I
    E --> J
    E --> K
    F --> L
    F --> I
    F --> J
    F --> K
    G --> L
    G --> I
    G --> J
    G --> K
    H --> L
    H --> I
    H --> J
    H --> K

