INCLUDE globals.ink
{adamQuestComplete:
Opravdu chceš jít dovnitř?#speaker:Dveře #portrait:dvere_icon #layout:right
*[Jasně]
Oki#end:true
->END
*[Ani ne]
...
->END
 - else:
Dveře#speaker:Dveře #portrait:dvere_icon #layout:right
*[Ajo]
...
->END
}

