INCLUDE globals.ink
{adamQuestComplete:
Nemluv na mně, někdo mi kazí byznys #speaker:DomiG #portrait:domiG_iconvyhul #layout:left #audio:DOMIG nemluv na me byznys.mp3
 - else:
{domiQuestAccept:->accepted}
{adamQuestAccept:
    ->adam_accepted
  - else:
  {domiQuestComplete:->domi_complete}
    Stočil bych kýbl...Nemáš náhodou?#speaker:DomiG #portrait:domiG_icon #layout:left #audio:DOMIG stocilbychkyblnemas.mp3
    *[Nemám]
        Tak to běž radši za cigánem. #audio:DOMIG taktobezrasi.mp3
        ->END
    *[Jdu pryč]
        Příště neplýtvej mým časem. #audio:DOMIG pristeneplztvejmimcasem.wav
        ->END
}
}

=== adam_accepted ===
Viděl jsem, jak ses bavil s Adamem, nechtěl od tebe ten cigoš něco?#speaker:DomiG #portrait:domiG_icon #layout:left #audio:DOMIG videljsemjaksesbavilsadamem.mp3
*[Jo, chtěl po mně štípačky]
   {domiQuestComplete:
   Tak s tím ti můžu pomoct, když mi najdeš kýbl, dám ti štípačky. #audio:DOMIG takstimtimuzupomoct.mp3
    **[Už mám kýbl]
        Fakt? dej mi ho#audio:DOMIG fakdejmiho.mp3
        ***[Ok]
        ~adamQuestComplete = true
        Dik moc#speaker:DomiG #portrait:domiG_iconvyhul #layout:left #audio:DOMIG dikmoc.mp3
        ->END
        ***[Ne]
        Zmrde #death:true
        ->END
  - else:
    Tak s tím ti můžu pomoct, když mi najdeš kýbl, dám ti štípačky. #audio:DOMIG takstimtimuzupomoct.mp3
    **[OK, zkusim ti sehnat kýbl]
    Dík. #audio:DOMIG dik.mp3
    ~domiQuestAccept = true
     ->END
}

*[Co tě to zajímá?]
    Nebuď hned tak agresivní ne? #audio:DOMIG nebudhnedtakagresivni.mp3
    **[Promiň]
    ->adam_accepted
*[Jdu pryč]
    Příště neplýtvej můj čas. #audio:DOMIG pristeneplztvejmimcasem.wav
    ->END
=== domi_complete ===
Stočil bych kýbl...Nemáš náhodou?#speaker:DomiG #portrait:domiG_icon #layout:left #audio:DOMIG stocilbychkyblnemas.mp3
*[Mám]
    Fakt dík moc! Tady máš štípačky.#speaker:DomiG #portrait:domiG_iconvyhul #layout:left #audio:DOMIG faktdikmoctadymas.mp3
        ~adamQuestComplete=true
        ->END
*[Nemám]
    Tak to běž radši za cigánem.#audio:DOMIG taktobezrasi.mp3
    ->END
*[Jdu pryč]
    Příště neplýtvej můj čas.#audio:DOMIG pristeneplztvejmimcasem.wav
    ->END
=== accepted ===
Tak co, už máš ten kýbl?#speaker:DomiG #portrait:domiG_icon #layout:left #audio:DOMIG takcomastenkybl.mp3
{domiQuestComplete:
    *[Jo, mám]
    ~adamQuestComplete=true
    Fakt dik, tady máš štípačky#speaker:DomiG #portrait:domiG_iconvyhul #layout:left #audio:DOMIG faktdikmoctadymas.mp3
    ->END
    *[Ještě ne]
    Za chvilku začne hodina, tak dělej! #audio:DOMIG zachvilkuzacnehodina.mp3
    ->END
  - else:
  *[Ještě ne]
    Za chvilku začne hodina, tak dělej! #audio:DOMIG zachvilkuzacnehodina.mp3
    ->END
    
}


