INCLUDE globals.ink
{domiQuestComplete:
Tam už nic nenajdeš...#speaker:Koš #portrait:kos_nemakybl #layout:right
->END
 - else:
 V koši něco vidíš, chceš šáhnout do koše?#speaker:Koš #portrait:kos_makybl #layout:right
*[Strčit pracku do koše]
Našel jsi kýbl!#speaker:Koš #portrait:kos_nemakybl #layout:right
~domiQuestComplete = true
->END
*[Tak tam nešáhnu]
->END
}

