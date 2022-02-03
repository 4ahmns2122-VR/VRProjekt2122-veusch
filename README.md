# VRProjektVeusch

### Spielidee/Ablauf/Tasks: ###
Das Labyrinth findet statt in einer Eishöhle. Nach kurzer Zeit bricht in einer Stelle der Höhle ein Feuer aus und damit die Höhle nicht zusammenbricht muss mithilfe eines Kübels und Wasser das Feuer gelöscht werden. Anfangs muss man einen Kübel finden, damit man darauf mit diesem Wasser aus einem Wasserfall zum Feuer Löschen benutzen kann. Nach dem löschen der drei Feuerstellen wird das Tor am Ende geöffnet und der SPieler kann das Labyrinth verlassen. Des Weiteren wird am Eingang der Höhle ein Hologram projeziert, was dem Spieler die Mission und Sachlage erklärt.<br> <br>
1.Task: den Kübel finden bzw. aufheben <br>
2.Task: Wasser in den Kübel schaufeln<br>
3.Task Feuer löschen<br>

### MVP
Eishöhle<br>
Kübel einsammeln<br>
Wasser einsammeln<br>
Feuer löschen<br>
### Milestones
Milestone: Kübel aufheben funktioniert, Türlässt sich öffnen, Wasser lässt sich in den Kübelfüllen 09.12.2021 - Wassser in den Eimer füllen hat noch nicht funktioniert<br>
Umgebung im Groben modelliert 13.01.2021 - Umgebung im Groben modellieren geschafft, Funktionen haben noch nicht einwandfrei Funktioniert <br>
Feuer implementiert, Feuer löschbar 27.01.2021<br>
Environment ausgearbeitet, Licht, usw., <br>
Soundimplementiert 10.02.2021 - endless loops noch nicht<br>
### Bemerkungen
Das Feuer habe ich selbst modelliert und den Wasserfall mithilfe eines Tutorials angepasst. Auch der projezierte DescriptionText am Beginn des Labyrinths wurde selbst programmiert und nirgends entnommen.

### Limitations
Ich habe versucht ein von physikalischen Kräften beeinflussbares Wasser zu machen, das hat aber leider nicht funktioniert, deswegen habe ich dieses wieder entfernt. Auch habe ich versucht die Eiscracks im Sound so zu programmieren, dass diese über den Verlauf des Spieles mehr werden, habe es aber nicht geschafft fehlerfrei umzusetzten. Darüber hinaus wollte ich eine Höhle mit Decke machen und habe dazu auch in Blender schon Modells modelliert, aber ich hatte Probleme diese ins Labyrinth einzubauen, da ich das ganze nachbauen müsste im halbwegs richtigen Maßstab. Ich wollte für das Feuer eine Basis hinzufügen aus der diese entspringt habe aber nichts passendes gefunden, deswegen habe ich es so gelassen.

Bei mir hat der Build nicht funktioniert, es kommt dabei immer ein Error.
![Error](https://user-images.githubusercontent.com/72389865/152388887-c42ca43a-8974-4c15-af75-d81f2f97890f.jpg)

### Software/Hardware Requirements
Oculus hardware requirements https://support.oculus.com/248749509016567/ You need a VR headset in this case an Oculus Rift <br>

Build Settings -> Player Settings -> XR Plug-in Manager -> tick off Oculus <br>

When downlaoded, you have compile time errors in the project. To solve them install the XR interaction toolkit package via the Package Manager. (!Enable in Advanced Settings Preview Packages).

### Arbeitsschritte
Labyrinth in Unity importieren<br>
Testen<br>
Whiteboxing<br>
Tür einstellen, öffnen lassen<br>
Kübel modellieren<br>
Kübel positionieren<br>
Kübel Pick Up tauglich machen<br>
Environment designen<br>
Environment modellieren<br>
Lichterquellen einfügen<br>
Research wie man den Sound einbindet<br>
Sounds suchen/aufnehmen<br>
Sound einbringen<br>
Wasserquelle modellieren<br>
Wasserquelle eintauchbar und einsammelbar machen<br>
Informieren wie man Feuer am besten in VR einbringt<br>
Feuer modellieren/einfügen<br>
Dummy Sounds<br>
Wenn Funktion passt Projekt weiter ausbauen<br>
Austesten von Funktionen und Features<br>
Features zusammenstellen<br>
Feedback einholen<br>
Feedback umsetzen<br>
Ausgang durch die zweite Tür<br>
Build<br>

### Packages
XR Interaction Toolkit 1.0.0-pre.8<br>
XR Plugin Management 4.2.0<br>
Visual Studio Editor 2.0.11<br>
JetBrains Rider Editor 2.0.7<br>
Oculus XR Plugin 1.10.0<br>
Post Processing 3.1.1<br>
Test Framework 1.1.29<br>
TextMeshPro 3.0.6<br>
Timeline 1.4.8<br>
Unity UI 1.0.0<br>
Version Control 1.9.0<br>
Visual Studio Code Editor 1.2.4<br>


### Audio
Wassertropfen<br>
Feuer-sfx<br>
Hall<br>
Wind<br>
Atmosphere<br>
Wasser<br>

Die Soundgestaltung im Spiel, soll für eine etwas kühlere Atmosphäre sorgen. Nachdem man das Labyrinth betritt, beginnt durch einen Trigger die Höhle zu "cracken", bzw. das Eis zu brechen. Durch den die Feuersound soll das finden der Feuerstellen erleichtert werden. Nachdem löschen beginnt ein Sound für den Dampf bzw. die Kollision von Wasser und Feuer klar zu stellen.  

### Worauf/Plattform?: 
Oculus Rift


### Assets: 
https://www.youtube.com/watch?v=d4bTpkvBwrs <br>
https://www.youtube.com/watch?v=w8dZl8uheKA&list=PLF_C4B6VLkIepN4WqxFhkUaoju8SHyBNu&index=2 <br>
https://www.youtube.com/watch?v=3cJ_uq1m-dg&t=3s <br>

Sound von: https://freesound.org/ <br>
https://assetstore.unity.com/packages/3d/props/interior/door-free-pack-aferar-148411<br>
https://assetstore.unity.com/packages/2d/textures-materials/nature/snowy-rock-material-137092<br>
https://assetstore.unity.com/packages/3d/props/tools/stylized-western-wooden-bucket-191513<br>
https://assetstore.unity.com/packages/2d/textures-materials/sky/allsky-free-10-sky-skybox-set-146014<br>
https://assetstore.unity.com/packages/3d/environments/landscapes/snow-mountain-24690<br>
https://assetstore.unity.com/packages/3d/environments/landscapes/free-snow-mountain-63002<br>
https://assetstore.unity.com/packages/essentials/tutorial-projects/unity-particle-pack-127325<br>




#### Copyright by veusch 
