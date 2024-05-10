INCLUDE globals.ink
->main
=== main ===
Co je? #speaker:Adam #portrait:adam_icon #layout:right
{stipacky_quest:
 {stipacky_complete:->complete}
-else:
    *[Máš ještě ty štípačky?]
        jj, proč?
        **[Zapomněl jsem si klíče od skříňky]
            Tak mohl bych ti ty štípačky dát, ale zadara to nebude more!
            ~stipacky_quest=true
            ->END
        **[Potřebuju k Batemanovi do skříňky]
            No tak to jo! Tos měl říct hned, tady máš!
            ~stipacky_quest=true
            ~stipacky_complete=true
            ->END
}
    *[Jak se máš?]
        ...
        ->main
    *[Jdu pryč]
        Gadžo proč na mě vůbec mluvíš?!
        ->END

===complete===
GG
->END