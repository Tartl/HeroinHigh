INCLUDE globals.ink
{random()}
*[Co meleš]
    los pičos #audio:SANCHEZ los picos.wav
*[Dal bych si okurku]
Un cucumbero #audio:SANCHEZ uncucumbero.mp3
*[Tož nazdar]
Vamos Vamos #audio:SANCHEZ VAMOS VAMOS
*[Jsi v česku tak mluv česky!!!!!!]
Chcípni puta! #death:true #audio:SANCHEZ chcipni puta.mp3

== function random ==
#speaker:Sanchez #portrait:sanchez_icon #layout:left #audio:SNCHEZ hola.mp3
{shuffle:
 - ~ return "hola"
 - ~ return "receta de tacos como de tabla de contenidos hoy les eneno como hacker tacox mexicanos, un clasico de la gastronomia munidial! Haciendo "
 - ~ return "Esto no puede"
 - ~ return "Ano nuevo, vida nueva "
 - ~ return "A mal tiempo, bueno cara"
 - ~ return "lo saca es un traficante de drogas"
 - ~ return "tacos"
}