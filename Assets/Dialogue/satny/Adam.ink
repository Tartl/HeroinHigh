INCLUDE globals.ink
{stipackyQuestComplete:
    More nehaj ma už!
    ->END
}
{stipackyQuestAccept:->accepted|->main}

=== accepted ===
Už jsi ji odlákal?
*[Jo]
OK, tady máš štípačky
~stipackyQuestComplete=true
->END
*[Ne]
->END

=== main ===
Co je? #speaker:Adam #portrait:adam_icon #layout:right
    *[Máš ještě ty štípačky?]
        jj, proč?
        **[Zapomněl jsem si klíče od skříňky]
            ~stipackyQuestAccept=true
            Tak mohl bych ti ty štípačky dát, ale zadara to nebude more!
            ***[Dobře, co potřebuješ?]
                Když odvedeš uklízečku někam bokem, kde neuvidí sem k téhle skříňce, tak ti je dám.
                ****[Ok, zkusim to]
                    Fakt? Tak dik more!
                    ->END
                ****[To neudělám]
                    Tvoje rozhodnutí #death:true    
                    ->END
            ***[Vždyť jsem ti je sám před chvílí sehnal...]
                No, a teď už sou moje!
            ->END
        **[Potřebuju k Batemanovi do skříňky]
            No tak to jo! Tos měl říct hned, tady máš!
            ~stipackyQuestAccept=true
            ~stipackyQuestComplete=true
            ->END
->END

