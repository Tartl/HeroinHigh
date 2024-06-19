INCLUDE globals.ink
{borekHlasky>50:... |{random()}}

== function random ==
~borekHlasky++ 
#speaker:Bozo #portrait:bozo_icon #layout:right #audio:BOZO fifofifo.wav
{shuffle:
 - ~ return "Dej si čaj s citrónem"
 - ~ return "FIFO FIFO"
 - ~ return "Barbershop"
 - ~ return "SMASH!"
 - ~ return "Povidla pitý vodově"
 - ~ return "Niggaballs"
 - ~ return "HEHHEEHEHHE"
}