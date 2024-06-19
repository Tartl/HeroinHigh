INCLUDE globals.ink
{venekComplete:
Už sem ti řek všechno co vim! #speaker:Adam #portrait:adam_icon #layout:right #audio:ADAM uzjsemreklvsechno.wav
    ->END
}
{adamQuestComplete:
    {adamQuestAccept:->accepted}
    To sou štipačky, co máš u sebe? #speaker:Adam #portrait:adam_icon #layout:right #audio:ADAM stipacky.wav
    *[Jo, proč]
    ->naval_stipacky
    *[Ne?]
    ->END
  - else: 
    {adamPrvni:
    Nazdar more! Jestli nevim něco o tvejch vlasech? To jakože sem černej, tak sem ti je vzal? No dobře něco možná vím... #speaker:Adam #portrait:adam_icon #layout:right #audio:ADAM blajsemcernejbla.wav
    }
    ~adamPrvni=false
    {adamQuestAccept:->accepted|->main}
}
=== main ===
Když mi seženeš štípačky, řeknu ti kdo ví něco o tvejch vlasech #speaker:Adam #portrait:adam_icon #layout:right #audio:ADAM donesmistipacky.mp3
    *[Ok, zkusim ti je sehnat]
        Dík more#audio:ADAM dikmore.wav
        ~adamQuestAccept = true
        ->END
    *[A k čemu je potřebuješ?]
        Nějakej gadžo mi dal na skříňku svůj zámek a já se do ní teď nedostanu #audio:ADAM zamek.mp3
        **[Proč nejdeš za školníkem?]
            Dneska prej neni ve škole #audio:ADAM dneskaprejneniveskole.mp3
            ->main
        **[Ajo]
        Takže tak more #audio:ADAM takzetakmore.mp3
        ->END
    *[Jdu pryč]
        Gadžo proč na mě vůbec mluvíš?! #audio:ADAM gadzoprocnamevubecmluvis.wav
        ->END
=== accepted ===
Tak co, už máš ty štípačky? #speaker:Adam #portrait:adam_icon #layout:right #audio:ADAM takcouzmastystipacky.mp3
{adamQuestComplete:
    *[Jo, mám]
       ->naval_stipacky
    *[Vyhul mi prdel]
    Cos řek?! #audio:ADAM cosrek.mp3 #death:true
    ->END
  - else:
    *[Ještě ne]
    ...
    ->END
}
=== naval_stipacky===
 Naval more #audio:ADAM navalmore.mp3
        **[Ok]
            Dik gadžo, konečně můžu čornout to kolo #audio:ADAM dikkonecnemuzuvzittokolo.mp3
            ~venekComplete = true
            ***[COŽE]
                Ale nic, můžeš jít.. #audio:ADAM alenicvlastnepockej.wav
                Vlastně počkej, slyšel sem, že hledáš vlasy. Myslim, že byli u Batemana ve skříňce
                ->END