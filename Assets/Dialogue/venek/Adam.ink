INCLUDE globals.ink
{venekComplete:
Už sem ti řek všechno co vim! #speaker:Adam #portrait:adam_icon #layout:right #audio:ADAM uzjsemreklvsechno
    ->END
}
{adamQuestComplete:
    {adamQuestAccept:->accepted}
    To sou štipačky, co máš u sebe? #speaker:Adam #portrait:adam_icon #layout:right
    *[Jo, proč]
    ->naval_stipacky
    *[Ne?]
    ->END
  - else: 
    {adamPrvni:
    Nazdar more! Jestli nevim něco o tvejch vlasech? To jakože sem černej, tak sem ti je vzal? No dobře něco možná vím... #speaker:Adam #portrait:adam_icon #layout:right #audio:ADAM blajsemcernejbla.mp3
    }
    ~adamPrvni=false
    {adamQuestAccept:->accepted|->main}
}
=== main ===
Když mi seženeš štípačky, řeknu ti kdo ví něco o tvejch vlasech #speaker:Adam #portrait:adam_icon #layout:right
    *[Ok, zkusim ti je sehnat]
        Dík more
        ~adamQuestAccept = true
        ->END
    *[A k čemu je potřebuješ?]
        Nějakej gadžo mi dal na skříňku svůj zámek a já se do ní teď nedostanu
        **[Proč nejdeš za školníkem?]
            Dneska prej neni ve škole
            ->main
        **[Ajo]
        Takže tak more
        ->END
    *[Jdu pryč]
        Gadžo proč na mě vůbec mluvíš?!
        ->END
=== accepted ===
Tak co, už máš ty štípačky? #speaker:Adam #portrait:adam_icon #layout:right
{adamQuestComplete:
    *[Jo, mám]
       ->naval_stipacky
    *[Vyhul mi prdel]
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
            ~venekComplete = true
            ***[COŽE]
                Ale nic, můžeš jít..
                Vlastně počkej, slyšel sem, že hledáš vlasy. Myslim, že byli u Batemana ve skříňce
                ->END