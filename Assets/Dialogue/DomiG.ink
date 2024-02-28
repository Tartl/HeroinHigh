INCLUDE globals.ink
{adamQuestAccept:->adam_accepted}

Stočil bych kýbl...Nemáš náhodou?
*[Nemám]
    Tak to běž radši za cigánem
=== adam_accepted ===
Viděl jsem, jak ses bavil s Adamem, nechtěl od tebe ten cigoš něco?
*[Jo, chtěl po mně štípačky]
    Tak s tím ti můžu pomoct, když mi najdeš kýbl, dám ti štípačky.
    **[OK, zkusim ti sehnat kýbl]
    Dík
    ~adamQuestComplete = true
    ->END
*[Co tě to zajímá?]
    Nebuď hned tak agresivní ne?
    **[Promiň]
    ->adam_accepted