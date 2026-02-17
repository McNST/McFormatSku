# Report

###### 

###### **Schritt 1:**

&nbsp;	Geh in den Datamanager und Downloadest die Liste mit den Fehler Skus

&nbsp;	Öffne die Liste und Kopiere die Fehler Sku's raus, ohne den Header. 



###### **Schritt 2:**

&nbsp;	Dann Öffnest du die Console Anwendung zum formatieren der Sku's im Terminal




&nbsp;	Paste hier die Sku's rein, es wird eine Meldung aufkommen, bestätige einfach mit Enter oder Klicke auf Paste.

&nbsp;	Dann sollten die Formatierten Sku's schon kopiert sein, falls es nicht klappt markieren und strg+c.  

&nbsp;	SKU|SKU|SKU|SKU|SKU|SKU|SKU|SKU|SKU|SKU|SKU| <---- **Lösche das aller letzte "|" raus.**



###### **Schritt 3:**

&nbsp;	Nun Kannst du in Open Refine gehen, lade die Liste, die du via Mail oder von Sven bekommen hast, in das Tool. 

&nbsp;	

&nbsp;	**Fehler Sku's Rauslöschen:**

&nbsp;	Klicke auf den Pfeil neben **"HP Product Number"** und wähle **"Textfilter"**

&nbsp;	nun kopiere die Formatierten Sku's in den Textbereich links auf der Seite und **setzte das Häkchen bei "Regular Expression"** 

&nbsp;	jetzt werden alle Fehler Sku's angezeigt, klicke bei "**ALL"** auf den Pfeil und wähle **"Edit Row"** dann **"Remove Machtching Rows"**

&nbsp;	**Nun sind alle Fehler Sku's aus der Liste gelöscht.** 

###### 

###### **Schritt 4:**

&nbsp;	Nun gehe bei **"Total Sales Units"**, **"Inventory Units"** und **"Sales Units"** auf den Pfeil und wähle wieder **"Text Filter"** aus. 

&nbsp;	Sucher nach einander in den Suchfeldern nach **"-"** und Flagge die Zeilen, die einen Minusbestand haben. 

&nbsp;	wenn du alle Zeilen mit Minus bestand geflagged hast. gehst du auf **"ALL --> Facet --> Faced by Flag"** und wählst an der Seite **"True"**  aus. 



&nbsp;	Kopiere dir die Ganzen Sku's raus und Paste sie wieder ins Terminal.



###### **Schritt 5:**

&nbsp;	suche wieder wie in **Schritt 3** bei **"HP Product Number"** die nun Formatierten Sku's raus und lösche alle. 



		

###### **Schritt 6:**

&nbsp; gehe nun auf Transaction date und wähle **"Facet --> Custom Text Facet"**

&nbsp;	z.B. V1\_POS\_INV\_AMPLIFY\_RS70679\_**20260209\_20260215** Start und Enddatum kannst du dir aus dem Dateinamen entnehmen. 

&nbsp;	Paste folgenden Code: (erste Nummer Startdatum zweite Nummer Enddatum):

&nbsp;	

			if(isBlank(value), false,

 			 if(value.toString() < "20260209", true,

    			  if(value.toString() > "20260215", true, false)

			 )

			)

&nbsp;	

&nbsp;	kopiere dir wieder die Sku's raus und füge sie in die Consolen anwendung um erneut die HP Productnumbers zu filtern und die fehler Sku's zu 	löschen wie in **Schritt 3** beschrieben. 



###### **Schritt 7:**

&nbsp;	nun musst du die Liste Exportieren **"Export --> Excel 2007+"**  in der gedownloadeten Datei suchst du nun in Excel die verkäufe aus dem Webshop, 	halte dich hier an **UMUTS Prozessbeschreibung** und füge alle Daten ein, sollte es verkäufe in der Liste geben. 

&nbsp;	findest du unter C:\\Users\\nstrassguetl\\OneDrive - Metacomp GmbH Computer + Netzwerke\\Desktop\\HP Report\\Hp Amplifiy - neue Vorgabe



###### **Schritt 8:**

&nbsp;	Wenn du alles fertig hast, exportierst du die Datei in Excel - **"Speichern unter --> dateispeicherort wählen --> im Excplorer dateityp auf .csv änern und speichern"** nun musst du nurnoch die Datei um ein **".csv"**  ergänzen und du kannst sie im HP Portal hochladen. 







