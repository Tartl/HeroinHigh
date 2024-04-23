INCLUDE globals.ink
{adamQuestComplete:
Nemluv na mně, někdo mi kazí byznys #speaker:DomiG #portrait:domiG_iconvyhul #layout:left
 - else:
{domiQuestAccept:->accepted}
{adamQuestAccept:
    ->adam_accepted
  - else:
  {domiQuestComplete:->domi_complete}
    Stočil bych kýbl...Nemáš náhodou?#speaker:DomiG #portrait:domiG_icon #layout:left
    *[Nemám]
        Tak to běž radši za cigánem.
        ->END
    *[Jdu pryč]
        Příště neplýtvej mým časem.
        ->END
}
}

=== adam_accepted ===
Viděl jsem, jak ses bavil s Adamem, nechtěl od tebe ten cigoš něco?#speaker:DomiG #portrait:domiG_icon #layout:left
*[Jo, chtěl po mně štípačky]
   {domiQuestComplete:
   Tak s tím ti můžu pomoct, když mi najdeš kýbl, dám ti štípačky.
    **[Už mám kýbl]
        Fakt? dej mi ho
        ***[Ok]
        ~adamQuestComplete = true
        Dik moc#speaker:DomiG #portrait:domiG_iconvyhul #layout:left
        ->END
        ***[Ne]
        Zmrde
        ->END
  - else:
    Tak s tím ti můžu pomoct, když mi najdeš kýbl, dám ti štípačky.
    **[OK, zkusim ti sehnat kýbl]
    Dík.
    ~domiQuestAccept = true
     ->END
}

*[Co tě to zajímá?]
    Nebuď hned tak agresivní ne?
    **[Promiň]
    ->adam_accepted
*[Jdu pryč]
    Příště neplýtvej můj čas.
    ->END
=== domi_complete ===
Stočil bych kýbl...Nemáš náhodou?#speaker:DomiG #portrait:domiG_icon #layout:left
*[Mám]
    Fakt dík moc! Tady máš štípačky.#speaker:DomiG #portrait:domiG_iconvyhul #layout:left
    ~adamQuestComplete=true
        ->END
*[Nemám]
    Tak to běž radši za cigánem.
    ->END
*[Jdu pryč]
    Příště neplýtvej můj čas.
    ->END
=== accepted ===
Tak co, už máš ten kýbl?#speaker:DomiG #portrait:domiG_icon #layout:left
{domiQuestComplete:
    *[Jo, mám]
    ~adamQuestComplete=true
    Fakt dik, tady máš štípačky#speaker:DomiG #portrait:domiG_iconvyhul #layout:left
    ->END
    *[Ještě ne]
    Za chvilku začne hodina, tak dělej!
    ->END
  - else:
  *[Ještě ne]
    Za chvilku začne hodina, tak dělej!
    ->END
    
}


