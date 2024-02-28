INCLUDE globals.ink
{adamQuestAccept:->accepted | ->main}
Nazdar more! Jestli nevim něco o tvejch vlasech? To jakože sem černej, tak sem ti je vzal? No dobře něco možná vím...
=== main ===
Když mi seženeš štípačky, řeknu ti kdo ví něco o tvejch vlasech
    *[Ok, zkusim ti je sehnat]
        Dík more
        ~adamQuestAccept = true
        ->END
    *[A k čemu je potřebuješ?]
        To tě nemusí zajímat!
        **[Sorry brácho]
        ->main
    *[Jdu pryč]
        Gadžo proč na mě vůbec mluvíš?!
        ->END
=== accepted ===
Tak co, už máš ty štípačky?
{adamQuestComplete:*[Jo, mám]}
*[Ještě ne]
->END