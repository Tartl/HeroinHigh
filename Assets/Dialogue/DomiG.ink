INCLUDE globals.ink
{domiQuestAccept:->accepted}
{adamQuestAccept:->adam_accepted}
Stočil bych kýbl...Nemáš náhodou?
{domiQuestComplete:->domi_complete}
*[Nemám]
    Tak to běž radši za cigánem.
    ->END
*[Jdu pryč]
        Příště neplýtvej mým časem.
        ->END
=== adam_accepted ===
Viděl jsem, jak ses bavil s Adamem, nechtěl od tebe ten cigoš něco?
*[Jo, chtěl po mně štípačky]
    Tak s tím ti můžu pomoct, když mi najdeš kýbl, dám ti štípačky.
    **[OK, zkusim ti sehnat kýbl]
    Dík.
    ~domiQuestAccept = true
    ->END
*[Co tě to zajímá?]
    Nebuď hned tak agresivní ne?
    **[Promiň]
    ->adam_accepted
*[Jdu pryč]
    Příště neplýtvej můj čas.
    ->END
=== domi_complete ===
*[Mám]
    Fakt dík moc! Tady máš ty štípačky.
    **[(Vzít si štípačky a odejít)]
        ->END
*[Nemám]
    Tak to běž radši za cigánem.
    ->END
*[Jdu pryč]
    Příště neplýtvej můj čas.
    ->END
=== accepted ===
Tak co, už máš ten kýbl?
{domiQuestComplete:*[Jo, mám]}
*[Ještě ne]
Za chvilku začne hodina, tak dělej!
->END