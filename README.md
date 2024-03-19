# Lern-Periode 4
## Ihor Tienietilov
## 20.02.24 bis 02.04.24

## Grob-Planung

**1.** Wo stehen Sie mit Ihren Noten? In welchen Modulen waren Sie besonders stark; in welchen sind die ungenügend? Welche davon sind besonders wichtig?

*Überraschenderweise beendete ich das Semester mit ausgezeichneten Noten für mein Deutschniveau und meine allgemeinen Kenntnisse. Alles lief gut und reibungslos genug. Im Moment bin ich besonders stark in Modul 164, ich kann SQL-Code perfekt verstehen und kenne mich mit Datenbanken im Allgemeinen aus. Ursprünglich hatte ich mir so etwas von den Modulen versprochen, aber die ersten Module, die ich durchgegangen bin, haben mich ein bisschen traurig gemacht. 120, oder 122, ich weiß es nicht mehr, war ein interessantes Modul, wenn auch nicht sehr klar. Obwohl es nicht so weit von mir entfernt war, fiel es mir schwer, mich in das Ganze hineinzudenken. Ich denke, Modul 164 ist das wichtigste, weil es mir eine neue Art der Datenverarbeitung (genauer gesagt, der Datenspeicherung) eröffnet - Datenbanken.*


**2.** Was hatten Sie sich am Ende von LP3 vorgenommen? Was war Ihr VBV? Wie könnten Sie diesen besonders gut üben?

*Mein Ziel am Ende von LP3 war es, alles rechtzeitig fertig zu bekommen, das habe ich gerade noch geschafft, mit einer Dehnung. VBV? Ich weiß es nicht. Das Zeitmanagement leidet bei mir immer noch, es ist schwer, die Aufgaben richtig zu verteilen und die Zeit für jede Aufgabe zu bestimmen. Ich nehme mir immer wieder Projekte vor, die zu groß für einen relativ kurzen Zeitraum sind, obwohl RABEB ganz gut geworden ist.*


**3.** **Neu**: Was möchten Sie Neues lernen?

*Im Moment stehe ich am Scheideweg zwischen dem Erlernen einer Bibliothek, die mit Discord oder Telegramm funktioniert, aber ich werde wahrscheinlich Telegram als Basis nehmen. Es gibt auch eine Option, um Tetris in Unity zu tun (Hinweis: Ich habe mit ihm vor gearbeitet, und ziemlich erfolgreich. im Allgemeinen begann ich С# lernen nur mit Unity)*


**4.** Was wäre ein geeignetes Projekt für diese LP4?

*Ich habe bereits oben geantwortet, aber ich neige eher dazu, einen Telegram-Bot zu schreiben. Ich denke, ich sollte mir die Menge und Qualität der Tutorials ansehen, die ich finden kann*

## 20.02.2024
Zumindest heute habe ich mich für ein Thema entschieden. Ich werde einen Telegramm-Bot schreiben. Zuerst hatte ich nicht die geringste Idee, was genau ich darin implementieren will, und dann erinnerte ich mich daran, dass ich diese kleine Tradition mit meinen Freunden in unserer Gruppe habe - jeden Montag und Freitag entsprechende Bilder zu schicken. Ich beschloss, einen Bot zu schreiben, der automatisch ein zufälliges Bild aus dem richtigen Ordner auswählt und es zur richtigen Zeit versendet (gegen vier Uhr morgens, wenn alle zur Schule aufstehen). Ich werde auch nur zufällige Bilder zum gleichen Thema, aber nicht direkt mit Montag / Freitag, die zu einer zufälligen Zeit mit einer Abkühlung von etwa vier Stunden gesendet werden wird, zu implementieren.
Ich habe höchstens einen einfachen Code implementiert, der ein Bot-Token in Telegram nimmt, und ich kann sogar schon auf die Bilder antworten. (138 Wörter)

## 27.02.2024

- [x] Versuchen, mit [KI](https://gemini.google.com/) Code zu erzeugen. Analysieren.
- [x] Schauen sich die [Dokumentation](https://telegrambots.github.io/book/1/quickstart.html) an, um genauer zu verstehen, wie genau ich Fotos aus dem Code-Ordner hochladen kann.
- [x] Schauen sich [dieses](https://youtu.be/eUjshrMUUig?si=gBcF2v5nErr_h7az) Tutorial noch einmal an, um die Grundlagen der Verwendung der API zu verstehen.
- [x] Um mit der [KI](https://gemini.google.com/) und meinem Freund (ja-ja, der) über bestimmte obskure Punkte zu diskutieren.

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --------------- | -------------------- | -------------- | -------------- | -------- |
| 1 | Gemini (von Google) | Prompt | Ein Code, der nicht funktioniert, der aber auch zum allgemeinen Verständnis beiträgt, denn Gemini verweist auf Quellen. | Ja. |
| 2 | Dokumentation | Überprüfung der Dokumentation mit einem klaren Ziel | Eine konkrete Antwort wurde nicht gefunden, wohl aber ein Verständnis. | Ja. |
| 3 | Tutorial | Anschauen des Videos | Ich erinnerte mich an alles und begann, die Basis besser zu verstehen. | Ja. |
| 4 | KI | Prompt mit Fragen, und die Fragen selbst an einen Freund. | Ich habe nie konkrete Antworten gefunden, ich kann nur auf einen Freund hoffen. | Ja. |

Heute habe ich mir vor allem verschiedene Tutorials und einige Informationen angesehen, und im Allgemeinen habe ich bereits eine Vorstellung davon, wie der Code aussehen sollte. Die Struktur selbst und wie es im Allgemeinen funktionieren sollte, ist klar. Aber was den Code angeht... Ich werde mich weiter mit dem Thema beschäftigen. Meine Idee ist, dass die API Zugriff auf drei Ordner haben soll, in denen sich die benötigten Bilder befinden, und dann, je nach Wochentag, wählt der Bot den benötigten Ordner aus und nimmt ein zufälliges Bild von dort. Klingt etwas kompliziert, aber in der Praxis ist es gar nicht so kompliziert, man muss sich nur ein bisschen mehr mit der API beschäftigen. (113 Wörter)

## 05.03.2024

- [x] Von [Gemini](https://gemini.google.com/) geschriebenen Code bearbeiten
- [x] Besprechung des von mir geschriebenen Codes mit einem Freund und Behebung von Fehlern, die auftreten
- [x] Weiteres Verständnis der [API](https://telegrambots.github.io/book/1/quickstart.html), um zu verstehen, wie man mit Gruppen arbeitet, nicht nur mit privaten Nachrichten von Benutzern.
- [x] Suche nach weiteren Tutorials zur Arbeit mit der Zeit (und Timern)

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --------------- | -------------------- | -------------- | -------------- | -------- |
| 1 | Gemini (von Google) | Nicht funktionierender Code | Bearbeitung des Codes | Ja. |
| 2 | Freund (ha-ha) | Fragen zum Code im Allgemeinen und zu Fehlern, die auftreten | Ich erkannte genauer, wie genau ich mit dem Code arbeiten muss, und kam auch zu einem umfassenderen Verständnis des Codes und der anschließend auftretenden (möglichen) Fehler | Ja. |
| 3 | API | Arbeit mit Gruppen | Ich recherchierte die verfügbaren Informationen und begann, besser zu verstehen, wie man mit Gruppen arbeitet, im Gegensatz zu privaten Nachrichten mit einem Benutzer. | Ja. |
| 4 | Suche nach Tutorials | Das nie gefundene Tutorial | Leider konnte ich trotz meiner Suche kein normales Tutorial finden, aus dem ich etwas verstehen würde. | Nein. |

Heute habe ich spezifischer mit dem Code gearbeitet, der von Gemini generiert wurde, und habe auch allgemein verstanden, welche Fehler bei der Arbeit mit solchem Code auftreten können, und ich habe auch verstanden, wie genau ich den Code schreiben sollte, um diese Fehler zu vermeiden, aber auch, damit alles so funktioniert, wie es sollte. Außerdem habe ich einige Probleme besprochen und meinem Freund (der bald großartig sein wird, haha) ein paar Fragen zu meinem Code gestellt, auf die ich zwar keine Antwort bekommen habe (weil er auch morgens beschäftigt ist, was logisch ist), aber einige davon konnte er in seiner Freizeit beantworten. Außerdem werde ich heute nach Schulschluss mit ihm weiter an dem Code arbeiten, was mir helfen wird, den Code allgemein zu verstehen und ihn auch tatsächlich zu schreiben. (130 Wörter)

## 12.03.2024

- [x] Neugestaltung aller Objektnamen (Variablen, Felder, Methoden usw.) gemäss Pascal Case und Camel Case.
- [x] Aufteilung von Konstanten in separate statische Klassen zur leichteren Änderung.
- [x] Umbenennung von Objekten (Variablen, Felder, Methoden usw.), so dass sie genau beschreiben, was sie speichern bzw. direkt tun, um die Lesbarkeit des Codes zu verbessern.
- [x] Verringerung der Anzahl der Zuständigkeiten und Gründe für Änderungen in Methoden.

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --------------- | -------------------- | -------------- | -------------- | -------- |
| 1 | Variablen, Felder, Methoden, usw. | Seltsame und unsinnige Namen | Namen gemäss den Regeln für das Schreiben von Code. | Ja. |
| 2 | Konstanten | Seltsame und inkongruente Anordnung von Konstanten nach Klassen. | Aufteilung der Konstanten auf separate statische Klassen, um Änderungen zu erleichtern. | Ja. |
| 3 | Variablen, Felder, Methoden, usw. | Seltsame, obskure und unsinnige Namen, die manchmal nicht beschreiben, was das Objekt tun soll | Umbenennung von Objekten, so dass sie genau beschreiben, was sie speichern / tun, direkt für eine bessere Lesbarkeit des Codes. | Ja. |
| 4 | Methoden. | Grosse Anzahl von Zuständigkeiten und Gründen für die Änderung von Methoden. | Verringerung der Anzahl der Zuständigkeiten und der Gründe für Änderungen in Methoden. | Ja. |

Heute war ich damit beschäftigt, meinen gesamten Code für die weitere Arbeit mit ihm qualitativ vorzubereiten. Mit den Regeln, nach denen gerade der Code geschrieben werden soll, bzw. dem Finden dieser Regeln - ein Freund hat mir dabei geholfen. Alles andere habe ich von Hand gemacht, gemäß den Regeln für das Schreiben von Code. Als Erstes habe ich alle Namen so geändert, dass sie direkt ihre Aufgabe widerspiegeln, damit es klar und lesbar ist. Als nächstes benannte ich alle Objekte nach Pascal und Camel Case um. Die vorletzte Maßnahme war, alle Konstanten in separate statische Klassen zu verschieben, um die Lesbarkeit zu verbessern, und schließlich habe ich die Anzahl der Verantwortlichkeiten und Gründe für Methoden reduziert. (115 Wörter)

## 19.03.2024

- [x] Der Code wird in kleinere Klassen unterteilt, so dass jede Klasse nur einen Grund für eine Änderung hat. (auch hier wieder SRP-Überlagerung).
- [x] Verschieben des Bot-Tokens in Umgebungsvariablen für mehr Sicherheit.

## Reflexion

Formen Sie Ihre Zusammenfassungen in Hinblick auf Ihren VBV zu einem zusammenhängenden Text von 100 bis 200 Wörtern (wieder mit Angabe in Klammern).
