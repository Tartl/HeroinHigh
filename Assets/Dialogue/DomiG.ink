INCLUDE globals.ink
{adamQuestComplete:
Nemluv na mně, někdo mi kazí byznys
 - else:
{domiQuestAccept:->accepted}
{adamQuestAccept:
    ->adam_accepted
  - else:
  {domiQuestComplete:->domi_complete}
    Stočil bych kýbl...Nemáš náhodou?
    *[Nemám]
        Tak to běž radši za cigánem.
        ->END
    *[Jdu pryč]
        Příště neplýtvej mým časem.
        ->END
}
}

=== adam_accepted ===
Viděl jsem, jak ses bavil s Adamem, nechtěl od tebe ten cigoš něco?
*[Jo, chtěl po mně štípačky]
    Tak s tím ti můžu pomoct, když mi najdeš kýbl, dám ti štípačky.
    **[OK, zkusim ti sehnat kýbl]
    Dík.
    ~domiQuestAccept = true
     ->END
   {domiQuestComplete:
    **[Už mám kýbl]
        Fakt? dej mi ho
        ***[Ok]
        ~adamQuestComplete = true
        ->END
        ***[Ne]
        Zmrde
        ->END
    ->END
  - else:
    Otherwise this is written.
}

*[Co tě to zajímá?]
    Nebuď hned tak agresivní ne?
    **[Promiň]
    ->adam_accepted
*[Jdu pryč]
    Příště neplýtvej můj čas.
    ->END
=== domi_complete ===
Stočil bych kýbl...Nemáš náhodou?
*[Mám]
    Fakt dík moc! Tady máš štípačky.
    ~adamQuestComplete=true
        ->END
*[Nemám]
    Tak to běž radši za cigánem.
    ->END
*[Jdu pryč]
    Příště neplýtvej můj čas.
    ->END
=== accepted ===
Tak co, už máš ten kýbl?
{domiQuestComplete:
    *[Jo, mám]
    ~adamQuestComplete=true
    Fakt dik, tady máš štípačky
    ->END
    *[Ještě ne]
    Za chvilku začne hodina, tak dělej!
    ->END
  - else:
  *[Ještě ne]
    Za chvilku začne hodina, tak dělej!
    ->END
    
}


