INCLUDE globals.ink
{adamQuestComplete:
To sou štipačky, co máš u sebe?
*[Jo, proč]
->naval_stipacky
    **[Ne]
    Achjo
    ->END
*[Ne?]
->END
  - else:
    {adamPrvni:Nazdar more! Jestli nevim něco o tvejch vlasech? To jakože sem černej, tak sem ti je vzal? No dobře něco možná vím...}
    ~adamPrvni=false
    {adamQuestAccept:->accepted|->main}
}

=== main ===
Když mi seženeš štípačky, řeknu ti kdo ví něco o tvejch vlasech
    *[Ok, zkusim ti je sehnat]
        Dík more
        ~adamQuestAccept = true
        ->END
    *[A k čemu je potřebuješ?]
        Nějakej gadžo mi dal na skříňku svůj zámek a já se do ní teď nedostanu
        **[Tak to ti pomůžu]
        Dik more
        ~adamQuestAccept = true
        ->END
        **[Bohužel ti nepomůžu]
        ->END
    *[Jdu pryč]
        Gadžo proč na mě vůbec mluvíš?!
        ->END
=== accepted ===
Tak co, už máš ty štípačky?
{adamQuestComplete:
    *[Jo, mám]
       ->naval_stipacky
    **[Vyhul mi prdel]
    Cos řek?!
    ->END
  - else:
    *[Ještě ne]
    ...
    ->END
}
=== naval_stipacky===
 Naval more
        **[Ok]
            Dik gadžo, konečně můžu čornout to kolo
            ***[COŽE]
                Ale nic, můžeš jít..
                Vlastně počkej, slyšel sem, že hledáš vlasy. Myslim, že byli u Batemana ve skříňce
                ->END